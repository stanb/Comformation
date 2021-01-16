using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStar.GitHubRepository
{
    /// <summary>
    /// AWS::CodeStar::GitHubRepository S3
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-s3.html
    /// </summary>
    public class S3
    {

        /// <summary>
        /// ObjectVersion
        /// The object version of the ZIP file, if versioning is enabled for the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: Updates are not supported.
        /// </summary>
        [JsonProperty("ObjectVersion")]
        public Union<string, IntrinsicFunction> ObjectVersion { get; set; }

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket that contains the ZIP file with the content to be committed to the
        /// new repository.
        /// Required: Yes
        /// Type: String
        /// Update requires: Updates are not supported.
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The S3 object key or file name for the ZIP file.
        /// Required: Yes
        /// Type: String
        /// Update requires: Updates are not supported.
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
