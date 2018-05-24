using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lt
        /// </summary>
        [JsonProperty("Lt")]
        public Union<int?, IntrinsicFunction> Lt { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-gte
        /// </summary>
        [JsonProperty("Gte")]
        public Union<int?, IntrinsicFunction> Gte { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-neq
        /// </summary>
        [JsonProperty("Neq")]
        public Union<List<string>, IntrinsicFunction> Neq { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-eq
        /// </summary>
        [JsonProperty("Eq")]
        public Union<List<string>, IntrinsicFunction> Eq { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lte
        /// </summary>
        [JsonProperty("Lte")]
        public Union<int?, IntrinsicFunction> Lte { get; set; }

    }
}
