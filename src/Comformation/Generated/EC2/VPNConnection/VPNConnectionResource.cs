using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNConnection
{
    /// <summary>
    /// AWS::EC2::VPNConnection
    /// Creates a new VPN connection between an existing virtual private gateway and a VPN customer gateway.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html
    /// </summary>
    public class VPNConnectionResource : ResourceBase
    {
        public class VPNConnectionProperties
        {
            /// <summary>
            /// CustomerGatewayId
            /// The ID of the customer gateway. This can either be an embedded JSON object or a reference to a
            /// Gateway ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CustomerGatewayId { get; set; }

            /// <summary>
            /// StaticRoutesOnly
            /// Indicates whether the VPN connection requires static routes.
            /// Required: Conditional. If you are creating a VPN connection for a device that does not support
            /// Border Gateway Protocol (BGP), you must specify true.
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StaticRoutesOnly { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the resource.
            /// Required: No
            /// Type: Resource Tag.
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection this virtual private gateway supports.
            /// Example: &quot;ipsec. 1&quot;
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// VpnGatewayId
            /// The ID of the virtual private gateway. This can either be an embedded JSON object or a reference to
            /// a Gateway ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

            /// <summary>
            /// VpnTunnelOptionsSpecifications
            /// The tunnel options for the VPN connection. Duplicates not allowed.
            /// Required: No
            /// Type: List of VpnTunnelOptionsSpecification
            /// Update requires: Replacement
            /// </summary>
			public List<VpnTunnelOptionsSpecification> VpnTunnelOptionsSpecifications { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPNConnection";

        public VPNConnectionProperties Properties { get; } = new VPNConnectionProperties();

    }
}
