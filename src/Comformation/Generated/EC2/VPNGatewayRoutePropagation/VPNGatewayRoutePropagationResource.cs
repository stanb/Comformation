using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNGatewayRoutePropagation
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html
    /// </summary>
    public class VPNGatewayRoutePropagationResource : ResourceBase
    {
        public class VPNGatewayRoutePropagationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html#cfn-ec2-vpngatewayrouteprop-routetableids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> RouteTableIds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html#cfn-ec2-vpngatewayrouteprop-vpngatewayid
            /// </summary>
			public Union<string, IntrinsicFunction> VpnGatewayId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPNGatewayRoutePropagation";
        
        public VPNGatewayRoutePropagationProperties Properties { get; } = new VPNGatewayRoutePropagationProperties();
    }
}
