using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow ScheduledTriggerProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html
    /// </summary>
    public class ScheduledTriggerProperties
    {

        /// <summary>
        /// ScheduleExpression
        /// The scheduling expression that determines the rate at which the scheduled flow will run, for
        /// example: rate(5minutes).
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

        /// <summary>
        /// DataPullMode
        /// Specifies whether a scheduled flow has an incremental data transfer or a complete data transfer for
        /// each flow run.
        /// Required: No
        /// Type: String
        /// Allowed values: Complete | Incremental
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataPullMode")]
        public Union<string, IntrinsicFunction> DataPullMode { get; set; }

        /// <summary>
        /// ScheduleStartTime
        /// Specifies the scheduled start time for a schedule-triggered flow.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleStartTime")]
        public Union<double, IntrinsicFunction> ScheduleStartTime { get; set; }

        /// <summary>
        /// ScheduleEndTime
        /// Specifies the scheduled end time for a schedule-triggered flow.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleEndTime")]
        public Union<double, IntrinsicFunction> ScheduleEndTime { get; set; }

        /// <summary>
        /// TimeZone
        /// Specifies the time zone used when referring to the date and time of a scheduled-triggered flow.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeZone")]
        public Union<string, IntrinsicFunction> TimeZone { get; set; }

    }
}
