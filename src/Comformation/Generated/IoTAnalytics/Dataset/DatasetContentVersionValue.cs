using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset DatasetContentVersionValue
    /// The DatasetContentVersionValue property type specifies the value of a variable as a structure that specifies a
    /// data set content version for an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentversionvalue.html
    /// </summary>
    public class DatasetContentVersionValue
    {

        /// <summary>
        /// DatasetName
        /// The data set whose latest contents will be used as input to the notebook or application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetName")]
        public Union<string, IntrinsicFunction> DatasetName { get; set; }

    }
}
