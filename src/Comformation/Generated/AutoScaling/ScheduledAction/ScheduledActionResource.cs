using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScheduledAction
{
    /// <summary>
    /// AWS::AutoScaling::ScheduledAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html
    /// </summary>
    public class ScheduledActionResource : ResourceBase
    {
        public class ScheduledActionProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name or Amazon Resource Name (ARN) of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// DesiredCapacity
            /// The desired capacity is the initial capacity of the Auto Scaling group after the scheduled action
            /// runs and the capacity it attempts to maintain. It can scale beyond this capacity if you add more
            /// scaling conditions.
            /// You must specify at least one of the following properties: MaxSize, MinSize, or DesiredCapacity.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            /// EndTime
            /// The date and time in UTC for the recurring schedule to end. For example, &quot;2019-06-01T00:00:00Z&quot;.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndTime { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum size of the Auto Scaling group.
            /// You must specify at least one of the following properties: MaxSize, MinSize, or DesiredCapacity.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MinSize
            /// The minimum size of the Auto Scaling group.
            /// You must specify at least one of the following properties: MaxSize, MinSize, or DesiredCapacity.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// Recurrence
            /// The recurring schedule for this action, in Unix cron syntax format. For more information about cron
            /// syntax, see Crontab.
            /// Specifying the StartTime and EndTime properties with Recurrence property forms the start and stop
            /// boundaries of the recurring action.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Recurrence { get; set; }

            /// <summary>
            /// StartTime
            /// The date and time in UTC for this action to start. For example, &quot;2019-06-01T00:00:00Z&quot;.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StartTime { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::ScheduledAction";

        public ScheduledActionProperties Properties { get; } = new ScheduledActionProperties();

    }
}
