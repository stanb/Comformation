using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream S3DestinationConfiguration
    /// The S3DestinationConfiguration property type specifies an Amazon Simple Storage Service (Amazon S3)
    /// destination to which Amazon Kinesis Data Firehose (Kinesis Data Firehose) delivers data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html
    /// </summary>
    public class S3DestinationConfiguration
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket to send data to.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// BufferingHints
        /// Configures how Kinesis Data Firehose buffers incoming data while delivering it to the Amazon S3
        /// bucket.
        /// Required: Yes
        /// Type: BufferingHints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferingHints")]
        public BufferingHints BufferingHints { get; set; }

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
        /// CompressionFormat
        /// The type of compression that Kinesis Data Firehose uses to compress the data that it delivers to the
        /// Amazon S3 bucket. For valid values, see the CompressionFormat content for the
        /// S3DestinationConfiguration data type in the Amazon Kinesis Data Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: GZIP | Snappy | UNCOMPRESSED | ZIP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompressionFormat")]
        public Union<string, IntrinsicFunction> CompressionFormat { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// Configures Amazon Simple Storage Service (Amazon S3) server-side encryption. Kinesis Data Firehose
        /// uses AWS Key Management Service (AWS KMS) to encrypt the data that it delivers to your Amazon S3
        /// bucket.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Prefix
        /// A prefix that Kinesis Data Firehose adds to the files that it delivers to the Amazon S3 bucket. The
        /// prefix helps you identify the files that Kinesis Data Firehose delivered.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of an AWS Identity and Access Management (IAM) role that grants Kinesis Data Firehose access
        /// to your Amazon S3 bucket and AWS KMS (if you enable data encryption). For more information, see
        /// Grant Kinesis Data Firehose Access to an Amazon S3 Destination in the Amazon Kinesis Data Firehose
        /// Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
