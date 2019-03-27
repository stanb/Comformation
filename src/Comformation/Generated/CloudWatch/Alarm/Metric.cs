using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// Amazon CloudWatch Alarm Metric
    /// The Metric property type represents a specific metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html
    /// </summary>
    public class Metric
    {

        /// <summary>
        /// Dimensions
        /// The dimensions for the metric. You can specify a maximum of 10 items.
        /// Required: No
        /// Type: List of Dimension property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// MetricName
        /// The name of the metric.
        /// Required: No
        /// Type: String
        /// Length constraints: Minimum of 1. Maximum of 255.
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// Namespace
        /// The namespace of the metric.
        /// Required: No
        /// Type: String
        /// Length constraints: Minimum of 1. Maximum of 255.
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

    }
}
