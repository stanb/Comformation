using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PrivateDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PrivateDnsNamespace Properties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-privatednsnamespace-properties.html
    /// </summary>
    public class Properties
    {

        /// <summary>
        /// DnsProperties
        /// DNS properties for the private DNS namespace.
        /// Required: No
        /// Type: PrivateDnsPropertiesMutable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DnsProperties")]
        public PrivateDnsPropertiesMutable DnsProperties { get; set; }

    }
}
