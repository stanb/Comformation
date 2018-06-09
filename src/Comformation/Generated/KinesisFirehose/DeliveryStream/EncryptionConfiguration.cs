using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// Amazon Kinesis Firehose DeliveryStream EncryptionConfiguration
    /// The EncryptionConfiguration property type specifies the encryption settings that Amazon Kinesis Firehose
    /// (Kinesis Firehose) uses when delivering data to Amazon Simple Storage Service (Amazon S3).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// KMSEncryptionConfig
        /// The AWS Key Management Service (AWS KMS) encryption key that Amazon S3 uses to encrypt your data.
        /// Required: No
        /// Type: Amazon Kinesis Firehose DeliveryStream KMSEncryptionConfig
        /// </summary>
        [JsonProperty("KMSEncryptionConfig")]
        public Union<KMSEncryptionConfig, IntrinsicFunction> KMSEncryptionConfig { get; set; }

        /// <summary>
        /// NoEncryptionConfig
        /// Disables encryption. For valid values, see the NoEncryptionConfig content for the
        /// EncryptionConfiguration data type in the Amazon Kinesis Firehose API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("NoEncryptionConfig")]
        public Union<string, IntrinsicFunction> NoEncryptionConfig { get; set; }

    }
}
