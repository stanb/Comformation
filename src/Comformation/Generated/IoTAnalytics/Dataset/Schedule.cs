using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ScheduleExpression
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

    }
}
