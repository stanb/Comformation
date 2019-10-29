using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStar.GitHubRepository
{
    /// <summary>
    /// AWS::CodeStar::GitHubRepository
    /// The AWS::CodeStar::GitHubRepository resource creates a GitHub repository where users can store source code for
    /// use with AWS workflows. You must provide a location for the source code ZIP file in the AWS CloudFormation
    /// template, so the code can be uploaded to the created repository. You must have created a personal access token
    /// in GitHub to provide in the AWS CloudFormation template. AWS uses this token to connect to GitHub on your
    /// behalf. For more information about using a GitHub source repository with AWS CodeStar projects, see AWS
    /// CodeStar Project Files and Resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestar-githubrepository.html
    /// </summary>
    public class GitHubRepositoryResource : ResourceBase
    {
        public class GitHubRepositoryProperties
        {
            /// <summary>
            /// EnableIssues
            /// Indicates whether to enable issues for the GitHub repository. You can use GitHub issues to track
            /// information and bugs for your repository.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableIssues { get; set; }

            /// <summary>
            /// RepositoryName
            /// The name of the repository you want to create in GitHub with AWS CloudFormation stack creation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// RepositoryAccessToken
            /// The GitHub user&#39;s personal access token for the GitHub repository.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryAccessToken { get; set; }

            /// <summary>
            /// RepositoryOwner
            /// The GitHub user name for the owner of the GitHub repository to be created. If this repository should
            /// be owned by a GitHub organization, provide its name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryOwner { get; set; }

            /// <summary>
            /// IsPrivate
            /// Indicates whether the GitHub repository is a private repository. If so, you choose who can see and
            /// commit to this repository.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<bool, IntrinsicFunction> IsPrivate { get; set; }

            /// <summary>
            /// Code
            /// Information about code to be committed to a repository after it is created in an AWS CloudFormation
            /// stack.
            /// Required: No
            /// Type: Code
            /// Update requires: Updates are not supported.
            /// </summary>
			public Code Code { get; set; }

            /// <summary>
            /// RepositoryDescription
            /// A comment or description about the new repository. This description is displayed in GitHub after the
            /// repository is created.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryDescription { get; set; }

        }

        public string Type { get; } = "AWS::CodeStar::GitHubRepository";

        public GitHubRepositoryProperties Properties { get; } = new GitHubRepositoryProperties();

    }
}
