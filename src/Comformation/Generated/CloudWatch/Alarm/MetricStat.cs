using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// Amazon CloudWatch Alarm MetricStat
    /// The MetricStat property type defines the metric to be returned, along with the statistics, period, and units.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html
    /// </summary>
    public class MetricStat
    {

        /// <summary>
        /// Metric
        /// The metric to return, including the metric name, namespace, and dimensions.
        /// Required: Yes
        /// Type: Metric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metric")]
        public Metric Metric { get; set; }

        /// <summary>
        /// Period
        /// The period, in seconds, to use when retrieving the metric. Minimum value of 1.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// Stat
        /// The statistic to return. It can include any CloudWatch statistic or extended statistic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Stat")]
        public Union<string, IntrinsicFunction> Stat { get; set; }

        /// <summary>
        /// Unit
        /// The unit to use for the returned data points.
        /// Required: No
        /// Type: String
        /// Valid values: Seconds | Microseconds | Milliseconds | Bytes | Kilobytes | Megabytes | Gigabytes |
        /// Terabytes | Bits | Kilobits | Megabits | Gigabits | Terabits | Percent | Count | Bytes/Second |
        /// Kilobytes/Second | Megabytes/Second | Gigabytes/Second | Terabytes/Second | Bits/Second |
        /// Kilobits/Second | Megabits/Second | Gigabits/Second | Terabits/Second | Count/Second | None
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}