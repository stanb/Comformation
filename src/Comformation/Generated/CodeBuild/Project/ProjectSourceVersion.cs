using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project ProjectSourceVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectsourceversion.html
    /// </summary>
    public class ProjectSourceVersion
    {

        /// <summary>
        /// SourceIdentifier
        /// An identifier for a source in the build project. The identifier can only contain alphanumeric
        /// characters and underscores, and must be less than 128 characters in length.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

        /// <summary>
        /// SourceVersion
        /// The source version for the corresponding source identifier. If specified, must be one of:
        /// For CodeCommit: the commit ID, branch, or Git tag to use. For GitHub: the commit ID, pull request
        /// ID, branch name, or tag name that corresponds to the version of the source code you want to build.
        /// If a pull request ID is specified, it must use the format pr/pull-request-ID (for example, pr/25).
        /// If a branch name is specified, the branch&#39;s HEAD commit ID is used. If not specified, the default
        /// branch&#39;s HEAD commit ID is used. For Bitbucket: the commit ID, branch name, or tag name that
        /// corresponds to the version of the source code you want to build. If a branch name is specified, the
        /// branch&#39;s HEAD commit ID is used. If not specified, the default branch&#39;s HEAD commit ID is used. For
        /// Amazon S3: the version ID of the object that represents the build input ZIP file to use.
        /// For more information, see Source Version Sample with CodeBuild in the AWS CodeBuild User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceVersion")]
        public Union<string, IntrinsicFunction> SourceVersion { get; set; }

    }
}
