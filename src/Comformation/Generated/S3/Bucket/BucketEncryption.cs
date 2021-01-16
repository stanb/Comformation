using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket BucketEncryption
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
