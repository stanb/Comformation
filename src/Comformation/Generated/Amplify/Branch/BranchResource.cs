using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Branch
{
    /// <summary>
    /// AWS::Amplify::Branch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html
    /// </summary>
    public class BranchResource : ResourceBase
    {
        public class BranchProperties
        {
            /// <summary>
            /// Description
            /// The description for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentVariables
            /// The environment variables for the branch.
            /// Required: No
            /// Type: List of EnvironmentVariable
            /// Update requires: No interruption
            /// </summary>
            public List<EnvironmentVariable> EnvironmentVariables { get; set; }

            /// <summary>
            /// AppId
            /// The unique ID for an Amplify app.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppId { get; set; }

            /// <summary>
            /// PullRequestEnvironmentName
            /// If pull request previews are enabled for this branch, you can use this property to specify a
            /// dedicated backend environment for your previews. For example, you could specify an environment named
            /// prod, test, or dev that you initialized with the Amplify CLI and mapped to this branch.
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
            public Union<string, IntrinsicFunction> PullRequestEnvironmentName { get; set; }

            /// <summary>
            /// EnablePullRequestPreview
            /// Sets whether the Amplify Console creates a preview for each pull request that is made for this
            /// branch. If this property is enabled, the Amplify Console deploys your app to a unique preview URL
            /// after each pull request is opened. Development and QA teams can use this preview to test the pull
            /// request before it&#39;s merged into a production or integration branch.
            /// To provide backend support for your preview, the Amplify Console automatically provisions a
            /// temporary backend environment that it deletes when the pull request is closed. If you want to
            /// specify a dedicated backend environment for your previews, use the PullRequestEnvironmentName
            /// property.
            /// For more information, see Web Previews in the AWS Amplify Console User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnablePullRequestPreview { get; set; }

            /// <summary>
            /// EnableAutoBuild
            /// Enables auto building for the branch.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
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
            public Union<bool, IntrinsicFunction> EnablePerformanceMode { get; set; }

            /// <summary>
            /// BuildSpec
            /// The build specification (build spec) for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BuildSpec { get; set; }

            /// <summary>
            /// Stage
            /// Describes the current stage for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Stage { get; set; }

            /// <summary>
            /// BranchName
            /// The name for the branch.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BranchName { get; set; }

            /// <summary>
            /// BasicAuthConfig
            /// The basic authorization credentials for a branch of an Amplify app.
            /// Required: No
            /// Type: BasicAuthConfig
            /// Update requires: No interruption
            /// </summary>
            public BasicAuthConfig BasicAuthConfig { get; set; }

            /// <summary>
            /// Tags
            /// The tag for the branch.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Amplify::Branch";

        public BranchProperties Properties { get; } = new BranchProperties();

    }

    public static class BranchAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> BranchName = new ResourceAttribute<Union<string, IntrinsicFunction>>("BranchName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
