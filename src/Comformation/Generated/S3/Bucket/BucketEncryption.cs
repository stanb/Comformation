using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket BucketEncryption
    /// The BucketEncryption property is part of the AWS::S3::Bucket resource that specifies default encryption for a
    /// bucket using server-side encryption with Amazon S3-managed keys SSE-S3 or AWS KMS-managed Keys (SSE-KMS)
    /// bucket. For information about the Amazon S3 default encryption feature, see Amazon S3 Default Bucket
    /// Encryption in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html
    /// </summary>
    public class BucketEncryption
    {

        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// Specifies the server-side encryption by default configuration.
        /// Required: Yes
        /// Type: List of Amazon S3 Bucket ServerSideEncryptionRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerSideEncryptionConfiguration")]
        public Union<List<ServerSideEncryptionRule>, IntrinsicFunction> ServerSideEncryptionConfiguration { get; set; }

    }
}
