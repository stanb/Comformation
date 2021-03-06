using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ScheduleExpression
        /// A cron expression used to specify the schedule. For more information, see Time-Based Schedules for
        /// Jobs and Crawlers. For example, to run something every day at 12:15 UTC, specify cron(15 12 * * ?
        /// *).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
