using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream CloudWatchLoggingOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html
    /// </summary>
    public class CloudWatchLoggingOptions
    {

        /// <summary>
        /// Enabled
        /// Indicates whether CloudWatch Logs logging is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// LogGroupName
        /// The name of the CloudWatch Logs log group that contains the log stream that Kinesis Data Firehose
        /// will use.
        /// Conditional. If you enable logging, you must specify this property.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 0
        /// Maximum: 512
        /// Pattern: [\. \-_/#A-Za-z0-9]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// LogStreamName
        /// The name of the CloudWatch Logs log stream that Kinesis Data Firehose uses to send logs about data
        /// delivery.
        /// Conditional. If you enable logging, you must specify this property.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 0
        /// Maximum: 512
        /// Pattern: [^:*]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogStreamName")]
        public Union<string, IntrinsicFunction> LogStreamName { get; set; }

    }
}
