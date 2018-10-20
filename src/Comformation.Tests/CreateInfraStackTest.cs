using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.EC2;
using Amazon.EC2.Model;
using Comformation.IntrinsicFunctions;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Comformation.Tests
{
    public class CreateInfraStackTest
    {
        private readonly AmazonCloudFormationClient _cloudformation;

        public CreateInfraStackTest()
        {
            _cloudformation = new AmazonCloudFormationClient(RegionEndpoint.EUWest1);

        }

        [Fact]
        public async Task CreateFullStack()
        {
            var ec2Client = new AmazonEC2Client(RegionEndpoint.EUWest1);
            var keyResult = await ec2Client.CreateKeyPairAsync(new CreateKeyPairRequest($"comformation-{Guid.NewGuid()}"));
            try
            {
                // Generate template
                var template = CreateFullTemplate();

                var request = new CreateStackRequest
                {
                    StackName = $"ComformationTestInfraTemplate-{Guid.NewGuid()}",
                    TemplateBody = template.ToString(),
                    Parameters = new List<Amazon.CloudFormation.Model.Parameter>
                    {
                        new Amazon.CloudFormation.Model.Parameter
                        {
                            ParameterKey = "KeyPairName",
                            ParameterValue = keyResult.KeyPair.KeyName
                        }
                    }
                };

                try
                {
                    // Create stack
                    var createResponse = await _cloudformation.CreateStackAsync(request);

                    try
                    {
                        // Get created stack details
                        var stack = await _cloudformation.GetCreatedStack(createResponse.StackId);

                        // Validate created stack
                        AssertCreatedStuck(stack, keyResult.KeyPair);
                    }
                    finally
                    {
                        // cleanup
                        var deleteResponse =
                            await _cloudformation.DeleteStackAsync(new DeleteStackRequest
                            {
                                StackName = createResponse.StackId
                            });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            finally
            {
                await ec2Client.DeleteKeyPairAsync(new DeleteKeyPairRequest(keyResult.KeyPair.KeyName));
            }
        }

        private void AssertCreatedStuck(Stack stack, KeyPair keyPair)
        {
            var host = stack.Outputs.First(x => x.OutputKey == "InstancePublicIp").OutputValue;
            var keyFile = new PrivateKeyFile(new MemoryStream(Encoding.UTF8.GetBytes(keyPair.KeyMaterial)));
            using (var client = new SshClient(host, "ubuntu", keyFile))
            {
                client.Connect();
                Assert.True(client.IsConnected);
                var cmd = client.RunCommand("pwd");
                var cmdResult = cmd.Execute();
                Assert.Equal("/home/ubuntu\n", cmdResult);
                client.Disconnect();
            }
        }

        private Template CreateFullTemplate()
        {
            var instanceSize = new Parameter
            {
                LogicalId = "InstanceSize",
                Type = ParameterType.String,
                Default = "t2.micro",
                Description = "Instance Size"
            };

            var instanceAmi = new Parameter
            {
                LogicalId = "InstanceAmi",
                Type = ParameterType.ImageId,
                Default = "ami-0773391ae604c49a4", // Ubuntu Server 16.04 LTS (HVM), SSD Volume Type
                Description = "Instance AMI"
            };

            var keyPair = new Parameter
            {
                LogicalId = "KeyPairName",
                Type = ParameterType.KeyPairKeyName,
                Description = "Key Pair Name"
            };

            var vpc = new EC2.VPC.VPCResource
            {
                LogicalId = "VPC",
                Properties =
                {
                    CidrBlock = "10.0.0.0/16",
                    Tags = new List<Tag>
                    {
                        new Tag { Key = "Name", Value = "comformation-vpc" }
                    }
                }
            };

            var publicSubnet = new EC2.Subnet.SubnetResource
            {
                LogicalId = "PublicSubnet",
                Properties =
                {
                    VpcId = vpc.Ref(),
                    CidrBlock = "10.0.0.0/24",
                    MapPublicIpOnLaunch = true,
                    Tags = new List<Tag>
                    {
                        new Tag { Key = "Name", Value = "comformation-public-subnet" }
                    }
                }
            };

            var internetGateway = new EC2.InternetGateway.InternetGatewayResource
            {
                LogicalId = "InternetGateway",
                Properties =
                {
                    Tags = new List<Tag>
                    {
                        new Tag { Key = "Name", Value = "comformation-igw" }
                    }
                }
            };

            var gatewayAttachment = new EC2.VPCGatewayAttachment.VPCGatewayAttachmentResource
            {
                LogicalId = "VpcInternetGatewayAttachment",
                Properties =
                {
                    InternetGatewayId = internetGateway.Ref(),
                    VpcId = vpc.Ref()
                }
            };

            var routeTable = new EC2.RouteTable.RouteTableResource
            {
                LogicalId = "PublicRouteTable",
                Properties =
                {
                    VpcId = vpc.Ref(),
                    Tags = new List<Tag>
                    {
                        new Tag { Key = "Name", Value = "public-route-table" }
                    }
                }
            };

            var routeToInternet = new EC2.Route.RouteResource
            {
                LogicalId = "RouteTableInternetGatewayAttachment",
                Properties =
                {
                    DestinationCidrBlock = "0.0.0.0/0",
                    GatewayId = internetGateway.Ref(),
                    RouteTableId = routeTable.Ref()
                }
            };

            var publicSubnetRoutAssociation = new EC2.SubnetRouteTableAssociation.SubnetRouteTableAssociationResource
            {
                LogicalId = "PublicSubnetRouteAssociation",
                Properties =
                {
                    RouteTableId = routeTable.Ref(),
                    SubnetId = publicSubnet.Ref()
                }
            };

            var sshSecurityGroup = new EC2.SecurityGroup.SecurityGroupResource
            {
                LogicalId = "sshSG",
                Properties =
                {
                    GroupName = "ssh-sg",
                    GroupDescription = "Enable SSH access via port 22",
                    VpcId = vpc.Ref(),
                    SecurityGroupIngress = new List<EC2.SecurityGroup.Ingress>
                    {
                        new EC2.SecurityGroup.Ingress
                        {
                            IpProtocol = "tcp",
                            FromPort = 22,
                            ToPort = 22,
                            CidrIp = "0.0.0.0/0"
                        }
                    },
                    SecurityGroupEgress = new List<EC2.SecurityGroup.Egress>
                    {
                        new EC2.SecurityGroup.Egress
                        {
                            IpProtocol = "-1", // all protocols
                            FromPort = -1, // all ports
                            ToPort = -1, // all ports
                            CidrIp = "0.0.0.0/0"
                        }
                    }
                }
            };

            var instance = new EC2.Instance.InstanceResource
            {
                LogicalId = "Instance",
                Properties =
                {
                    ImageId = instanceAmi.Ref(),
                    InstanceType = instanceSize.Ref(),
                    KeyName = keyPair.Ref(),
                    SubnetId = publicSubnet.Ref(),
                    SecurityGroupIds = new List<Union<string, IntrinsicFunction>>
                    {
                        sshSecurityGroup.Ref()
                    },
                    Tags = new List<Tag>
                    {
                        new Tag { Key = "Name", Value = "comformation-instance" }
                    }
                },
                DependsOn = vpc.LogicalId
            };

            var ipAddress = new EC2.EIP.EIPResource
            {
                LogicalId = "PublicIP",
                Properties =
                {
                    InstanceId = instance.Ref(),
                    Domain = vpc.LogicalId
                },
                DependsOn = gatewayAttachment.LogicalId
            };

            var template = new Template
            {
                Parameters = new Parameters
                {
                    instanceSize,
                    instanceAmi,
                    keyPair
                },
                Resources = new Resources
                {
                    vpc,
                    publicSubnet,
                    internetGateway,
                    gatewayAttachment,
                    routeTable,
                    routeToInternet,
                    publicSubnetRoutAssociation,
                    sshSecurityGroup,
                    instance,
                    ipAddress
                },
                Outputs = new Outputs
                {
                    new Output
                    {
                        LogicalId = "InstancePublicIp",
                        Value = Fn.GetAtt(instance.LogicalId, EC2.Instance.InstanceAttributes.PublicIp)
                    },
                    new Output
                    {
                        LogicalId = "InstancePrivateIp",
                        Value = Fn.GetAtt(instance.LogicalId, EC2.Instance.InstanceAttributes.PrivateIp)
                    }
                }
            };

            return template;
        }
    }
}
