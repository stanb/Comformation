using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// RepositoryName
            /// The name of the new repository to be created.
            /// Note The repository name must be unique across the calling AWS account. Repository names are limited
            /// to 100 alphanumeric, dash, and underscore characters, and cannot include certain characters. For
            /// more information about the limits on repository names, see Limits in the AWS CodeCommit User Guide.
            /// The suffix . git is prohibited.
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
            /// Update requires: Some interruptions
            /// </summary>
            public List<RepositoryTrigger> Triggers { get; set; }

            /// <summary>
            /// Code
            /// Information about code to be committed to a repository after it is created in an AWS CloudFormation
            /// stack.
            /// Note You can only use this property to add code when creating a repository with a CloudFormation
            /// template at creation time. This property cannot be used for updating code to an existing repository.
            /// Required: No
            /// Type: Code
            /// Update requires: No interruption
            /// </summary>
            public Code Code { get; set; }

            /// <summary>
            /// RepositoryDescription
            /// A comment or description about the new repository.
            /// Note The description field for a repository accepts all HTML characters and all valid Unicode
            /// characters. Applications that do not HTML-encode the description and display it in a webpage can
            /// expose users to potentially malicious code. Make sure that you HTML-encode the description field in
            /// any application that uses this API to display the repository description on a webpage.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RepositoryDescription { get; set; }

            /// <summary>
            /// Tags
            /// One or more tag key-value pairs to use when tagging this repository.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

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
