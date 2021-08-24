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
            /// The name of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
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
            /// The date and time for the recurring schedule to end, in UTC. For example, &quot;2021-06-01T00:00:00Z&quot;.
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
            /// The recurring schedule for this action. This format consists of five fields separated by white
            /// spaces: [Minute] [Hour] [Day_of_Month] [Month_of_Year] [Day_of_Week]. For more information about
            /// this format, see Crontab.
            /// When StartTime and EndTime are specified with Recurrence, they form the boundaries of when the
            /// recurring action starts and stops.
            /// Cron expressions use Universal Coordinated Time (UTC) by default.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Recurrence { get; set; }

            /// <summary>
            /// StartTime
            /// The date and time for this action to start, in YYYY-MM-DDThh:mm:ssZ format in UTC/GMT only. For
            /// example, &quot;2021-06-01T00:00:00Z&quot;.
            /// If you specify Recurrence and StartTime, Amazon EC2 Auto Scaling performs the action at this time,
            /// and then performs the action based on the specified recurrence.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StartTime { get; set; }

            /// <summary>
            /// TimeZone
            /// Specifies the time zone for a cron expression. If a time zone is not provided, UTC is used by
            /// default.
            /// Valid values are the canonical names of the IANA time zones, derived from the IANA Time Zone
            /// Database (such as Etc/GMT+9 or Pacific/Tahiti). For more information, see https://en. wikipedia.
            /// org/wiki/List_of_tz_database_time_zones.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TimeZone { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::ScheduledAction";

        public ScheduledActionProperties Properties { get; } = new ScheduledActionProperties();

    }
}
