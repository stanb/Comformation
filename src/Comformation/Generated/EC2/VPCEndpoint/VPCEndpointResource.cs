using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpoint
{
    /// <summary>
    /// AWS::EC2::VPCEndpoint
    /// Creates a VPC endpoint that you can use to establish a private connection between your VPC and another AWS
    /// service without requiring access over the Internet, a VPN connection, or AWS Direct Connect. For more
    /// information, see CreateVpcEndpoint.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html
    /// </summary>
    public class VPCEndpointResource : ResourceBase
    {
        public class VPCEndpointProperties
        {
            /// <summary>
            /// VpcId
            /// The ID of the VPC in which the endpoint will be used.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// RouteTableIds
            /// One or more route table IDs that are used by the VPC to reach the endpoint.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> RouteTableIds { get; set; }

            /// <summary>
            /// ServiceName
            /// The name of the service. To get a list of available services, use DescribeVpcEndpointServices or get
            /// the name from the service provider.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            /// PolicyDocument
            /// [Gateway endpoint] A policy to attach to the endpoint that controls access to the service. The
            /// policy must be valid JSON. The default policy allows full access to the AWS service. For more
            /// information, see Controlling Access to Services in the Amazon VPC User Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// IsPrivateDnsEnabled
            /// </summary>
			public Union<bool, IntrinsicFunction> IsPrivateDnsEnabled { get; set; }

            /// <summary>
            /// SubnetIds
            /// [Interface endpoint] The ID of one or more subnets in which to create an endpoint network interface.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// [Interface endpoint] The ID of one or more security groups to associate with the endpoint network
            /// interface.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            /// VPCEndpointType
            /// </summary>
			public Union<string, IntrinsicFunction> VPCEndpointType { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPCEndpoint";
        
        public VPCEndpointProperties Properties { get; } = new VPCEndpointProperties();
    }
}
