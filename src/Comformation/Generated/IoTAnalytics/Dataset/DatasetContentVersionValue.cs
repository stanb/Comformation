using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-datasetcontentversionvalue.html
    /// </summary>
    public class DatasetContentVersionValue
    {

        /// <summary>
        /// DatasetName
        /// </summary>
        [JsonProperty("DatasetName")]
        public Union<string, IntrinsicFunction> DatasetName { get; set; }

    }
}
