using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector S3SourceConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-s3sourceconfig.html
    /// </summary>
    public class S3SourceConfig
    {

        /// <summary>
        /// RoleArn
        /// The ARN of an IAM role that has read and write access permissions to the source S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// TemplatedPathList
        /// A list of templated paths to the source files.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemplatedPathList")]
        public List<Union<string, IntrinsicFunction>> TemplatedPathList { get; set; }

        /// <summary>
        /// HistoricalDataPathList
        /// A list of paths to the historical data files.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HistoricalDataPathList")]
        public List<Union<string, IntrinsicFunction>> HistoricalDataPathList { get; set; }

        /// <summary>
        /// FileFormatDescriptor
        /// Contains information about a source file&#39;s formatting.
        /// Required: Yes
        /// Type: FileFormatDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileFormatDescriptor")]
        public FileFormatDescriptor FileFormatDescriptor { get; set; }

    }
}
