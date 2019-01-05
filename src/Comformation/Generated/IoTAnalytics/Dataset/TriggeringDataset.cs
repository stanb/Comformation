using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset TriggeringDataset
    /// The TriggeringDataset property type specifies the data set whose content creation will trigger the creation of
    /// this data set&#39;s contents for an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-triggeringdataset.html
    /// </summary>
    public class TriggeringDataset
    {

        /// <summary>
        /// DatasetName
        /// The name of the data set.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetName")]
        public Union<string, IntrinsicFunction> DatasetName { get; set; }

    }
}
