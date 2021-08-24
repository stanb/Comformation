using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CrossRegionCopyDeprecateRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopydeprecaterule.html
    /// </summary>
    public class CrossRegionCopyDeprecateRule
    {

        /// <summary>
        /// IntervalUnit
        /// 		
        /// The unit of time in which to measure the Interval.
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
        /// The period after which to deprecate the cross-Region AMI copies. The period must be less than or
        /// 			equal to the cross-Region AMI copy retention period, and it can&#39;t be greater than 10 years. This
        /// is 			equivalent to 120 months, 520 weeks, or 3650 days.
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
