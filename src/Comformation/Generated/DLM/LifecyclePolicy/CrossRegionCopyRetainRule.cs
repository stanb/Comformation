using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CrossRegionCopyRetainRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyretainrule.html
    /// </summary>
    public class CrossRegionCopyRetainRule
    {

        /// <summary>
        /// IntervalUnit
        /// 		
        /// The unit of time for time-based retention.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: DAYS | MONTHS | WEEKS | YEARS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// Interval
        /// 		
        /// The amount of time to retain each snapshot. The maximum is 100 years. This is 			equivalent to 1200
        /// months, 5200 weeks, or 36500 days.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

    }
}
