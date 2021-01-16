using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream HttpEndpointDestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html
    /// </summary>
    public class HttpEndpointDestinationConfiguration
    {

        /// <summary>
        /// RoleARN
        /// Kinesis Data Firehose uses this IAM role for all the permissions that the delivery stream needs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// EndpointConfiguration
        /// The configuration of the HTTP endpoint selected as the destination.
        /// Required: Yes
        /// Type: HttpEndpointConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointConfiguration")]
        public HttpEndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// RequestConfiguration
        /// The configuration of the request sent to the HTTP endpoint specified as the destination.
        /// Required: No
        /// Type: HttpEndpointRequestConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequestConfiguration")]
        public HttpEndpointRequestConfiguration RequestConfiguration { get; set; }

        /// <summary>
        /// BufferingHints
        /// The buffering options that can be used before data is delivered to the specified destination.
        /// Kinesis Data Firehose treats these options as hints, and it might choose to use more optimal values.
        /// The SizeInMBs and IntervalInSeconds parameters are optional. However, if you specify a value for one
        /// of them, you must also provide a value for the other.
        /// Required: No
        /// Type: BufferingHints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferingHints")]
        public BufferingHints BufferingHints { get; set; }

        /// <summary>
        /// CloudWatchLoggingOptions
        /// Describes the Amazon CloudWatch logging options for your delivery stream.
        /// Required: No
        /// Type: CloudWatchLoggingOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// Describes the data processing configuration.
        /// Required: No
        /// Type: ProcessingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProcessingConfiguration")]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// RetryOptions
        /// Describes the retry behavior in case Kinesis Data Firehose is unable to deliver data to the
        /// specified HTTP endpoint destination, or if it doesn&#39;t receive a valid acknowledgment of receipt from
        /// the specified HTTP endpoint destination.
        /// Required: No
        /// Type: RetryOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryOptions")]
        public RetryOptions RetryOptions { get; set; }

        /// <summary>
        /// S3BackupMode
        /// Describes the S3 bucket backup options for the data that Kinesis Data Firehose delivers to the HTTP
        /// endpoint destination. You can back up all documents (AllData) or only the documents that Kinesis
        /// Data Firehose could not deliver to the specified HTTP endpoint destination (FailedDataOnly).
        /// Required: No
        /// Type: String
        /// Allowed values: AllData | FailedDataOnly
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BackupMode")]
        public Union<string, IntrinsicFunction> S3BackupMode { get; set; }

        /// <summary>
        /// S3Configuration
        /// Describes the configuration of a destination in Amazon S3.
        /// Required: Yes
        /// Type: S3DestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Configuration")]
        public S3DestinationConfiguration S3Configuration { get; set; }

    }
}
