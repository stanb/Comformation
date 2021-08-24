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
            /// [Public NAT gateway only] The allocation ID of the Elastic IP address that&#39;s associated with the NAT
            /// gateway.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AllocationId { get; set; }

            /// <summary>
            /// ConnectivityType
            /// Indicates whether the NAT gateway supports public or private connectivity.
            /// Required: No
            /// Type: String
            /// Allowed values: private | public
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectivityType { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in which the NAT gateway is located.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The tags for the NAT gateway.
            /// 	
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
