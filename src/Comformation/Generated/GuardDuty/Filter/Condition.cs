using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter Condition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// Lt
        /// Represents the less than condition to apply to a single field when querying for findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lt")]
        public Union<int, IntrinsicFunction> Lt { get; set; }

        /// <summary>
        /// Gte
        /// Represents the greater than or equal condition to apply to a single field when querying for
        /// findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gte")]
        public Union<int, IntrinsicFunction> Gte { get; set; }

        /// <summary>
        /// Neq
        /// Represents the not equal condition to apply to a single field when querying for findings.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Neq")]
        public List<Union<string, IntrinsicFunction>> Neq { get; set; }

        /// <summary>
        /// Eq
        /// Represents the equal condition to apply to a single field when querying for findings.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Eq")]
        public List<Union<string, IntrinsicFunction>> Eq { get; set; }

        /// <summary>
        /// Lte
        /// Represents the less than or equal condition to apply to a single field when querying for findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lte")]
        public Union<int, IntrinsicFunction> Lte { get; set; }

    }
}
