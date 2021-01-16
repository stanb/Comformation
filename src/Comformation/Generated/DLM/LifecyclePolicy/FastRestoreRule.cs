using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy FastRestoreRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-fastrestorerule.html
    /// </summary>
    public class FastRestoreRule
    {

        /// <summary>
        /// IntervalUnit
        /// 		
        /// The unit of time for enabling fast snapshot restore.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DAYS | MONTHS | WEEKS | YEARS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// AvailabilityZones
        /// 		
        /// The Availability Zones in which to enable fast snapshot restore.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZones")]
        public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

        /// <summary>
        /// Count
        /// 		
        /// The number of snapshots to be enabled with fast snapshot restore.
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
        /// The amount of time to enable fast snapshot restore. The maximum is 100 years. This is 			equivalent
        /// to 1200 months, 5200 weeks, or 36500 days.
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
