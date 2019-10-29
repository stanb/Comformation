using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain ZoneAwarenessConfig
    /// Specifies zone awareness configuration options. Only use if ZoneAwarenessEnabled is true.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-zoneawarenessconfig.html
    /// </summary>
    public class ZoneAwarenessConfig
    {

        /// <summary>
        /// AvailabilityZoneCount
        /// If you enabled multiple Availability Zones (AZs), the number of AZs that you want the domain to use.
        /// Valid values are 2 and 3. Default is 2.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZoneCount")]
        public Union<int, IntrinsicFunction> AvailabilityZoneCount { get; set; }

    }
}
