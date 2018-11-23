using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverRule
{
    /// <summary>
    /// Amazon Route&#160;53 ResolverRule TargetAddress
    /// The 	TargetAddress property type specifies the IP addresses that you want Resolver to forward DNS queries to.
    /// 	These are typically the IP addresses of DNS resolvers in your network.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverrule-targetaddress.html
    /// </summary>
    public class TargetAddress
    {

        /// <summary>
        /// Ip
        /// 	
        /// One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ip")]
        public Union<string, IntrinsicFunction> Ip { get; set; }

        /// <summary>
        /// Port
        /// 	
        /// The port at Ip that you want to forward DNS queries to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<string, IntrinsicFunction> Port { get; set; }

    }
}
