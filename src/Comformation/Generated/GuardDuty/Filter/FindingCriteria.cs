using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html
    /// </summary>
    public class FindingCriteria
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html#cfn-guardduty-filter-findingcriteria-criterion
        /// </summary>
        [JsonProperty("Criterion")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Criterion { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html#cfn-guardduty-filter-findingcriteria-itemtype
        /// </summary>
        [JsonProperty("ItemType")]
        public Union<Condition, IntrinsicFunction> ItemType { get; set; }

    }
}
