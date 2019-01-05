using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset Trigger
    /// The Trigger property type specifies a list of triggers that cause data set contents to be populated at a
    /// specific time or when another data set&#39;s contents are created for an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-trigger.html
    /// </summary>
    public class Trigger
    {

        /// <summary>
        /// Schedule
        /// The schedule of when the trigger is initiated (for triggering at a specific time).
        /// Required: No
        /// Type: Schedule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// TriggeringDataset
        /// The data set whose content creation will trigger the creation of this data set&#39;s contents.
        /// Required: No
        /// Type: TriggeringDataset
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggeringDataset")]
        public TriggeringDataset TriggeringDataset { get; set; }

    }
}
