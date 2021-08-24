using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowVpcInterface
{
    /// <summary>
    /// AWS::MediaConnect::FlowVpcInterface
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowvpcinterface.html
    /// </summary>
    public class FlowVpcInterfaceResource : ResourceBase
    {
        public class FlowVpcInterfaceProperties
        {
            /// <summary>
            /// FlowArn
            /// The Amazon Resource Name (ARN) of the flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FlowArn { get; set; }

            /// <summary>
            /// Name
            /// The name of the VPC Interface. This value must be unique within the current flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that you created when you set up MediaConnect as a
            /// trusted service.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The VPC security groups that you want MediaConnect to use for your VPC configuration. You must
            /// include at least one security group in the request.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SubnetId
            /// The subnet IDs that you want to use for your VPC interface.
            /// A range of IP addresses in your VPC. When you create your VPC, you specify a range of IPv4 addresses
            /// for the VPC in the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10. 0. 0.
            /// 0/16. This is the primary CIDR block for your VPC. When you create a subnet for your VPC, you
            /// specify the CIDR block for the subnet, which is a subset of the VPC CIDR block.
            /// The subnets that you use across all VPC interfaces on the flow must be in the same Availability Zone
            /// as the flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }

        public string Type { get; } = "AWS::MediaConnect::FlowVpcInterface";

        public FlowVpcInterfaceProperties Properties { get; } = new FlowVpcInterfaceProperties();

    }

    public static class FlowVpcInterfaceAttributes
    {
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> NetworkInterfaceIds = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("NetworkInterfaceIds");
    }
}
