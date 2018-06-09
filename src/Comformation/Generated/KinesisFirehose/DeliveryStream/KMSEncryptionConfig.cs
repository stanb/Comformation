using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream KMSEncryptionConfig
    /// The KMSEncryptionConfig property type specifies the AWS Key Management Service (AWS KMS) encryption key that
    /// Amazon Simple Storage Service (Amazon S3) uses to encrypt data delivered by the Amazon Kinesis Firehose
    /// (Kinesis Firehose) stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kmsencryptionconfig.html
    /// </summary>
    public class KMSEncryptionConfig
    {

        /// <summary>
        /// AWSKMSKeyARN
        /// The Amazon Resource Name (ARN) of the AWS KMS encryption key that Amazon S3 uses to encrypt data
        /// delivered by the Kinesis Firehose stream. The key must belong to the same region as the destination
        /// S3 bucket.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AWSKMSKeyARN")]
        public Union<string, IntrinsicFunction> AWSKMSKeyARN { get; set; }

    }
}
