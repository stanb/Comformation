using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository Code
    /// Information about code to be committed.
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

    }
}
