using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream KMSEncryptionConfig
    /// The KMSEncryptionConfig property type specifies the AWS Key Management Service (AWS KMS) encryption key that
    /// Amazon Simple Storage Service (Amazon S3) uses to encrypt data delivered by the Amazon Kinesis Data Firehose
    /// (Kinesis Data Firehose) stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kmsencryptionconfig.html
    /// </summary>
    public class KMSEncryptionConfig
    {

        /// <summary>
        /// AWSKMSKeyARN
        /// The Amazon Resource Name (ARN) of the AWS KMS encryption key that Amazon S3 uses to encrypt data
        /// delivered by the Kinesis Data Firehose stream. The key must belong to the same region as the
        /// destination S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AWSKMSKeyARN")]
        public Union<string, IntrinsicFunction> AWSKMSKeyARN { get; set; }

    }
}
