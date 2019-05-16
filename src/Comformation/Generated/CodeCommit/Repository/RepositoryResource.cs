using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository
    /// Creates a new, empty repository.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// RepositoryName
            /// The name of the new repository to be created.
            /// Note The repository name must be unique across the calling AWS account. In addition, repository
            /// names are limited to 100 alphanumeric, dash, and underscore characters, and cannot include certain
            /// characters. For a full description of the limits on repository names, see Limits in the AWS
            /// CodeCommit User Guide. The suffix &quot;. git&quot; is prohibited.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [\w\. -]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// Triggers
            /// The JSON block of configuration information for each trigger.
            /// Required: No
            /// Type: List of RepositoryTrigger
            /// </summary>
			public List<RepositoryTrigger> Triggers { get; set; }

            /// <summary>
            /// RepositoryDescription
            /// A comment or description about the new repository.
            /// Note The description field for a repository accepts all HTML characters and all valid Unicode
            /// characters. Applications that do not HTML-encode the description and display it in a web page could
            /// expose users to potentially malicious code. Make sure that you HTML-encode the description field in
            /// any application that uses this API to display the repository description on a web page.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
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
