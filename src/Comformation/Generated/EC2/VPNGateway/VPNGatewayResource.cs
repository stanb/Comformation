using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNGateway
{
    /// <summary>
    /// AWS::EC2::VPNGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gateway.html
    /// </summary>
    public class VPNGatewayResource : ResourceBase
    {
        public class VPNGatewayProperties
        {
            /// <summary>
            /// AmazonSideAsn
            /// 		
            /// The private Autonomous System Number (ASN) for the Amazon side of a BGP session.
            /// 	
            /// Required: No
            /// Type: Long
            /// Update requires: Replacement
            /// </summary>
            public Union<long, IntrinsicFunction> AmazonSideAsn { get; set; }

            /// <summary>
            /// Tags
            /// Any tags assigned to the virtual private gateway.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection the virtual private gateway supports.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ipsec. 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPNGateway";

        public VPNGatewayProperties Properties { get; } = new VPNGatewayProperties();

    }
}
