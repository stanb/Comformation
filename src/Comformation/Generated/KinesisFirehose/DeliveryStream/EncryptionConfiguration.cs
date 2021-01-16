using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// KMSEncryptionConfig
        /// The AWS Key Management Service (AWS KMS) encryption key that Amazon S3 uses to encrypt your data.
        /// Required: No
        /// Type: KMSEncryptionConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KMSEncryptionConfig")]
        public KMSEncryptionConfig KMSEncryptionConfig { get; set; }

        /// <summary>
        /// NoEncryptionConfig
        /// Disables encryption. For valid values, see the NoEncryptionConfig content for the
        /// EncryptionConfiguration data type in the Amazon Kinesis Data Firehose API Reference.
        /// Required: No
        /// Type: String
        /// Allowed values: NoEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoEncryptionConfig")]
        public Union<string, IntrinsicFunction> NoEncryptionConfig { get; set; }

    }
}
