using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNConnectionRoute
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection-route.html
    /// </summary>
    public class VPNConnectionRouteResource : ResourceBase
    {
        public class VPNConnectionRouteProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection-route.html#cfn-ec2-vpnconnectionroute-cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-connection-route.html#cfn-ec2-vpnconnectionroute-connectionid
            /// </summary>
			public Union<string, IntrinsicFunction> VpnConnectionId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPNConnectionRoute";
        
        public VPNConnectionRouteProperties Properties { get; } = new VPNConnectionRouteProperties();
    }
}
