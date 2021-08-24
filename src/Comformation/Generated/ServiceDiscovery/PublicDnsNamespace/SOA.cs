using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace SOA
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-soa.html
    /// </summary>
    public class SOA
    {

        /// <summary>
        /// TTL
        /// The time to live (TTL) for purposes of negative caching.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TTL")]
        public Union<double, IntrinsicFunction> TTL { get; set; }

    }
}
