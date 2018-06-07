using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    /// AWS::EC2::SecurityGroup
    /// Creates an Amazon EC2 security group. To create a VPC security group, use the VpcId property.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html
    /// </summary>
    public class SecurityGroupResource : ResourceBase
    {
        public class SecurityGroupProperties
        {
            /// <summary>
            /// GroupDescription
            /// A description of the security group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-groupdescription
            /// </summary>
			public Union<string, IntrinsicFunction> GroupDescription { get; set; }

            /// <summary>
            /// GroupName
            /// The name of the security group. For valid values, see the GroupName parameter of the
            /// CreateSecurityGroup action in the Amazon EC2 API Reference.
            /// If you don't specify a GroupName, AWS CloudFormation generates a unique physical ID and uses that ID
            /// for the group name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-groupname
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// SecurityGroupEgress
            /// A list of Amazon EC2 security group egress rules.
            /// Required: No
            /// Type: List of EC2 Security Group Rule
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-securitygroupegress
            /// </summary>
			public Union<List<Egress>, IntrinsicFunction> SecurityGroupEgress { get; set; }

            /// <summary>
            /// SecurityGroupIngress
            /// A list of Amazon EC2 security group ingress rules.
            /// Required: No
            /// Type: List of EC2 Security Group Rule
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-securitygroupingress
            /// </summary>
			public Union<List<Ingress>, IntrinsicFunction> SecurityGroupIngress { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcId
            /// The physical ID of the VPC. You can obtain the physical ID by using a reference to an AWS::EC2::VPC,
            /// such as: { "Ref" : "myVPC" }.
            /// For more information about using the Ref function, see Ref.
            /// Required: Yes, for VPC security groups without a default VPC
            /// Type: String
            /// Update requires: Replacement
            /// Note For more information about VPC security groups, see Security Groups in the Amazon VPC User
            /// Guide.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group.html#cfn-ec2-securitygroup-vpcid
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SecurityGroup";
        
        public SecurityGroupProperties Properties { get; } = new SecurityGroupProperties();
    }

	public static class SecurityGroupAttributes
	{
        public static readonly ResourceAttribute<string> GroupId = new ResourceAttribute<string>("GroupId");
        public static readonly ResourceAttribute<string> VpcId = new ResourceAttribute<string>("VpcId");
	}
}
