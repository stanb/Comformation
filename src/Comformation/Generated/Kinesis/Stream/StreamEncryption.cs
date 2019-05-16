using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kinesis.Stream
{
    /// <summary>
    /// AWS::Kinesis::Stream StreamEncryption
    /// Enables or updates server-side encryption using an AWS KMS key for a specified stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-streamencryption.html
    /// </summary>
    public class StreamEncryption
    {

        /// <summary>
        /// EncryptionType
        /// The encryption type to use. The only valid value is KMS.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: KMS | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionType")]
        public Union<string, IntrinsicFunction> EncryptionType { get; set; }

        /// <summary>
        /// KeyId
        /// The GUID for the customer-managed AWS KMS key to use for encryption. This value can be a globally
        /// unique identifier, a fully specified Amazon Resource Name (ARN) to either an alias or a key, or an
        /// alias name prefixed by &quot;alias/&quot;. You can also use a master key owned by Kinesis Data Streams by
        /// specifying the alias aws/kinesis.
        /// Key ARN example: arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 Alias
        /// ARN example: arn:aws:kms:us-east-1:123456789012:alias/MyAliasName Globally unique key ID example:
        /// 12345678-1234-1234-1234-123456789012 Alias name example: alias/MyAliasName Master key owned by
        /// Kinesis Data Streams: alias/aws/kinesis
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyId")]
        public Union<string, IntrinsicFunction> KeyId { get; set; }

    }
}
