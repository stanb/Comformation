using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Branch
{
    /// <summary>
    /// AWS::Amplify::Branch
    /// The AWS::Amplify::Branch resource creates a new branch within an app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html
    /// </summary>
    public class BranchResource : ResourceBase
    {
        public class BranchProperties
        {
            /// <summary>
            /// Description
            /// Description for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentVariables
            /// Environment Variables for the branch.
            /// Required: No
            /// Type: List of EnvironmentVariable
            /// Update requires: No interruption
            /// </summary>
			public List<EnvironmentVariable> EnvironmentVariables { get; set; }

            /// <summary>
            /// AppId
            /// Unique Id for an Amplify App.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AppId { get; set; }

            /// <summary>
            /// EnableAutoBuild
            /// Enables auto building for the branch.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableAutoBuild { get; set; }

            /// <summary>
            /// BuildSpec
            /// BuildSpec for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> BuildSpec { get; set; }

            /// <summary>
            /// Stage
            /// Stage for the branch.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Stage { get; set; }

            /// <summary>
            /// BranchName
            /// Name for the branch.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BranchName { get; set; }

            /// <summary>
            /// BasicAuthConfig
            /// Basic Authorization credentials for a branch, part of an Amplify App.
            /// Required: No
            /// Type: BasicAuthConfig
            /// Update requires: No interruption
            /// </summary>
			public BasicAuthConfig BasicAuthConfig { get; set; }

            /// <summary>
            /// Tags
            /// Tag for the branch.
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
