using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration CloudWatchEncryption
    /// Specifies how Amazon CloudWatch data should be encrypted.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html
    /// </summary>
    public class CloudWatchEncryption
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
        /// CloudWatchEncryptionMode
        /// The encryption mode to use for CloudWatch data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchEncryptionMode")]
        public Union<string, IntrinsicFunction> CloudWatchEncryptionMode { get; set; }

    }
}
