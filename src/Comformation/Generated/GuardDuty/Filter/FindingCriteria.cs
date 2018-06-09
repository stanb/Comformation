using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// GuardDuty Filter FindingCriteria
    /// The FindingCriteria property type specifies the attributes to be used in the filter and the conditions to be
    /// applied to the selected attributes for filtering through your GuardDuty findings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html
    /// </summary>
    public class FindingCriteria
    {

        /// <summary>
        /// Criterion
        /// Specifies the finding attributes (for example, region, type, severity, etc. ) that you want to
        /// include in the finding criteria for a filter.
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
        /// Type: GuardDuty Filter Condition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ItemType")]
        public Union<Condition, IntrinsicFunction> ItemType { get; set; }

    }
}
