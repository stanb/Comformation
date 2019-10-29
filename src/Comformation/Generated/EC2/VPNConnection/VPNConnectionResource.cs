using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNConnection
{
    /// <summary>
    /// AWS::EC2::VPNConnection
    /// Specifies a VPN connection between a virtual private gateway and a VPN customer gateway or a transit gateway
    /// and a VPN customer gateway.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection.html
    /// </summary>
    public class VPNConnectionResource : ResourceBase
    {
        public class VPNConnectionProperties
        {
            /// <summary>
            /// CustomerGatewayId
            /// The ID of the customer gateway at your end of the VPN connection.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CustomerGatewayId { get; set; }

            /// <summary>
            /// StaticRoutesOnly
            /// Indicates whether the VPN connection uses static routes only. Static routes must be used for devices
            /// that don&#39;t support BGP.
            /// If you are creating a VPN connection for a device that does not support Border Gateway Protocol
            /// (BGP), you must specify true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StaticRoutesOnly { get; set; }

            /// <summary>
            /// Tags
            /// Any tags assigned to the VPN connection.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TransitGatewayId
            /// The ID of the transit gateway associated with the VPN connection.
            /// You must specify either TransitGatewayId or VpnGatewayId, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TransitGatewayId { get; set; }

            /// <summary>
            /// Type
            /// The type of VPN connection.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: ipsec. 1
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// VpnGatewayId
            /// The ID of the virtual private gateway at the AWS side of the VPN connection.
            /// You must specify either TransitGatewayId or VpnGatewayId, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

            /// <summary>
            /// VpnTunnelOptionsSpecifications
            /// 		
            /// The tunnel options for a VPN connection.
            /// 	
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
