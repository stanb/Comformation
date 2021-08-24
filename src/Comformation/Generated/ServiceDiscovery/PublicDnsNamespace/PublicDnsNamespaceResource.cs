using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PublicDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PublicDnsNamespace
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-publicdnsnamespace.html
    /// </summary>
    public class PublicDnsNamespaceResource : ResourceBase
    {
        public class PublicDnsNamespaceProperties
        {
            /// <summary>
            /// Description
            /// A description for the namespace.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Properties
            /// Properties for the public DNS namespace.
            /// Required: No
            /// Type: Properties
            /// Update requires: No interruption
            /// </summary>
            public Properties Properties { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the namespace. Each tag consists of a key and an optional value, both of which you
            /// define. Tag keys can have a maximum character length of 128 characters, and tag values can have a
            /// maximum length of 256 characters.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: Updates are not supported.
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name that you want to assign to this namespace.
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Pattern: ^([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.
            /// )+[a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::PublicDnsNamespace";

        public PublicDnsNamespaceProperties Properties { get; } = new PublicDnsNamespaceProperties();

    }

    public static class PublicDnsNamespaceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
