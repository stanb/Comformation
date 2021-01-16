using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset TriggeringDataset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-triggeringdataset.html
    /// </summary>
    public class TriggeringDataset
    {

        /// <summary>
        /// DatasetName
        /// The name of the data set whose content generation triggers the new data set content generation.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z0-9_]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetName")]
        public Union<string, IntrinsicFunction> DatasetName { get; set; }

    }
}
