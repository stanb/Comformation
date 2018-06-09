using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket ServerSideEncryptionRule
    /// The ServerSideEncryptionRule property is part of the AWS::S3::Bucket resource that specifies the server-side
    /// encryption by default configuration. For more information, see PUT Bucket encryption in the Amazon Simple
    /// Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html
    /// </summary>
    public class ServerSideEncryptionRule
    {

        /// <summary>
        /// ServerSideEncryptionByDefault
        /// Sets server-side encryption by default.
        /// Required: No
        /// Type: ServerSideEncryptionByDefault
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerSideEncryptionByDefault")]
        public Union<ServerSideEncryptionByDefault, IntrinsicFunction> ServerSideEncryptionByDefault { get; set; }

    }
}
