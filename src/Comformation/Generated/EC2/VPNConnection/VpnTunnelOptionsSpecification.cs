using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPNConnection
{
    /// <summary>
    /// AWS::EC2::VPNConnection VpnTunnelOptionsSpecification
    /// The tunnel options for a VPN connection.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html
    /// </summary>
    public class VpnTunnelOptionsSpecification
    {

        /// <summary>
        /// PreSharedKey
        /// 		
        /// The pre-shared key (PSK) to establish initial authentication between the virtual private 			gateway
        /// and customer gateway.
        /// 		
        /// Constraints: Allowed characters are alphanumeric characters and . _. Must be between 8 and 64
        /// characters in length and cannot start with zero (0).
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PreSharedKey")]
        public Union<string, IntrinsicFunction> PreSharedKey { get; set; }

        /// <summary>
        /// TunnelInsideCidr
        /// 		
        /// The range of inside IP addresses for the tunnel. Any specified CIDR blocks must be unique 			across
        /// all VPN connections that use the same virtual private gateway.
        /// 		
        /// Constraints: A size /30 CIDR block from the 169. 254. 0. 0/16 range. The 			following CIDR blocks
        /// are reserved and cannot be used:
        /// 		
        /// 			 			 			 			 			 			 			 		 				 169. 254. 0. 0/30 			 				 169. 254. 1. 0/30 			 				 169. 254.
        /// 2. 0/30 			 				 169. 254. 3. 0/30 			 				 169. 254. 4. 0/30 			 				 169. 254. 5. 0/30 			 				
        /// 169. 254. 169. 252/30 			
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TunnelInsideCidr")]
        public Union<string, IntrinsicFunction> TunnelInsideCidr { get; set; }

    }
}
