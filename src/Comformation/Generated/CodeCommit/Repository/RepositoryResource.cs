using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository
    /// The AWS::CodeCommit::Repository resource creates an AWS CodeCommit repository that is hosted by Amazon Web
    /// Services. For more information, see Create an AWS CodeCommit Repository in the AWS CodeCommit User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// RepositoryName
            /// A name for the AWS CodeCommit repository.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// Triggers
            /// Defines the actions to take in response to events that occur in the repository. For example, you can
            /// send email notifications when someone pushes to the repository.
            /// Required: No
            /// Type: List of AWS CodeCommit Repository Trigger
            /// Update requires: No interruption
            /// </summary>
			public List<RepositoryTrigger> Triggers { get; set; }

            /// <summary>
            /// RepositoryDescription
            /// A description about the AWS CodeCommit repository. For constraints, see the CreateRepository action
            /// in the AWS CodeCommit API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryDescription { get; set; }

        }

        public string Type { get; } = "AWS::CodeCommit::Repository";

        public RepositoryProperties Properties { get; } = new RepositoryProperties();

    }

	public static class RepositoryAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CloneUrlHttp = new ResourceAttribute<Union<string, IntrinsicFunction>>("CloneUrlHttp");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CloneUrlSsh = new ResourceAttribute<Union<string, IntrinsicFunction>>("CloneUrlSsh");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
