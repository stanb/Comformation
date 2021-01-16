using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DatasetContentVersionValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-datasetcontentversionvalue.html
    /// </summary>
    public class DatasetContentVersionValue
    {

        /// <summary>
        /// DatasetName
        /// The name of the dataset whose latest contents are used as input to the notebook or application.
        /// Required: No
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
