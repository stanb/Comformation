using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App AutoBranchCreationConfig
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
        /// PullRequestEnvironmentName
        /// If pull request previews are enabled, you can use this property to specify a dedicated backend
        /// environment for your previews. For example, you could specify an environment named prod, test, or
        /// dev that you initialized with the Amplify CLI.
        /// To enable pull request previews, set the EnablePullRequestPreview property to true.
        /// If you don&#39;t specify an environment, the Amplify Console provides backend support for each preview
        /// by automatically provisioning a temporary backend environment. Amplify Console deletes this
        /// environment when the pull request is closed.
        /// For more information about creating backend environments, see Feature Branch Deployments and Team
        /// Workflows in the AWS Amplify Console User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PullRequestEnvironmentName")]
        public Union<string, IntrinsicFunction> PullRequestEnvironmentName { get; set; }

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
        /// EnablePullRequestPreview
        /// Sets whether pull request previews are enabled for each branch that Amplify Console automatically
        /// creates for your app. Amplify Console creates previews by deploying your app to a unique URL
        /// whenever a pull request is opened for the branch. Development and QA teams can use this preview to
        /// test the pull request before it&#39;s merged into a production or integration branch.
        /// To provide backend support for your preview, the Amplify Console automatically provisions a
        /// temporary backend environment that it deletes when the pull request is closed. If you want to
        /// specify a dedicated backend environment for your previews, use the PullRequestEnvironmentName
        /// property.
        /// For more information, see Web Previews in the AWS Amplify Console User Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnablePullRequestPreview")]
        public Union<bool, IntrinsicFunction> EnablePullRequestPreview { get; set; }

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
        /// EnablePerformanceMode
        /// Enables performance mode for the branch.
        /// Performance mode optimizes for faster hosting performance by keeping content cached at the edge for
        /// a longer interval. When performance mode is enabled, hosting configuration or code changes can take
        /// up to 10 minutes to roll out.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnablePerformanceMode")]
        public Union<bool, IntrinsicFunction> EnablePerformanceMode { get; set; }

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
