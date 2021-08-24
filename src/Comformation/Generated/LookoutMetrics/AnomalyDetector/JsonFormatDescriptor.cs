using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector JsonFormatDescriptor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-jsonformatdescriptor.html
    /// </summary>
    public class JsonFormatDescriptor
    {

        /// <summary>
        /// FileCompression
        /// The level of compression of the source CSV file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileCompression")]
        public Union<string, IntrinsicFunction> FileCompression { get; set; }

        /// <summary>
        /// Charset
        /// The character set in which the source JSON file is written.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Charset")]
        public Union<string, IntrinsicFunction> Charset { get; set; }

    }
}
