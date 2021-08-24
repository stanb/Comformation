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
        /// repository. Changes to this property are ignored after initial resource creation.
        /// Required: Yes
        /// Type: S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3 { get; set; }

        /// <summary>
        /// BranchName
        /// Optional. Specifies a branch name to be used as the default branch when importing code into a
        /// repository on initial creation. If this property is not set, the name main will be used for the
        /// default branch for the repository. Changes to this property are ignored after initial resource
        /// creation. We recommend using this parameter to set the name to main to align with the default
        /// behavior of CodeCommit unless another name is needed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BranchName")]
        public Union<string, IntrinsicFunction> BranchName { get; set; }

    }
}
