using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScheduledAction
{
    /// <summary>
    /// AWS::AutoScaling::ScheduledAction
    /// Creates a scheduled scaling action for an Amazon EC2 Auto Scaling group, changing the number of servers
    /// available for your application in response to predictable load changes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-as-scheduledaction.html
    /// </summary>
    public class ScheduledActionResource : ResourceBase
    {
        public class ScheduledActionProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name or ARN of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// DesiredCapacity
            /// The number of Amazon EC2 instances that should be running in the Auto Scaling group. At least one of
            /// MaxSize, MinSize, or DesiredCapacity must be specified.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            /// EndTime
            /// The time in UTC for this schedule to end. For example, 2010-06-01T00:00:00Z.
            /// Required: No
            /// Type: Time stamp
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndTime { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum number of Amazon EC2 instances in the Auto Scaling group. At least one of MaxSize,
            /// MinSize, or DesiredCapacity must be specified.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MinSize
            /// The minimum number of Amazon EC2 instances in the Auto Scaling group. At least one of MaxSize,
            /// MinSize, or DesiredCapacity must be specified.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// Recurrence
            /// The time in UTC when recurring future actions will start. You specify the start time by following
            /// the Unix cron syntax format. For more information about cron syntax, go to http://en. wikipedia.
            /// org/wiki/Cron.
            /// Specifying the StartTime and EndTime properties with Recurrence property forms the start and stop
            /// boundaries of the recurring action.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Recurrence { get; set; }

            /// <summary>
            /// StartTime
            /// The time in UTC for this schedule to start. For example, 2010-06-01T00:00:00Z.
            /// Required: No
            /// Type: Time stamp
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StartTime { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::ScheduledAction";

        public ScheduledActionProperties Properties { get; } = new ScheduledActionProperties();

    }
}
