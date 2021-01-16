using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.Task
{
    /// <summary>
    /// AWS::DataSync::Task TaskSchedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-taskschedule.html
    /// </summary>
    public class TaskSchedule
    {

        /// <summary>
        /// ScheduleExpression
        /// A cron expression that specifies when AWS DataSync initiates a scheduled transfer from a source to a
        /// destination location.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^[a-zA-Z0-9\ \_\*\?\,\|\^\-\/\#\s\(\)\+]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
