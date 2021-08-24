using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CreateRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html
    /// </summary>
    public class CreateRule
    {

        /// <summary>
        /// IntervalUnit
        /// 		
        /// The interval unit.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: HOURS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// Times
        /// 		
        /// The time, in UTC, to start the operation. The supported format is hh:mm.
        /// 		
        /// The operation occurs within a one-hour window following the specified time. If you do 			not specify
        /// a time, Amazon DLM selects a time within the next 24 hours.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Times")]
        public List<Union<string, IntrinsicFunction>> Times { get; set; }

        /// <summary>
        /// CronExpression
        /// 		
        /// The schedule, as a Cron expression. The schedule interval must be between 1 hour and 1 			year. For
        /// more information, see Cron 				expressions in the Amazon CloudWatch User Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 17
        /// Maximum: 106
        /// Pattern: cron\([^\n]{11,100}\)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CronExpression")]
        public Union<string, IntrinsicFunction> CronExpression { get; set; }

        /// <summary>
        /// Interval
        /// 		
        /// The interval between snapshots. The supported values are 1, 2, 3, 4, 6, 8, 12, and 			24.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// Location
        /// 		
        /// Specifies the destination for snapshots created by the policy. To create snapshots in the same
        /// 			Region as the source resource, specify CLOUD. To create snapshots on the same 			Outpost as the
        /// source resource, specify OUTPOST_LOCAL. If you omit this 			parameter, CLOUD is used by default.
        /// 		
        /// If the policy targets resources in an AWS Region, then you must create snapshots in the same
        /// 			Region as the source resource.
        /// 		
        /// If the policy targets resources on an Outpost, then you can create snapshots on the same Outpost
        /// 			as the source resource, or in the Region of that Outpost.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: CLOUD | OUTPOST_LOCAL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
