using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index CapacityUnitsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-capacityunitsconfiguration.html
    /// </summary>
    public class CapacityUnitsConfiguration
    {

        /// <summary>
        /// StorageCapacityUnits
        /// The amount of extra storage capacity for an index. Each capacity unit provides 150 Gb of storage
        /// space or 500,000 documents, whichever is reached first.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageCapacityUnits")]
        public Union<int, IntrinsicFunction> StorageCapacityUnits { get; set; }

        /// <summary>
        /// QueryCapacityUnits
        /// The amount of extra query capacity for an index. Each capacity unit provides 0. 5 queries per second
        /// and 40,000 queries per day.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryCapacityUnits")]
        public Union<int, IntrinsicFunction> QueryCapacityUnits { get; set; }

    }
}
