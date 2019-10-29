using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.AnomalyDetector
{
    /// <summary>
    /// AWS::CloudWatch::AnomalyDetector Configuration
    /// Specifies details about how the anomaly detection model is to be trained, including time ranges to exclude
    /// when training and updating the model. The configuration can also include the time zone to use for the metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        /// MetricTimeZone
        /// The time zone to use for the metric. This is useful to enable the model to automatically account for
        /// daylight savings time changes if the metric is sensitive to such time changes.
        /// To specify a time zone, use the name of the time zone as specified in the standard tz database. For
        /// more information, see tz database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricTimeZone")]
        public Union<string, IntrinsicFunction> MetricTimeZone { get; set; }

        /// <summary>
        /// ExcludedTimeRanges
        /// Specifies an array of time ranges to exclude from use when the anomaly detection model is trained
        /// and updated. Use this to make sure that events that could cause unusual values for the metric, such
        /// as deployments, aren&#39;t used when CloudWatch creates or updates the model.
        /// Required: No
        /// Type: List of Range
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludedTimeRanges")]
        public List<Range> ExcludedTimeRanges { get; set; }

    }
}
