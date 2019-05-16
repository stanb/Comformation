using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset OutputFileUriValue
    /// The value of the variable as a structure that specifies an output file URI.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable-outputfileurivalue.html
    /// </summary>
    public class OutputFileUriValue
    {

        /// <summary>
        /// FileName
        /// The URI of the location where data set contents are stored, usually the URI of a file in an S3
        /// bucket.
        /// Required: No
        /// Type: String
        /// Pattern: [\w\. -]{1,255}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileName")]
        public Union<string, IntrinsicFunction> FileName { get; set; }

    }
}
