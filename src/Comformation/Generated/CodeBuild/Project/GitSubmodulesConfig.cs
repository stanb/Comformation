using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project GitSubmodulesConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-gitsubmodulesconfig.html
    /// </summary>
    public class GitSubmodulesConfig
    {

        /// <summary>
        /// FetchSubmodules
        /// Set to true to fetch Git submodules for your AWS CodeBuild build project.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FetchSubmodules")]
        public Union<bool, IntrinsicFunction> FetchSubmodules { get; set; }

    }
}
