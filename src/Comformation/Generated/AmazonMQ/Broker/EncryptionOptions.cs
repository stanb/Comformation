using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// AWS::AmazonMQ::Broker EncryptionOptions
    /// Encryption options for the broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-encryptionoptions.html
    /// </summary>
    public class EncryptionOptions
    {

        /// <summary>
        /// KmsKeyId
        /// The customer master key (CMK) to use for the AWS Key Management Service (KMS). This key is used to
        /// encrypt your data at rest. If not provided, Amazon MQ will use a default CMK to encrypt your data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// UseAwsOwnedKey
        /// Enables the use of an AWS owned CMK using AWS Key Management Service (KMS).
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseAwsOwnedKey")]
        public Union<bool, IntrinsicFunction> UseAwsOwnedKey { get; set; }

    }
}
