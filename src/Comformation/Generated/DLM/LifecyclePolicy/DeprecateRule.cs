using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy DeprecateRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-deprecaterule.html
    /// </summary>
    public class DeprecateRule
    {

        /// <summary>
        /// IntervalUnit
        /// 		
        /// The unit of time in which to measure the Interval.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DAYS | MONTHS | WEEKS | YEARS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// Count
        /// 		
        /// If the schedule has a count-based retention rule, this parameter specifies the number of oldest
        /// 			AMIs to deprecate. The count must be less than or equal to the schedule&#39;s retention count, and it
        /// 			can&#39;t be greater than 1000.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// Interval
        /// 		
        /// If the schedule has an age-based retention rule, this parameter specifies the period after which
        /// 			to deprecate AMIs created by the schedule. The period must be less than or equal to the
        /// schedule&#39;s 			retention period, and it can&#39;t be greater than 10 years. This is equivalent to 120
        /// months, 520 			weeks, or 3650 days.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

    }
}
