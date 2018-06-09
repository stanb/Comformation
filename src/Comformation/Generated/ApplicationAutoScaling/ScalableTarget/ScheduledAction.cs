using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// Application Auto Scaling ScalableTarget ScheduledAction
    /// The ScheduledAction property type specifies a scheduled action for an Application Auto Scaling scalable
    /// target.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html
    /// </summary>
    public class ScheduledAction
    {

        /// <summary>
        /// EndTime
        /// The date and time that the action is scheduled to end.
        /// Required: No
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndTime")]
        public Union<string, IntrinsicFunction> EndTime { get; set; }

        /// <summary>
        /// ScalableTargetAction
        /// The new minimum and maximum capacity. You can set both values or just one. During the scheduled
        /// time, 				 if the current capacity is below the minimum capacity, Application Auto Scaling scales
        /// out to the minimum capacity. 				 If the current capacity is above the maximum capacity, Application
        /// Auto Scaling scales in to the maximum capacity.
        /// Required: No
        /// Type: Application Auto Scaling ScalableTarget ScalableTargetAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalableTargetAction")]
        public Union<ScalableTargetAction, IntrinsicFunction> ScalableTargetAction { get; set; }

        /// <summary>
        /// Schedule
        /// The schedule for this action. The following formats are supported:
        /// At expressions - at(yyyy-mm-ddThh:mm:ss) At expressions are useful for one-time schedules. Specify
        /// the time in UTC. Rate expressions - rate(value unit) For rate expressions, value is a positive
        /// integer, and unit is minute, minutes, hour, hours, day, or days. Cron expressions - cron(fields) For
        /// more information about cron expressions, see Cron.
        /// 					
        /// For constraints, see the 					 ScheduledAction data type in the Application Auto Scaling API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedule")]
        public Union<string, IntrinsicFunction> Schedule { get; set; }

        /// <summary>
        /// ScheduledActionName
        /// The name of the scheduled action. 				 For constraints, see the 					 ScheduledAction data type in
        /// the Application Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduledActionName")]
        public Union<string, IntrinsicFunction> ScheduledActionName { get; set; }

        /// <summary>
        /// StartTime
        /// The date and time that the action is scheduled to begin.
        /// Required: No
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartTime")]
        public Union<string, IntrinsicFunction> StartTime { get; set; }

    }
}
