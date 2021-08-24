using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalableTarget ScheduledAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html
    /// </summary>
    public class ScheduledAction
    {

        /// <summary>
        /// EndTime
        /// The date and time that the action is scheduled to end, in UTC.
        /// Required: No
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndTime")]
        public Union<string, IntrinsicFunction> EndTime { get; set; }

        /// <summary>
        /// ScalableTargetAction
        /// The new minimum and maximum capacity. You can set both values or just one. At the scheduled time, if
        /// the current capacity is below the minimum capacity, Application Auto Scaling scales out to the
        /// minimum capacity. If the current capacity is above the maximum capacity, Application Auto Scaling
        /// scales in to the maximum capacity.
        /// Required: No
        /// Type: ScalableTargetAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalableTargetAction")]
        public ScalableTargetAction ScalableTargetAction { get; set; }

        /// <summary>
        /// Schedule
        /// The schedule for this action. The following formats are supported:
        /// At expressions - &quot;at(yyyy-mm-ddThh:mm:ss)&quot; Rate expressions - &quot;rate(value unit)&quot; Cron expressions -
        /// &quot;cron(fields)&quot;
        /// At expressions are useful for one-time schedules. Cron expressions are useful for scheduled actions
        /// that run periodically at a specified date and time, and rate expressions are useful for scheduled
        /// actions that run at a regular interval.
        /// At and cron expressions use Universal Coordinated Time (UTC) by default.
        /// The cron format consists of six fields separated by white spaces: [Minutes] [Hours] [Day_of_Month]
        /// [Month] [Day_of_Week] [Year].
        /// For rate expressions, value is a positive integer and unit is minute | minutes | hour | hours | day
        /// | days.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedule")]
        public Union<string, IntrinsicFunction> Schedule { get; set; }

        /// <summary>
        /// ScheduledActionName
        /// The name of the scheduled action. This name must be unique among all other scheduled actions on the
        /// specified scalable target.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: (?!((^[ ]+. *)|(. *([\u0000-\u001f]|[\u007f-\u009f]|[:/|])+. *)|(. *[ ]+$))). +
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduledActionName")]
        public Union<string, IntrinsicFunction> ScheduledActionName { get; set; }

        /// <summary>
        /// StartTime
        /// The date and time that the action is scheduled to begin, in UTC.
        /// Required: No
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartTime")]
        public Union<string, IntrinsicFunction> StartTime { get; set; }

        /// <summary>
        /// Timezone
        /// The time zone used when referring to the date and time of a scheduled action, when the scheduled
        /// action uses an at or cron expression.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timezone")]
        public Union<string, IntrinsicFunction> Timezone { get; set; }

    }
}
