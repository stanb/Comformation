using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PrivateDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PrivateDnsNamespace PrivateDnsPropertiesMutable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-privatednspropertiesmutable.html
    /// </summary>
    public class PrivateDnsPropertiesMutable
    {

        /// <summary>
        /// SOA
        /// Fields for the Start of Authority (SOA) record for the hosted zone for the private DNS namespace.
        /// Required: No
        /// Type: SOA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SOA")]
        public SOA SOA { get; set; }

    }
}
