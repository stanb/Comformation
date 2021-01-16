using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule ScheduleConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-scheduleconfig.html
    /// </summary>
    public class ScheduleConfig
    {

        /// <summary>
        /// ScheduleExpression
        /// A cron expression that describes details about the monitoring schedule.
        /// Currently the only supported cron expressions are:
        /// If you want to set the job to start every hour, please use the following: Hourly: cron(0 * ? * * *)
        /// If you want to start the job daily: cron(0 [00-23] ? * * *)
        /// For example, the following are valid cron expressions:
        /// Daily at noon UTC: cron(0 12 ? * * *) Daily at midnight UTC: cron(0 0 ? * * *)
        /// To support running every 6, 12 hours, the following are also supported:
        /// cron(0 [00-23]/[01-24] ? * * *)
        /// For example, the following are valid cron expressions:
        /// Every 12 hours, starting at 5pm UTC: cron(0 17/12 ? * * *) Every two hours starting at midnight:
        /// cron(0 0/2 ? * * *)
        /// Note Even though the cron expression is set to start at 5PM UTC, note that there could be a delay of
        /// 0-20 minutes from the actual requested time to run the execution. We recommend that if you would
        /// like a daily schedule, you do not provide this parameter. Amazon SageMaker will pick a time for
        /// running every day.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
