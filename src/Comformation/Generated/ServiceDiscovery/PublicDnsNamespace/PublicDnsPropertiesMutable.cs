using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace PublicDnsPropertiesMutable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-publicdnspropertiesmutable.html
    /// </summary>
    public class PublicDnsPropertiesMutable
    {

        /// <summary>
        /// SOA
        /// Start of Authority (SOA) record for the hosted zone for the public DNS namespace.
        /// Required: No
        /// Type: SOA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SOA")]
        public SOA SOA { get; set; }

    }
}
