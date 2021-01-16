using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project ProjectBuildBatchConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html
    /// </summary>
    public class ProjectBuildBatchConfig
    {

        /// <summary>
        /// CombineArtifacts
        /// Specifies if the build artifacts for the batch build should be combined into a single artifact
        /// location.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CombineArtifacts")]
        public Union<bool, IntrinsicFunction> CombineArtifacts { get; set; }

        /// <summary>
        /// ServiceRole
        /// Specifies the service role ARN for the batch build project.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceRole")]
        public Union<string, IntrinsicFunction> ServiceRole { get; set; }

        /// <summary>
        /// TimeoutInMins
        /// Specifies the maximum amount of time, in minutes, that the batch build must be completed in.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutInMins")]
        public Union<int, IntrinsicFunction> TimeoutInMins { get; set; }

        /// <summary>
        /// Restrictions
        /// A BatchRestrictions object that specifies the restrictions for the batch build.
        /// Required: No
        /// Type: BatchRestrictions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Restrictions")]
        public BatchRestrictions Restrictions { get; set; }

    }
}
