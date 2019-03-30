using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS Cloud Map ServiceDiscovery DnsRecord
    /// The DnsRecord property type 		specifies settings for one DNS record that you want AWS Cloud Map to create when
    /// you register an instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html
    /// </summary>
    public class DnsRecord
    {

        /// <summary>
        /// Type
        /// 					
        /// The DNS type of the record that you want AWS Cloud Map to create. Supported record types include A,
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
        /// Type: Number
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("TTL")]
        public Union<double, IntrinsicFunction> TTL { get; set; }

    }
}
