using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ServerSideEncryptionRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html
    /// </summary>
    public class ServerSideEncryptionRule
    {

        /// <summary>
        /// BucketKeyEnabled
        /// Specifies whether Amazon S3 should use an S3 Bucket Key with server-side encryption using KMS
        /// (SSE-KMS) for new objects in the bucket. Existing objects are not affected. Setting the
        /// BucketKeyEnabled element to true causes Amazon S3 to use an S3 Bucket Key. By default, S3 Bucket Key
        /// is not enabled.
        /// For more information, see Amazon S3 Bucket Keys in the Amazon S3 Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketKeyEnabled")]
        public Union<bool, IntrinsicFunction> BucketKeyEnabled { get; set; }

        /// <summary>
        /// ServerSideEncryptionByDefault
        /// Specifies the default server-side encryption to apply to new objects in the bucket. If a PUT Object
        /// request doesn&#39;t specify any server-side encryption, this default encryption will be applied.
        /// Required: No
        /// Type: ServerSideEncryptionByDefault
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerSideEncryptionByDefault")]
        public ServerSideEncryptionByDefault ServerSideEncryptionByDefault { get; set; }

    }
}
