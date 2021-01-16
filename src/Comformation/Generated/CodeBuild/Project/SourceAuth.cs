using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project SourceAuth
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-sourceauth.html
    /// </summary>
    public class SourceAuth
    {

        /// <summary>
        /// Type
        /// The authorization type to use. The only valid value is OAUTH, which represents the OAuth
        /// authorization type.
        /// Note This data type is used by the AWS CodeBuild console only.
        /// Required: Yes
        /// Type: String
        /// Allowed values: OAUTH
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Resource
        /// The resource value that applies to the specified authorization type.
        /// Note This data type is used by the AWS CodeBuild console only.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Resource")]
        public Union<string, IntrinsicFunction> Resource { get; set; }

    }
}
