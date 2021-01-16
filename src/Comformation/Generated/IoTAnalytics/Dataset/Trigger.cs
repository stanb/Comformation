using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset Trigger
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html
    /// </summary>
    public class Trigger
    {

        /// <summary>
        /// Schedule
        /// The &quot;Schedule&quot; when the trigger is initiated.
        /// Required: No
        /// Type: Schedule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// TriggeringDataset
        /// Information about the data set whose content generation triggers the new data set content
        /// generation.
        /// Required: No
        /// Type: TriggeringDataset
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggeringDataset")]
        public TriggeringDataset TriggeringDataset { get; set; }

    }
}
