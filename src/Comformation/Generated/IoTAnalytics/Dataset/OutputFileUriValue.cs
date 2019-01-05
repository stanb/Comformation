using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-outputfileurivalue.html
    /// </summary>
    public class OutputFileUriValue
    {

        /// <summary>
        /// FileName
        /// </summary>
        [JsonProperty("FileName")]
        public Union<string, IntrinsicFunction> FileName { get; set; }

    }
}
