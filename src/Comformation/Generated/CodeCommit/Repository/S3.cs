using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository S3
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-s3.html
    /// </summary>
    public class S3
    {

        /// <summary>
        /// ObjectVersion
        /// The object version of the ZIP file, if versioning is enabled for the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectVersion")]
        public Union<string, IntrinsicFunction> ObjectVersion { get; set; }

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket that contains the ZIP file with the content that will be committed
        /// to the new repository. This can be specified using an ARN or the name of the bucket in the AWS
        /// account.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The key to use for accessing the Amazon S3 bucket. This is an Amazon S3 object key as defined in the
        /// Amazon S3 Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
