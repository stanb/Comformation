using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Schedule
{
    /// <summary>
    /// AWS::DataBrew::Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-schedule.html
    /// </summary>
    public class ScheduleResource : ResourceBase
    {
        public class ScheduleProperties
        {
            /// <summary>
            /// JobNames
            /// A list of jobs to be run, according to the schedule.
            /// Required: No
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> JobNames { get; set; }

            /// <summary>
            /// CronExpression
            /// The date(s) and time(s) when the job will run. For more information, see Cron expressions in the AWS
            /// Glue DataBrew Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CronExpression { get; set; }

            /// <summary>
            /// Name
            /// The name of the schedule.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// Metadata tags that have been applied to the schedule.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataBrew::Schedule";

        public ScheduleProperties Properties { get; } = new ScheduleProperties();

    }
}
