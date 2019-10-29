using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration JobBookmarksEncryption
    /// Specifies how job bookmark data should be encrypted.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-jobbookmarksencryption.html
    /// </summary>
    public class JobBookmarksEncryption
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
        /// JobBookmarksEncryptionMode
        /// The encryption mode to use for job bookmarks data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobBookmarksEncryptionMode")]
        public Union<string, IntrinsicFunction> JobBookmarksEncryptionMode { get; set; }

    }
}
