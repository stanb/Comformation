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
        /// The date and time for the recurring schedule to end.
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
        /// At expressions are useful for one-time schedules. Specify the time in UTC.
        /// For rate expressions, value is a positive integer and unit is minute | minutes | hour | hours | day
        /// | days.
        /// For more information about cron expressions, see Cron expressions in the Amazon CloudWatch Events
        /// User Guide.
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
        /// The date and time that the action is scheduled to start.
        /// Required: No
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartTime")]
        public Union<string, IntrinsicFunction> StartTime { get; set; }

    }
}
