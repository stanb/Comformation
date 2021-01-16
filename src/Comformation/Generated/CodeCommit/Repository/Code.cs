using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository Code
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3
        /// Information about the Amazon S3 bucket that contains a ZIP file of code to be committed to the
        /// repository.
        /// Required: Yes
        /// Type: S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3 { get; set; }

        /// <summary>
        /// BranchName
        /// Optional. Specifies a branch name to be used as the default branch when importing code into a
        /// repository. If this property is not set, the name master will be used for the default branch for the
        /// repository.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BranchName")]
        public Union<string, IntrinsicFunction> BranchName { get; set; }

    }
}
