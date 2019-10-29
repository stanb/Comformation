using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.CodeRepository
{
    /// <summary>
    /// AWS::SageMaker::CodeRepository
    /// Creates a Git repository as a resource in your Amazon SageMaker account. You can associate the repository with
    /// notebook instances so that you can use Git source control for the notebooks you create. The Git repository is
    /// a resource in your Amazon SageMaker account, so it can be associated with more than one notebook instance, and
    /// it persists independently from the lifecycle of any notebook instances it is associated with.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html
    /// </summary>
    public class CodeRepositoryResource : ResourceBase
    {
        public class CodeRepositoryProperties
        {
            /// <summary>
            /// CodeRepositoryName
            /// The name of the Git repository.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CodeRepositoryName { get; set; }

            /// <summary>
            /// GitConfig
            /// Configuration details for the Git repository, including the URL where it is located and the ARN of
            /// the AWS Secrets Manager secret that contains the credentials used to access the repository.
            /// Required: Yes
            /// Type: GitConfig
            /// Update requires: No interruption
            /// </summary>
			public GitConfig GitConfig { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::CodeRepository";

        public CodeRepositoryProperties Properties { get; } = new CodeRepositoryProperties();

    }

	public static class CodeRepositoryAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CodeRepositoryName = new ResourceAttribute<Union<string, IntrinsicFunction>>("CodeRepositoryName");
	}
}
