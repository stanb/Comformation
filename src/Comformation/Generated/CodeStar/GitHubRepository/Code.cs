using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStar.GitHubRepository
{
    /// <summary>
    /// AWS::CodeStar::GitHubRepository Code
    /// The Code property type specifies information about code to be committed.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codestar-githubrepository-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3
        /// Information about the Amazon S3 bucket that contains a ZIP file of code to be committed to the
        /// repository.
        /// Required: Yes
        /// Type: S3
        /// Update requires: Updates are not supported.
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3 { get; set; }

    }
}
