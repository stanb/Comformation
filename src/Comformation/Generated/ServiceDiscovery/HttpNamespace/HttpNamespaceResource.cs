using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.HttpNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::HttpNamespace
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-httpnamespace.html
    /// </summary>
    public class HttpNamespaceResource : ResourceBase
    {
        public class HttpNamespaceProperties
        {
            /// <summary>
            /// Description
            /// A description for the namespace.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

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
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::HttpNamespace";

        public HttpNamespaceProperties Properties { get; } = new HttpNamespaceProperties();

    }

    public static class HttpNamespaceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
