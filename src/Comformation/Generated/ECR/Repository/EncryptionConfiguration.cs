using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// AWS::ECR::Repository EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// EncryptionType
        /// The encryption type to use.
        /// If you use the KMS encryption type, the contents of the repository will be encrypted using
        /// server-side encryption with AWS Key Management Service key stored in AWS KMS. When you use AWS KMS
        /// to encrypt your data, you can either use the default AWS managed AWS KMS key for Amazon ECR, or
        /// specify your own AWS KMS key, which you already created. For more information, see Protecting data
        /// using server-side encryption with an AWS KMS key stored in AWS Key Management Service (SSE-KMS) in
        /// the Amazon Simple Storage Service Console Developer Guide. .
        /// If you use the AES256 encryption type, Amazon ECR uses server-side encryption with Amazon S3-managed
        /// encryption keys which encrypts the images in the repository using an AES-256 encryption algorithm.
        /// For more information, see Protecting data using server-side encryption with Amazon S3-managed
        /// encryption keys (SSE-S3) in the Amazon Simple Storage Service Console Developer Guide. .
        /// Required: Yes
        /// Type: String
        /// Allowed values: AES256 | KMS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EncryptionType")]
        public Union<string, IntrinsicFunction> EncryptionType { get; set; }

        /// <summary>
        /// KmsKey
        /// If you use the KMS encryption type, specify the AWS KMS key to use for encryption. The alias, key
        /// ID, or full ARN of the AWS KMS key can be specified. The key must exist in the same Region as the
        /// repository. If no key is specified, the default AWS managed AWS KMS key for Amazon ECR will be used.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKey")]
        public Union<string, IntrinsicFunction> KmsKey { get; set; }

    }
}
