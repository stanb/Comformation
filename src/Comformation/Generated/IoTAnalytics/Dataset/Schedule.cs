using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset Schedule
    /// The Schedule property type specifies the &quot;schedule&quot; when a trigger is initiated for an AWS IoT Analytics
    /// dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ScheduleExpression
        /// The expression that defines when to trigger an update.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
