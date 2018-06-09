using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS Glue Crawler Schedule
    /// The Schedule property type schedules an event for an AWS Glue crawler using a cron statement.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ScheduleExpression
        /// A cron expression that you can use as an Amazon CloudWatch Events event to schedule something. For
        /// example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
