using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// Amazon Route&#160;53 ServiceDiscovery DnsConfig
    /// The DnsConfig property type specifies 		settings for the records that you want Amazon Route&#160;53 to create when
    /// you register an instance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsconfig.html
    /// </summary>
    public class DnsConfig
    {

        /// <summary>
        /// DnsRecords
        /// 					
        /// Contains one DnsRecord element for each DNS record that you want Route&#160;53 to create when you
        /// register 						an instance.
        /// 					
        /// Required: Yes
        /// 					
        /// Type: List of 						Amazon Route&#160;53 ServiceDiscovery DnsRecord
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("DnsRecords")]
        public List<DnsRecord> DnsRecords { get; set; }

        /// <summary>
        /// RoutingPolicy
        /// </summary>
        [JsonProperty("RoutingPolicy")]
        public Union<string, IntrinsicFunction> RoutingPolicy { get; set; }

        /// <summary>
        /// NamespaceId
        /// 					
        /// The ID of the namespace that you want to use for DNS configuration.
        /// 					
        /// Required: Yes
        /// 					
        /// Type: String
        /// 					
        /// Update requires: Replacement
        /// 				
        /// </summary>
        [JsonProperty("NamespaceId")]
        public Union<string, IntrinsicFunction> NamespaceId { get; set; }

    }
}
