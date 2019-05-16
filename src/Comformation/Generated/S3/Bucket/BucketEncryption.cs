using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket BucketEncryption
    /// Specifies default encryption for a bucket using server-side encryption with Amazon S3-managed keys (SSE-S3) or
    /// AWS KMS-managed keys (SSE-KMS) bucket. For information about the Amazon S3 default encryption feature, see
    /// Amazon S3 Default Encryption for S3 Buckets in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html
    /// </summary>
    public class BucketEncryption
    {

        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// Specifies the default server-side-encryption configuration.
        /// Required: Yes
        /// Type: List of ServerSideEncryptionRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerSideEncryptionConfiguration")]
        public List<ServerSideEncryptionRule> ServerSideEncryptionConfiguration { get; set; }

    }
}
