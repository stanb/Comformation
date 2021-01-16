using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.ResolverEndpoint
{
    /// <summary>
    /// AWS::Route53Resolver::ResolverEndpoint IpAddressRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html
    /// </summary>
    public class IpAddressRequest
    {

        /// <summary>
        /// Ip
        /// 		
        /// The IP address that you want to use for DNS queries.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 7
        /// Maximum: 36
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ip")]
        public Union<string, IntrinsicFunction> Ip { get; set; }

        /// <summary>
        /// SubnetId
        /// 		
        /// The ID of the subnet that contains the IP address.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
