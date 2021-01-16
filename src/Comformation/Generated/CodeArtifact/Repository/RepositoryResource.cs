using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeArtifact.Repository
{
    /// <summary>
    /// AWS::CodeArtifact::Repository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-repository.html
    /// </summary>
    public class RepositoryResource : ResourceBase
    {
        public class RepositoryProperties
        {
            /// <summary>
            /// RepositoryName
            /// The name of an upstream repository.
            /// Required: Yes
            /// Type: String
            /// Minimum: 2
            /// Maximum: 100
            /// Pattern: [A-Za-z0-9][A-Za-z0-9. _\-]{1,99}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RepositoryName { get; set; }

            /// <summary>
            /// DomainName
            /// The name of the domain that contains the repository.
            /// Required: Yes
            /// Type: String
            /// Minimum: 2
            /// Maximum: 50
            /// Pattern: [a-z][a-z0-9\-]{0,48}[a-z0-9]
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainOwner
            /// The 12-digit account number of the AWS account that owns the domain that contains the repository. It
            /// does not include dashes or spaces.
            /// Required: No
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: [0-9]{12}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainOwner { get; set; }

            /// <summary>
            /// Description
            /// A text description of the repository.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Pattern: \P{C}+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ExternalConnections
            /// An array of external connections associated with the repository.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ExternalConnections { get; set; }

            /// <summary>
            /// Upstreams
            /// A list of upstream repositories to associate with the repository. The order of the upstream
            /// repositories in the list determines their priority order when AWS CodeArtifact looks for a requested
            /// package version. For more information, see Working with upstream repositories.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Upstreams { get; set; }

            /// <summary>
            /// PermissionsPolicyDocument
            /// The document that defines the resource policy that is set on a repository.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PermissionsPolicyDocument { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to be applied to the repository.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CodeArtifact::Repository";

        public RepositoryProperties Properties { get; } = new RepositoryProperties();

    }

    public static class RepositoryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
