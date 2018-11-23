using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NatGateway
{
    /// <summary>
    /// AWS::EC2::NatGateway
    /// The AWS::EC2::NatGateway resource creates a network address translation (NAT) gateway in the specified public
    /// subnet. Use a NAT gateway to allow instances in a private subnet to connect to the Internet or to other AWS
    /// services, but prevent the Internet from initiating a connection with those instances. For more information and
    /// a sample architectural diagram, see NAT Gateways in the Amazon VPC User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-natgateway.html
    /// </summary>
    public class NatGatewayResource : ResourceBase
    {
        public class NatGatewayProperties
        {
            /// <summary>
            /// AllocationId
            /// The allocation ID of an Elastic IP address to associate with the NAT gateway. If the Elastic IP
            /// address is associated with another resource, you must first disassociate it.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AllocationId { get; set; }

            /// <summary>
            /// SubnetId
            /// The public subnet in which to create the NAT gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this resource. Use tags to
            /// manage your resources.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NatGateway";

        public NatGatewayProperties Properties { get; } = new NatGatewayProperties();

    }
}
