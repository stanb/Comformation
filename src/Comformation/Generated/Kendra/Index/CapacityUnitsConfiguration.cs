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
        /// The amount of extra storage capacity for an index. A single capacity unit provides 30 GB of storage
        /// space or 100,000 documents, whichever is reached first.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageCapacityUnits")]
        public Union<int, IntrinsicFunction> StorageCapacityUnits { get; set; }

        /// <summary>
        /// QueryCapacityUnits
        /// The amount of extra query capacity for an index and GetQuerySuggestions capacity.
        /// A single extra capacity unit for an index provides 0. 1 queries per second or approximately 8,000
        /// queries per day.
        /// GetQuerySuggestions capacity is five times the provisioned query capacity for an index, or the base
        /// capacity of 2. 5 calls per second, whichever is higher. For example, the base capacity for an index
        /// is 0. 1 queries per second, and GetQuerySuggestions capacity has a base of 2. 5 calls per second. If
        /// you add another 0. 1 queries per second to total 0. 2 queries per second for an index, the
        /// GetQuerySuggestions capacity is 2. 5 calls per second (higher than five times 0. 2 queries per
        /// second).
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryCapacityUnits")]
        public Union<int, IntrinsicFunction> QueryCapacityUnits { get; set; }

    }
}
