using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream SplunkDestinationConfiguration
    /// The SplunkDestinationConfiguration property type specifies the configuration of a destination in Splunk for a
    /// Kinesis Data Firehose delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html
    /// </summary>
    public class SplunkDestinationConfiguration
    {

        /// <summary>
        /// CloudWatchLoggingOptions
        /// The CloudWatch logging options for your delivery stream.
        /// Required: No
        /// Type: CloudWatchLoggingOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// HECAcknowledgmentTimeoutInSeconds
        /// The amount of time that Kinesis Data Firehose waits to receive an acknowledgment from Splunk after
        /// it sends it data. At the end of the timeout period, Kinesis Data Firehose either tries to send the
        /// data again or considers it an error, based on your retry settings.
        /// Valid Range: Minimum value of 180. Maximum value of 600.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HECAcknowledgmentTimeoutInSeconds")]
        public Union<int, IntrinsicFunction> HECAcknowledgmentTimeoutInSeconds { get; set; }

        /// <summary>
        /// HECEndpoint
        /// The HTTP Event Collector (HEC) endpoint to which Kinesis Data Firehose sends your data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HECEndpoint")]
        public Union<string, IntrinsicFunction> HECEndpoint { get; set; }

        /// <summary>
        /// HECEndpointType
        /// This type can be either Raw or Event.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HECEndpointType")]
        public Union<string, IntrinsicFunction> HECEndpointType { get; set; }

        /// <summary>
        /// HECToken
        /// A GUID that you obtain from your Splunk cluster when you create a new HEC endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HECToken")]
        public Union<string, IntrinsicFunction> HECToken { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// The data processing configuration.
        /// Required: No
        /// Type: ProcessingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProcessingConfiguration")]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// RetryOptions
        /// The retry behavior in case Kinesis Data Firehose is unable to deliver data to Splunk, or if it
        /// doesn&#39;t receive an acknowledgment of receipt from Splunk.
        /// Required: No
        /// Type: SplunkRetryOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryOptions")]
        public SplunkRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// S3BackupMode
        /// Defines how documents should be delivered to Amazon S3. When set to FailedEventsOnly, Kinesis Data
        /// Firehose writes any data that could not be indexed to the configured Amazon S3 destination. When set
        /// to AllEvents, Kinesis Data Firehose delivers all incoming records to Amazon S3, and also writes
        /// failed documents to Amazon S3. Default value is FailedEventsOnly.
        /// Valid values include FailedEventsOnly and AllEvents.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BackupMode")]
        public Union<string, IntrinsicFunction> S3BackupMode { get; set; }

        /// <summary>
        /// S3Configuration
        /// The configuration for the backup Amazon S3 location.
        /// Required: Yes
        /// Type: S3DestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Configuration")]
        public S3DestinationConfiguration S3Configuration { get; set; }

    }
}
