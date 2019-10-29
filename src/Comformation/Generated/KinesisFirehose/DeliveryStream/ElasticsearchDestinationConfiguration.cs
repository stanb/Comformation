using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream ElasticsearchDestinationConfiguration
    /// The ElasticsearchDestinationConfiguration property type specifies an Amazon Elasticsearch Service (Amazon ES)
    /// domain that Amazon Kinesis Data Firehose (Kinesis Data Firehose) delivers data to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html
    /// </summary>
    public class ElasticsearchDestinationConfiguration
    {

        /// <summary>
        /// BufferingHints
        /// Configures how Kinesis Data Firehose buffers incoming data while delivering it to the Amazon ES
        /// domain.
        /// Required: Yes
        /// Type: ElasticsearchBufferingHints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferingHints")]
        public ElasticsearchBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// CloudWatchLoggingOptions
        /// The Amazon CloudWatch Logs logging options for the delivery stream.
        /// Required: No
        /// Type: CloudWatchLoggingOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// DomainARN
        /// The Amazon Resource Name (ARN) of the Amazon ES domain that Kinesis Data Firehose delivers data to.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainARN")]
        public Union<string, IntrinsicFunction> DomainARN { get; set; }

        /// <summary>
        /// IndexName
        /// The name of the Elasticsearch index to which Kinesis Data Firehose adds data for indexing.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 80
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// IndexRotationPeriod
        /// The frequency of Elasticsearch index rotation. If you enable index rotation, Kinesis Data Firehose
        /// appends a portion of the UTC arrival timestamp to the specified index name, and rotates the appended
        /// timestamp accordingly. For more information, see Index Rotation for the Amazon ES Destination in the
        /// Amazon Kinesis Data Firehose Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: NoRotation | OneDay | OneHour | OneMonth | OneWeek
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexRotationPeriod")]
        public Union<string, IntrinsicFunction> IndexRotationPeriod { get; set; }

        /// <summary>
        /// ProcessingConfiguration
        /// The data processing configuration for the Kinesis Data Firehose delivery stream.
        /// Required: No
        /// Type: ProcessingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProcessingConfiguration")]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// RetryOptions
        /// The retry behavior when Kinesis Data Firehose is unable to deliver data to Amazon ES.
        /// Required: Yes
        /// Type: ElasticsearchRetryOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryOptions")]
        public ElasticsearchRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// RoleARN
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose for calling
        /// the Amazon ES Configuration API and for indexing documents. For more information, see Grant Kinesis
        /// Data Firehose Access to an Amazon S3 Destination.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// S3BackupMode
        /// The condition under which Kinesis Data Firehose delivers data to Amazon Simple Storage Service
        /// (Amazon S3). You can send Amazon S3 all documents (all data) or only the documents that Kinesis Data
        /// Firehose could not deliver to the Amazon ES destination. For more information and valid values, see
        /// the S3BackupMode content for the ElasticsearchDestinationConfiguration data type in the Amazon
        /// Kinesis Data Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: AllDocuments | FailedDocumentsOnly
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BackupMode")]
        public Union<string, IntrinsicFunction> S3BackupMode { get; set; }

        /// <summary>
        /// S3Configuration
        /// The S3 bucket where Kinesis Data Firehose backs up incoming data.
        /// Required: Yes
        /// Type: S3DestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Configuration")]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// TypeName
        /// The Elasticsearch type name that Amazon ES adds to documents when indexing data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TypeName")]
        public Union<string, IntrinsicFunction> TypeName { get; set; }

    }
}
