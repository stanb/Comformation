using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ServerSideEncryptionRule
    /// Specifies the default server-side encryption configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html
    /// </summary>
    public class ServerSideEncryptionRule
    {

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
