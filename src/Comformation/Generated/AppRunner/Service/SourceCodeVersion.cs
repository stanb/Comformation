using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service SourceCodeVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourcecodeversion.html
    /// </summary>
    public class SourceCodeVersion
    {

        /// <summary>
        /// Type
        /// The type of version identifier.
        /// For a git-based repository, branches represent versions.
        /// Required: Yes
        /// Type: String
        /// Allowed values: BRANCH
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// A source code version.
        /// For a git-based repository, a branch name maps to a specific version. App Runner uses the most
        /// recent commit to the branch.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 51200
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
