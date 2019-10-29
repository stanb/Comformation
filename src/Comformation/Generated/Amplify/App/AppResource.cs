using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App
    /// The AWS::Amplify::App resource creates Apps in the Amplify Console. An App is a collection of branches.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html
    /// </summary>
    public class AppResource : ResourceBase
    {
        public class AppProperties
        {
            /// <summary>
            /// AutoBranchCreationConfig
            /// Sets the configuration for your automatic branch creation.
            /// Required: No
            /// Type: AutoBranchCreationConfig
            /// Update requires: No interruption
            /// </summary>
			public AutoBranchCreationConfig AutoBranchCreationConfig { get; set; }

            /// <summary>
            /// OauthToken
            /// OAuth token for 3rd party source control system for an Amplify App, used to create webhook and
            /// read-only deploy key. OAuth token is not stored.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> OauthToken { get; set; }

            /// <summary>
            /// Repository
            /// Repository for an Amplify App
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Repository { get; set; }

            /// <summary>
            /// Description
            /// Description for an Amplify App
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentVariables
            /// Environment variables map for an Amplify App.
            /// Required: No
            /// Type: List of EnvironmentVariable
            /// Update requires: No interruption
            /// </summary>
			public List<EnvironmentVariable> EnvironmentVariables { get; set; }

            /// <summary>
            /// AccessToken
            /// Personal Access token for 3rd party source control system for an Amplify App, used to create webhook
            /// and read-only deploy key. Token is not stored.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AccessToken { get; set; }

            /// <summary>
            /// BuildSpec
            /// BuildSpec for an Amplify App
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> BuildSpec { get; set; }

            /// <summary>
            /// CustomRules
            /// Custom rewrite / redirect rules for an Amplify App.
            /// Required: No
            /// Type: List of CustomRule
            /// Update requires: No interruption
            /// </summary>
			public List<CustomRule> CustomRules { get; set; }

            /// <summary>
            /// BasicAuthConfig
            /// Credentials for Basic Authorization for an Amplify App.
            /// Required: No
            /// Type: BasicAuthConfig
            /// Update requires: No interruption
            /// </summary>
			public BasicAuthConfig BasicAuthConfig { get; set; }

            /// <summary>
            /// Tags
            /// Tag for an Amplify App
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// Name for the Amplify App
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// IAMServiceRole
            /// IAM service role ARN for the Amplify App.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IAMServiceRole { get; set; }

        }

        public string Type { get; } = "AWS::Amplify::App";

        public AppProperties Properties { get; } = new AppProperties();

    }

	public static class AppAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DefaultDomain = new ResourceAttribute<Union<string, IntrinsicFunction>>("DefaultDomain");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppName = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppName");
	}
}
