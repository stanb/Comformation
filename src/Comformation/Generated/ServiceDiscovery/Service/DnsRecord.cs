using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// Amazon Route&#160;53 ServiceDiscovery DnsRecord
    /// The DnsRecord property type 		specifies settings for one DNS record that you want Amazon Route&#160;53 to create
    /// when you register an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html
    /// </summary>
    public class DnsRecord
    {

        /// <summary>
        /// Type
        /// 					
        /// The DNS type of the record that you want Route&#160;53 to create. Supported record types include A,
        /// 						AAAA, and SRV.
        /// 					
        /// Required: Yes
        /// 					
        /// Type: String
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// TTL
        /// 					
        /// The amount of time, in seconds, that you want DNS resolvers to cache the settings for this record.
        /// 					
        /// Required: Yes
        /// 					
        /// Type: String
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("TTL")]
        public Union<string, IntrinsicFunction> TTL { get; set; }

    }
}
