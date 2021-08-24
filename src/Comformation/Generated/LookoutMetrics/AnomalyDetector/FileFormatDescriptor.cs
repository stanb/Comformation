using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector FileFormatDescriptor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-fileformatdescriptor.html
    /// </summary>
    public class FileFormatDescriptor
    {

        /// <summary>
        /// CsvFormatDescriptor
        /// Contains information about how a source CSV data file should be analyzed.
        /// Required: No
        /// Type: CsvFormatDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CsvFormatDescriptor")]
        public CsvFormatDescriptor CsvFormatDescriptor { get; set; }

        /// <summary>
        /// JsonFormatDescriptor
        /// Contains information about how a source JSON data file should be analyzed.
        /// Required: No
        /// Type: JsonFormatDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonFormatDescriptor")]
        public JsonFormatDescriptor JsonFormatDescriptor { get; set; }

    }
}
