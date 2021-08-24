using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace Properties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-properties.html
    /// </summary>
    public class Properties
    {

        /// <summary>
        /// DnsProperties
        /// DNS properties for the public DNS namespace.
        /// Required: No
        /// Type: PublicDnsPropertiesMutable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DnsProperties")]
        public PublicDnsPropertiesMutable DnsProperties { get; set; }

    }
}
