using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ServerSideEncryptionByDefault
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html
    /// </summary>
    public class ServerSideEncryptionByDefault
    {

        /// <summary>
        /// KMSMasterKeyID
        /// KMS key ID to use for the default encryption. This parameter is allowed if SSEAlgorithm is aws:kms.
        /// You can specify the key ID or the Amazon Resource Name (ARN) of the CMK. However, if you are using
        /// encryption with cross-account operations, you must use a fully qualified CMK ARN. For more
        /// information, see Using encryption for cross-account operations.
        /// For example:
        /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab Key ARN:
        /// arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
        /// Important Amazon S3 only supports symmetric CMKs and not asymmetric CMKs. For more information, see
        /// Using Symmetric and Asymmetric Keys in the AWS Key Management Service Developer Guide.
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
        /// Allowed values: AES256 | aws:kms
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEAlgorithm")]
        public Union<string, IntrinsicFunction> SSEAlgorithm { get; set; }

    }
}
