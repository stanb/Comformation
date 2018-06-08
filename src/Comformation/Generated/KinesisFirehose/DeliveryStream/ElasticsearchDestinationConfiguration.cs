using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream ElasticsearchDestinationConfiguration
    /// The ElasticsearchDestinationConfiguration property type specifies an Amazon Elasticsearch Service (Amazon ES)
    /// domain that Amazon Kinesis Firehose (Kinesis Firehose) delivers data to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html
    /// </summary>
    public class ElasticsearchDestinationConfiguration
    {

        /// <summary>
        /// BufferingHints
        /// Configures how Kinesis Firehose buffers incoming data while delivering it to the Amazon ES domain.
        /// Required: Yes
        /// Type: Kinesis Firehose DeliveryStream ElasticsearchBufferingHints
        /// </summary>
        [JsonProperty("BufferingHints")]
        public Union<ElasticsearchBufferingHints, IntrinsicFunction> BufferingHints { get; set; }

        /// <summary>
        /// CloudWatchLoggingOptions
        /// The Amazon CloudWatch Logs logging options for the delivery stream.
        /// Required: No
        /// Type: Kinesis Firehose DeliveryStream CloudWatchLoggingOptions
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public Union<CloudWatchLoggingOptions, IntrinsicFunction> CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// DomainARN
        /// The Amazon Resource Name (ARN) of the Amazon ES domain that Kinesis Firehose delivers data to.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DomainARN")]
        public Union<string, IntrinsicFunction> DomainARN { get; set; }

        /// <summary>
        /// IndexName
        /// The name of the Elasticsearch index to which Kinesis Firehose adds data for indexing.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// IndexRotationPeriod
        /// The frequency of Elasticsearch index rotation. If you enable index rotation, Kinesis Firehose
        /// appends a portion of the UTC arrival timestamp to the specified index name, and rotates the appended
        /// timestamp accordingly. For more information, see Index Rotation for the Amazon ES Destination in the
        /// Amazon Kinesis Firehose Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IndexRotationPeriod")]
        public Union<string, IntrinsicFunction> IndexRotationPeriod { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// The data processing configuration for the Kinesis Firehose delivery stream.
        /// Required: No
        /// Type: Kinesis Firehose DeliveryStream ProcessingConfiguration
        /// </summary>
        [JsonProperty("ProcessingConfiguration")]
        public Union<ProcessingConfiguration, IntrinsicFunction> ProcessingConfiguration { get; set; }

        /// <summary>
        /// RetryOptions
        /// The retry behavior when Kinesis Firehose is unable to deliver data to Amazon ES.
        /// Required: Yes
        /// Type: Kinesis Firehose DeliveryStream ElasticsearchRetryOptions
        /// </summary>
        [JsonProperty("RetryOptions")]
        public Union<ElasticsearchRetryOptions, IntrinsicFunction> RetryOptions { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the AWS Identity and Access Management (IAM) role that grants Kinesis Firehose access to
        /// your Amazon S3 bucket, AWS KMS (if you enable data encryption), and Amazon CloudWatch Logs (if you
        /// enable logging).
        /// For more information, see Grant Kinesis Firehose Access to an Amazon Elasticsearch Service
        /// Destination in the Amazon Kinesis Firehose Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// S3BackupMode
        /// The condition under which Kinesis Firehose delivers data to Amazon Simple Storage Service (Amazon
        /// S3). You can send Amazon S3 all documents (all data) or only the documents that Kinesis Firehose
        /// could not deliver to the Amazon ES destination. For more information and valid values, see the
        /// S3BackupMode content for the ElasticsearchDestinationConfiguration data type in the Amazon Kinesis
        /// Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("S3BackupMode")]
        public Union<string, IntrinsicFunction> S3BackupMode { get; set; }

        /// <summary>
        /// S3Configuration
        /// The S3 bucket where Kinesis Firehose backs up incoming data.
        /// Required: Yes
        /// Type: Kinesis Firehose DeliveryStream S3DestinationConfiguration
        /// </summary>
        [JsonProperty("S3Configuration")]
        public Union<S3DestinationConfiguration, IntrinsicFunction> S3Configuration { get; set; }

        /// <summary>
        /// TypeName
        /// The Elasticsearch type name that Amazon ES adds to documents when indexing data.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TypeName")]
        public Union<string, IntrinsicFunction> TypeName { get; set; }

    }
}
