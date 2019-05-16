using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter FindingCriteria
    /// Represents a map of finding properties that match specified conditions and values when querying findings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html
    /// </summary>
    public class FindingCriteria
    {

        /// <summary>
        /// Criterion
        /// Represents a map of finding properties that match specified conditions and values when querying
        /// findings.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Criterion")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Criterion { get; set; }

        /// <summary>
        /// ItemType
        /// Specifies the condition to be applied to a single field when filtering through findings.
        /// Required: No
        /// Type: Condition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ItemType")]
        public Condition ItemType { get; set; }

    }
}
