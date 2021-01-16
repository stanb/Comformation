using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CustomerGateway
{
    /// <summary>
    /// AWS::EC2::CustomerGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-customer-gateway.html
    /// </summary>
    public class CustomerGatewayResource : ResourceBase
    {
        public class CustomerGatewayProperties
        {
            /// <summary>
            /// BgpAsn
            /// For devices that support BGP, the customer gateway&#39;s BGP ASN.
            /// Default: 65000
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> BgpAsn { get; set; }

            /// <summary>
            /// IpAddress
            /// The Internet-routable IP address for the customer gateway&#39;s outside interface. The address must be
            /// static.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags for the customer gateway.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection that this customer gateway supports (ipsec. 1).
            /// Required: Yes
            /// Type: String
            /// Allowed values: ipsec. 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::EC2::CustomerGateway";

        public CustomerGatewayProperties Properties { get; } = new CustomerGatewayProperties();

    }
}
