using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNConnectionRoute
{
    /// <summary>
    /// AWS::EC2::VPNConnectionRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection-route.html
    /// </summary>
    public class VPNConnectionRouteResource : ResourceBase
    {
        public class VPNConnectionRouteProperties
        {
            /// <summary>
            /// DestinationCidrBlock
            /// The CIDR block associated with the local subnet of the customer network.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            /// VpnConnectionId
            /// The ID of the VPN connection.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpnConnectionId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPNConnectionRoute";

        public VPNConnectionRouteProperties Properties { get; } = new VPNConnectionRouteProperties();

    }
}
