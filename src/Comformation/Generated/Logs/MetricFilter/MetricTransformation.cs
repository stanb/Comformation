using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    /// CloudWatch Logs MetricFilter MetricTransformation Property
    /// MetricTransformation is a property of the AWS::Logs::MetricFilter resource that describes how to transform log
    /// streams into a CloudWatch metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html
    /// </summary>
    public class MetricTransformation
    {

        /// <summary>
        /// DefaultValue
        /// The value to emit when a filter pattern does not match a log event. This value can be null.
        /// Required: No
        /// Type: Double
        /// </summary>
        [JsonProperty("DefaultValue")]
        public Union<double, IntrinsicFunction> DefaultValue { get; set; }

        /// <summary>
        /// MetricName
        /// The name of the CloudWatch metric to which the log information will be published.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// MetricNamespace
        /// The destination namespace of the CloudWatch metric. Namespaces are containers for metrics. For
        /// example, you can add related metrics in the same namespace.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricNamespace")]
        public Union<string, IntrinsicFunction> MetricNamespace { get; set; }

        /// <summary>
        /// MetricValue
        /// The value that is published to the CloudWatch metric. For example, if you're counting the
        /// occurrences of a particular term like Error, specify 1 for the metric value. If you're counting the
        /// number of bytes transferred, reference the value that is in the log event by using $ followed by the
        /// name of the field that you specified in the filter pattern, such as $size.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricValue")]
        public Union<string, IntrinsicFunction> MetricValue { get; set; }

    }
}
