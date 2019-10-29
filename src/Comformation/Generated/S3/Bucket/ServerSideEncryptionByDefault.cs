using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ServerSideEncryptionByDefault
    /// Describes the default server-side encryption to apply to new objects in the bucket. If a PUT Object request
    /// doesn&#39;t specify any server-side encryption, this default encryption will be applied. For more information, see
    /// PUT Bucket encryption in the Amazon Simple Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html
    /// </summary>
    public class ServerSideEncryptionByDefault
    {

        /// <summary>
        /// KMSMasterKeyID
        /// KMS key ID to use for the default encryption. This parameter is allowed if SSEAlgorithm is aws:kms.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KMSMasterKeyID")]
        public Union<string, IntrinsicFunction> KMSMasterKeyID { get; set; }

        /// <summary>
        /// SSEAlgorithm
        /// Server-side encryption algorithm to use for the default encryption.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: AES256 | aws:kms
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEAlgorithm")]
        public Union<string, IntrinsicFunction> SSEAlgorithm { get; set; }

    }
}
