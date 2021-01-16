using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream ElasticsearchDestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html
    /// </summary>
    public class ElasticsearchDestinationConfiguration
    {

        /// <summary>
        /// BufferingHints
        /// Configures how Kinesis Data Firehose buffers incoming data while delivering it to the Amazon ES
        /// domain.
        /// Required: No
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
        /// The ARN of the Amazon ES domain. The IAM role must have permissions for&#160;DescribeElasticsearchDomain,
        /// DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig&#160;after assuming the role
        /// specified in RoleARN.
        /// Specify either ClusterEndpoint or DomainARN.
        /// Required: No
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
        /// Pattern: . *
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
        /// Required: No
        /// Type: String
        /// Allowed values: NoRotation | OneDay | OneHour | OneMonth | OneWeek
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
        /// Required: No
        /// Type: ElasticsearchRetryOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryOptions")]
        public ElasticsearchRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// RoleARN
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose for calling
        /// the Amazon ES Configuration API and for indexing documents. For more information, see Controlling
        /// Access with Amazon Kinesis Data Firehose.
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
        /// Required: No
        /// Type: String
        /// Allowed values: AllDocuments | FailedDocumentsOnly
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
        /// ClusterEndpoint
        /// The endpoint to use when communicating with the cluster. Specify either this ClusterEndpoint or the
        /// DomainARN field.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClusterEndpoint")]
        public Union<string, IntrinsicFunction> ClusterEndpoint { get; set; }

        /// <summary>
        /// TypeName
        /// The Elasticsearch type name that Amazon ES adds to documents when indexing data.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 100
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TypeName")]
        public Union<string, IntrinsicFunction> TypeName { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// The details of the VPC of the Amazon ES destination.
        /// Required: No
        /// Type: VpcConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public VpcConfiguration VpcConfiguration { get; set; }

    }
}
