using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule CloudwatchMetricAction
    /// CloudwatchMetric is a property of the Actions property that describes an action that captures a CloudWatch
    /// metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html
    /// </summary>
    public class CloudwatchMetricAction
    {

        /// <summary>
        /// MetricName
        /// The name of the CloudWatch metric.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// MetricNamespace
        /// The name of the CloudWatch metric namespace.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricNamespace")]
        public Union<string, IntrinsicFunction> MetricNamespace { get; set; }

        /// <summary>
        /// MetricTimestamp
        /// An optional Unix timestamp.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MetricTimestamp")]
        public Union<string, IntrinsicFunction> MetricTimestamp { get; set; }

        /// <summary>
        /// MetricUnit
        /// The metric unit supported by Amazon CloudWatch.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricUnit")]
        public Union<string, IntrinsicFunction> MetricUnit { get; set; }

        /// <summary>
        /// MetricValue
        /// The value to publish to the metric. For example, if you count the occurrences of a particular term
        /// such as Error, the value will be 1 for each occurrence.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MetricValue")]
        public Union<string, IntrinsicFunction> MetricValue { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to the CloudWatch metric.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
