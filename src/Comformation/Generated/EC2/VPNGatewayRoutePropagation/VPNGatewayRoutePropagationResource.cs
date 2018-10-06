using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNGatewayRoutePropagation
{
    /// <summary>
    /// AWS::EC2::VPNGatewayRoutePropagation
    /// Enables a virtual private gateway (VGW) to propagate routes to the routing tables of a VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html
    /// </summary>
    public class VPNGatewayRoutePropagationResource : ResourceBase
    {
        public class VPNGatewayRoutePropagationProperties
        {
            /// <summary>
            /// RouteTableIds
            /// A list of routing table IDs that are associated with a VPC. The routing tables must be associated
            /// with the same VPC that the virtual private gateway is attached to.
            /// Required: Yes
            /// Type: List of route table IDs
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RouteTableIds { get; set; }

            /// <summary>
            /// VpnGatewayId
            /// The ID of the virtual private gateway that is attached to a VPC. The virtual private gateway must be
            /// attached to the same VPC that the routing tables are associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPNGatewayRoutePropagation";
        
        public VPNGatewayRoutePropagationProperties Properties { get; } = new VPNGatewayRoutePropagationProperties();

    }
}
