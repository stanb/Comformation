using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector MetricSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-metricsource.html
    /// </summary>
    public class MetricSource
    {

        /// <summary>
        /// S3SourceConfig
        /// Contains information about the configuration of the S3 bucket that contains source files.
        /// Required: No
        /// Type: S3SourceConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3SourceConfig")]
        public S3SourceConfig S3SourceConfig { get; set; }

        /// <summary>
        /// RDSSourceConfig
        /// An object containing information about the Amazon Relational Database Service (RDS) configuration.
        /// Required: No
        /// Type: RDSSourceConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RDSSourceConfig")]
        public RDSSourceConfig RDSSourceConfig { get; set; }

        /// <summary>
        /// RedshiftSourceConfig
        /// An object containing information about the Amazon Redshift database configuration.
        /// Required: No
        /// Type: RedshiftSourceConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedshiftSourceConfig")]
        public RedshiftSourceConfig RedshiftSourceConfig { get; set; }

        /// <summary>
        /// CloudwatchConfig
        /// An object containing information about the Amazon CloudWatch monitoring configuration.
        /// Required: No
        /// Type: CloudwatchConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchConfig")]
        public CloudwatchConfig CloudwatchConfig { get; set; }

        /// <summary>
        /// AppFlowConfig
        /// An object containing information about the AppFlow configuration.
        /// Required: No
        /// Type: AppFlowConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppFlowConfig")]
        public AppFlowConfig AppFlowConfig { get; set; }

    }
}
