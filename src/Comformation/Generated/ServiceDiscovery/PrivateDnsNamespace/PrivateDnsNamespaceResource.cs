using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.PrivateDnsNamespace
{
    /// <summary>
    /// AWS::ServiceDiscovery::PrivateDnsNamespace
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-privatednsnamespace.html
    /// </summary>
    public class PrivateDnsNamespaceResource : ResourceBase
    {
        public class PrivateDnsNamespaceProperties
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
            /// Vpc
            /// The ID of the Amazon VPC that you want to associate the namespace with.
            /// Required: Yes
            /// Type: String
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Vpc { get; set; }

            /// <summary>
            /// Properties
            /// Properties for the private DNS namespace.
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
            /// The name that you want to assign to this namespace. When you create a private DNS namespace, AWS
            /// Cloud Map automatically creates an Amazon Route 53 private hosted zone that has the same name as the
            /// namespace.
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Pattern: ^[!-~]{1,1024}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ServiceDiscovery::PrivateDnsNamespace";

        public PrivateDnsNamespaceProperties Properties { get; } = new PrivateDnsNamespaceProperties();

    }

    public static class PrivateDnsNamespaceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
