using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration S3Encryption
    /// Specifies how Amazon Simple Storage Service (Amazon S3) data should be encrypted.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-s3encryption.html
    /// </summary>
    public class S3Encryption
    {

        /// <summary>
        /// KmsKeyArn
        /// The Amazon Resource Name (ARN) of the KMS key to be used to encrypt the data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyArn")]
        public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

        /// <summary>
        /// S3EncryptionMode
        /// The encryption mode to use for Amazon S3 data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3EncryptionMode")]
        public Union<string, IntrinsicFunction> S3EncryptionMode { get; set; }

    }
}
