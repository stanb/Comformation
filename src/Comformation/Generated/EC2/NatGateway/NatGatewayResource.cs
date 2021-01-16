using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NatGateway
{
    /// <summary>
    /// AWS::EC2::NatGateway
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
            /// The tags (key-value pairs) to associate with this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NatGateway";

        public NatGatewayProperties Properties { get; } = new NatGatewayProperties();

    }
}
