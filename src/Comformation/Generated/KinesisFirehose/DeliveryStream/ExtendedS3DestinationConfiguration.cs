using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Data Firehose DeliveryStream ExtendedS3DestinationConfiguration
    /// The ExtendedS3DestinationConfiguration property type configures an Amazon S3 destination for an Amazon Kinesis
    /// Data Firehose delivery stream. ExtendedS3DestinationConfiguration is a property of the
    /// AWS::KinesisFirehose::DeliveryStream resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html
    /// </summary>
    public class ExtendedS3DestinationConfiguration
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket. For constraints, see
        /// ExtendedS3DestinationConfiguration in the Amazon Kinesis Data Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// BufferingHints
        /// The buffering option.
        /// Required: Yes
        /// Type: BufferingHints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferingHints")]
        public BufferingHints BufferingHints { get; set; }

        /// <summary>
        /// CloudWatchLoggingOptions
        /// The CloudWatch logging options for the Kinesis Data Firehose delivery stream.
        /// Required: No
        /// Type: CloudWatchLoggingOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLoggingOptions")]
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// CompressionFormat
        /// The compression format for the Kinesis Data Firehose delivery stream. The default value is
        /// UNCOMPRESSED. For valid values, see ExtendedS3DestinationConfiguration in the Amazon Kinesis Data
        /// Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompressionFormat")]
        public Union<string, IntrinsicFunction> CompressionFormat { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// The encryption configuration for the Kinesis Data Firehose delivery stream. The default value is
        /// NoEncryption.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Prefix
        /// The YYYY/MM/DD/HH time format prefix is automatically used for delivered Amazon S3 files. For more
        /// information, see ExtendedS3DestinationConfiguration in the Amazon Kinesis Data Firehose API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

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
        /// RoleARN
        /// The ARN of the AWS credentials. For constraints, see ExtendedS3DestinationConfiguration in the
        /// Amazon Kinesis Data Firehose API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

        /// <summary>
        /// S3BackupConfiguration
        /// The configuration for backup in Amazon S3.
        /// Required: No
        /// Type: S3DestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BackupConfiguration")]
        public S3DestinationConfiguration S3BackupConfiguration { get; set; }

        /// <summary>
        /// S3BackupMode
        /// The Amazon S3 backup mode. For valid values, see ExtendedS3DestinationConfiguration in the Amazon
        /// Kinesis Data Firehose API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BackupMode")]
        public Union<string, IntrinsicFunction> S3BackupMode { get; set; }

    }
}
