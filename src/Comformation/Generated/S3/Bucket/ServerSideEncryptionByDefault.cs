using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket ServerSideEncryptionByDefault
    /// The ServerSideEncryptionByDefault property is part of the AWS::S3::Bucket resource that specifies the
    /// server-side encryption by default. For more information, see PUT Bucket encryption in the Amazon Simple
    /// Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionbydefault.html
    /// </summary>
    public class ServerSideEncryptionByDefault
    {

        /// <summary>
        /// KMSMasterKeyID
        /// The AWS KMS master key ID used for the SSE-KMS encryption.
        /// Constraint: Can only be used when you set the value of SSEAlgorithm as aws:kms. The default aws/s3
        /// AWS KMS master key is used if this property is absent while SSEAlgorithm is aws:kms.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KMSMasterKeyID")]
        public Union<string, IntrinsicFunction> KMSMasterKeyID { get; set; }

        /// <summary>
        /// SSEAlgorithm
        /// The server-side encryption algorithm to use. Valid values include AES256 and aws:kms.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEAlgorithm")]
        public Union<string, IntrinsicFunction> SSEAlgorithm { get; set; }

    }
}
