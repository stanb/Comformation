using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnRoute
{
    /// <summary>
    /// AWS::EC2::ClientVpnRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnroute.html
    /// </summary>
    public class ClientVpnRouteResource : ResourceBase
    {
        public class ClientVpnRouteProperties
        {
            /// <summary>
            /// ClientVpnEndpointId
            /// 		
            /// The ID of the Client VPN endpoint to which to add the route.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientVpnEndpointId { get; set; }

            /// <summary>
            /// TargetVpcSubnetId
            /// 		
            /// The ID of the subnet through which you want to route traffic. The specified subnet must be 			an
            /// existing target network of the Client VPN endpoint.
            /// 	
            /// Alternatively, if you&#39;re adding a route for the local network, specify local.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetVpcSubnetId { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// A brief description of the route.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DestinationCidrBlock
            /// 		
            /// The IPv4 address range, in CIDR notation, of the route destination. For example:
            /// 		
            /// 			 	 			 			 		 		 To add a route for Internet access, enter 0. 0. 0. 0/0 To add a route for a
            /// peered VPC, enter the peered VPC&#39;s IPv4 CIDR range To add a route for an on-premises network, enter
            /// the AWS Site-to-Site VPN connection&#39;s IPv4 CIDR range To add a route for the local network, enter
            /// the client CIDR range
            /// 	 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationCidrBlock { get; set; }

        }

        public string Type { get; } = "AWS::EC2::ClientVpnRoute";

        public ClientVpnRouteProperties Properties { get; } = new ClientVpnRouteProperties();

    }
}
