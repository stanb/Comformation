using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// GuardDuty Filter Condition
    /// The Condition property type specifies the condition to be applied to a single field when filtering through
    /// GuardDuty findings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// Lt
        /// Represents the &quot;less than&quot; condition to be applied to a single field when filtering through
        /// findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lt")]
        public Union<int, IntrinsicFunction> Lt { get; set; }

        /// <summary>
        /// Gte
        /// Represents the &quot;greater than equal&quot; condition to be applied to a single field when filtering through
        /// findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gte")]
        public Union<int, IntrinsicFunction> Gte { get; set; }

        /// <summary>
        /// Neq
        /// Represents the &quot;not equal to&quot; condition to be applied to a single field when filtering through
        /// findings.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Neq")]
        public Union<List<string>, IntrinsicFunction> Neq { get; set; }

        /// <summary>
        /// Eq
        /// Represents the &quot;equal to&quot; condition to be applied to a single field when filtering through findings.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Eq")]
        public Union<List<string>, IntrinsicFunction> Eq { get; set; }

        /// <summary>
        /// Lte
        /// Represents the &quot;less than equal&quot; condition to be applied to a single field when filtering through
        /// findings.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lte")]
        public Union<int, IntrinsicFunction> Lte { get; set; }

    }
}
