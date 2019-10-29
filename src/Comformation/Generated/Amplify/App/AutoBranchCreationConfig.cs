using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App AutoBranchCreationConfig
    /// Use the AutoBranchCreationConfig property type to automatically create branches that match a certain pattern.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html
    /// </summary>
    public class AutoBranchCreationConfig
    {

        /// <summary>
        /// EnvironmentVariables
        /// Environment variables for the auto created branch.
        /// Required: No
        /// Type: List of EnvironmentVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// EnableAutoBranchCreation
        /// Enables automated branch creation for the Amplify app.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableAutoBranchCreation")]
        public Union<bool, IntrinsicFunction> EnableAutoBranchCreation { get; set; }

        /// <summary>
        /// AutoBranchCreationPatterns
        /// Automated branch creation glob patterns for the Amplify app.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoBranchCreationPatterns")]
        public List<Union<string, IntrinsicFunction>> AutoBranchCreationPatterns { get; set; }

        /// <summary>
        /// EnableAutoBuild
        /// Enables auto building for the auto created branch.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableAutoBuild")]
        public Union<bool, IntrinsicFunction> EnableAutoBuild { get; set; }

        /// <summary>
        /// BuildSpec
        /// Build spec for the auto created branch.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BuildSpec")]
        public Union<string, IntrinsicFunction> BuildSpec { get; set; }

        /// <summary>
        /// Stage
        /// Stage for the auto created branch.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Stage")]
        public Union<string, IntrinsicFunction> Stage { get; set; }

        /// <summary>
        /// BasicAuthConfig
        /// Sets password protection for your auto created branch.
        /// Required: No
        /// Type: BasicAuthConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BasicAuthConfig")]
        public BasicAuthConfig BasicAuthConfig { get; set; }

    }
}
