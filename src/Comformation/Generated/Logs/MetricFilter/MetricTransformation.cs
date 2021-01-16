using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    /// AWS::Logs::MetricFilter MetricTransformation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html
    /// </summary>
    public class MetricTransformation
    {

        /// <summary>
        /// DefaultValue
        /// (Optional) The value to emit when a filter pattern does not match a log event. This value can be
        /// null.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultValue")]
        public Union<double, IntrinsicFunction> DefaultValue { get; set; }

        /// <summary>
        /// MetricName
        /// The name of the CloudWatch metric.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// MetricNamespace
        /// A custom namespace to contain your metric in CloudWatch. Use namespaces to group together metrics
        /// that are similar. For more information, see Namespaces.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Pattern: [^:*$]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricNamespace")]
        public Union<string, IntrinsicFunction> MetricNamespace { get; set; }

        /// <summary>
        /// MetricValue
        /// The value that is published to the CloudWatch metric. For example, if you&#39;re counting the
        /// occurrences of a particular term like Error, specify 1 for the metric value. If you&#39;re counting the
        /// number of bytes transferred, reference the value that is in the log event by using $ followed by the
        /// name of the field that you specified in the filter pattern, such as $size.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricValue")]
        public Union<string, IntrinsicFunction> MetricValue { get; set; }

    }
}
