using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverRule
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverRule TargetAddress
    /// In a 			CreateResolverRule 			request, an array of the IPs that you want to forward DNS queries to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html
    /// </summary>
    public class TargetAddress
    {

        /// <summary>
        /// Ip
        /// 		
        /// One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 7
        /// Maximum: 36
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ip")]
        public Union<string, IntrinsicFunction> Ip { get; set; }

        /// <summary>
        /// Port
        /// 		
        /// The port at Ip that you want to forward DNS queries to.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<string, IntrinsicFunction> Port { get; set; }

    }
}
