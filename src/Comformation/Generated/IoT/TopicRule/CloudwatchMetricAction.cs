using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule CloudwatchMetricAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html
    /// </summary>
    public class CloudwatchMetricAction
    {

        /// <summary>
        /// MetricName
        /// The CloudWatch metric name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// MetricNamespace
        /// The CloudWatch metric namespace name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricNamespace")]
        public Union<string, IntrinsicFunction> MetricNamespace { get; set; }

        /// <summary>
        /// MetricTimestamp
        /// An optional Unix timestamp.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricTimestamp")]
        public Union<string, IntrinsicFunction> MetricTimestamp { get; set; }

        /// <summary>
        /// MetricUnit
        /// The metric unit supported by CloudWatch.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricUnit")]
        public Union<string, IntrinsicFunction> MetricUnit { get; set; }

        /// <summary>
        /// MetricValue
        /// The CloudWatch metric value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricValue")]
        public Union<string, IntrinsicFunction> MetricValue { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that allows access to the CloudWatch metric.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
