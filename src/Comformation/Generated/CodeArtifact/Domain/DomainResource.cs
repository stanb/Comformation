using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeArtifact.Domain
{
    /// <summary>
    /// AWS::CodeArtifact::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeartifact-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// DomainName
            /// A string that specifies the name of the requested domain.
            /// Required: Yes
            /// Type: String
            /// Minimum: 2
            /// Maximum: 50
            /// Pattern: [a-z][a-z0-9\-]{0,48}[a-z0-9]
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// EncryptionKey
            /// The key used to encrypt the domain.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1011
            /// Pattern: \S+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EncryptionKey { get; set; }

            /// <summary>
            /// PermissionsPolicyDocument
            /// The document that defines the resource policy that is set on a domain.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PermissionsPolicyDocument { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to be applied to the domain.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CodeArtifact::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

    public static class DomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Owner = new ResourceAttribute<Union<string, IntrinsicFunction>>("Owner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EncryptionKey = new ResourceAttribute<Union<string, IntrinsicFunction>>("EncryptionKey");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
