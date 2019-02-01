using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset OutputFileUriValue
    /// The OutputFileUriValue property type specifies a variable value which contains an output file URI for an AWS
    /// IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-outputfileurivalue.html
    /// </summary>
    public class OutputFileUriValue
    {

        /// <summary>
        /// FileName
        /// The URI of the location where data set contents are stored, usually the URI of a file in an S3
        /// bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileName")]
        public Union<string, IntrinsicFunction> FileName { get; set; }

    }
}
