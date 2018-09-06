using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream CloudWatchLoggingOptions
    /// The CloudWatchLoggingOptions property type specifies Amazon CloudWatch Logs (CloudWatch Logs) logging options
    /// that Amazon Kinesis Data Firehose (Kinesis Data Firehose) uses for the delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html
    /// </summary>
    public class CloudWatchLoggingOptions
    {

        /// <summary>
        /// Enabled
        /// Indicates whether CloudWatch Logs logging is enabled.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// LogGroupName
        /// The name of the CloudWatch Logs log group that contains the log stream that Kinesis Data Firehose
        /// will use.
        /// Required: Conditional. If you enable logging, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// LogStreamName
        /// The name of the CloudWatch Logs log stream that Kinesis Data Firehose uses to send logs about data
        /// delivery.
        /// Required: Conditional. If you enable logging, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("LogStreamName")]
        public Union<string, IntrinsicFunction> LogStreamName { get; set; }

    }
}
