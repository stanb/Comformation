using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.AnomalyDetector
{
    /// <summary>
    /// AWS::LookoutMetrics::AnomalyDetector MetricSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lookoutmetrics-anomalydetector-metricset.html
    /// </summary>
    public class MetricSet
    {

        /// <summary>
        /// MetricSetName
        /// The name of the dataset.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricSetName")]
        public Union<string, IntrinsicFunction> MetricSetName { get; set; }

        /// <summary>
        /// MetricSetDescription
        /// A description of the dataset you are creating.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricSetDescription")]
        public Union<string, IntrinsicFunction> MetricSetDescription { get; set; }

        /// <summary>
        /// MetricSource
        /// Contains information about how the source data should be interpreted.
        /// Required: Yes
        /// Type: MetricSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricSource")]
        public MetricSource MetricSource { get; set; }

        /// <summary>
        /// MetricList
        /// A list of metrics that the dataset will contain.
        /// Required: Yes
        /// Type: List of Metric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricList")]
        public List<Metric> MetricList { get; set; }

        /// <summary>
        /// Offset
        /// After an interval ends, the amount of seconds that the detector waits before importing data. Offset
        /// is only supported for S3 and Redshift datasources.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Offset")]
        public Union<int, IntrinsicFunction> Offset { get; set; }

        /// <summary>
        /// TimestampColumn
        /// Contains information about the column used for tracking time in your source data.
        /// Required: No
        /// Type: TimestampColumn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampColumn")]
        public TimestampColumn TimestampColumn { get; set; }

        /// <summary>
        /// DimensionList
        /// A list of the fields you want to treat as dimensions.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionList")]
        public List<Union<string, IntrinsicFunction>> DimensionList { get; set; }

        /// <summary>
        /// MetricSetFrequency
        /// The frequency with which the source data will be analyzed for anomalies.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricSetFrequency")]
        public Union<string, IntrinsicFunction> MetricSetFrequency { get; set; }

        /// <summary>
        /// Timezone
        /// The time zone in which your source data was recorded.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timezone")]
        public Union<string, IntrinsicFunction> Timezone { get; set; }

    }
}
