using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html
    /// </summary>
    public class AppResource : ResourceBase
    {
        public class AppProperties
        {
            /// <summary>
            /// AccessToken
            /// Personal Access token for 3rd party source control system for an Amplify app, used to create webhook
            /// and read-only deploy key. Token is not stored.
            /// Length Constraints: Minimum length of 1. Maximum length of 255.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AccessToken { get; set; }

            /// <summary>
            /// AutoBranchCreationConfig
            /// Sets the configuration for your automatic branch creation.
            /// Required: No
            /// Type: AutoBranchCreationConfig
            /// Update requires: No interruption
            /// </summary>
            public AutoBranchCreationConfig AutoBranchCreationConfig { get; set; }

            /// <summary>
            /// BasicAuthConfig
            /// The credentials for basic authorization for an Amplify app.
            /// Required: No
            /// Type: BasicAuthConfig
            /// Update requires: No interruption
            /// </summary>
            public BasicAuthConfig BasicAuthConfig { get; set; }

            /// <summary>
            /// BuildSpec
            /// The build specification (build spec) for an Amplify app.
            /// Length Constraints: Minimum length of 1. Maximum length of 25000.
            /// Pattern: (?s). +
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BuildSpec { get; set; }

            /// <summary>
            /// CustomHeaders
            /// The custom HTTP headers for an Amplify app.
            /// Length Constraints: Minimum length of 0. Maximum length of 25000.
            /// Pattern: (?s). *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CustomHeaders { get; set; }

            /// <summary>
            /// CustomRules
            /// The custom rewrite and redirect rules for an Amplify app.
            /// Required: No
            /// Type: List of CustomRule
            /// Update requires: No interruption
            /// </summary>
            public List<CustomRule> CustomRules { get; set; }

            /// <summary>
            /// Description
            /// The description for an Amplify app.
            /// Length Constraints: Maximum length of 1000.
            /// Pattern: (?s). *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnableBranchAutoDeletion
            /// Automatically disconnect a branch in the Amplify Console when you delete a branch from your Git
            /// repository.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableBranchAutoDeletion { get; set; }

            /// <summary>
            /// EnvironmentVariables
            /// The environment variables map for an Amplify app.
            /// Required: No
            /// Type: List of EnvironmentVariable
            /// Update requires: No interruption
            /// </summary>
            public List<EnvironmentVariable> EnvironmentVariables { get; set; }

            /// <summary>
            /// IAMServiceRole
            /// The AWS Identity and Access Management (IAM) service role for the Amazon Resource Name (ARN) of the
            /// Amplify app.
            /// Length Constraints: Minimum length of 0. Maximum length of 1000.
            /// Pattern: (?s). *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IAMServiceRole { get; set; }

            /// <summary>
            /// Name
            /// The name for an Amplify app.
            /// Length Constraints: Minimum length of 1. Maximum length of 255.
            /// Pattern: (?s). +
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// OauthToken
            /// The OAuth token for a third-party source control system for an Amplify app. The OAuth token is used
            /// to create a webhook and a read-only deploy key. The OAuth token is not stored.
            /// Length Constraints: Maximum length of 1000.
            /// Pattern: (?s). *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> OauthToken { get; set; }

            /// <summary>
            /// Repository
            /// The repository for an Amplify app.
            /// Pattern: (?s). *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Repository { get; set; }

            /// <summary>
            /// Tags
            /// The tag for an Amplify app.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Amplify::App";

        public AppProperties Properties { get; } = new AppProperties();

    }

    public static class AppAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppName = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DefaultDomain = new ResourceAttribute<Union<string, IntrinsicFunction>>("DefaultDomain");
    }
}
