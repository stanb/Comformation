using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EventSchemas.Registry
{
    /// <summary>
    /// AWS::EventSchemas::Registry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-registry.html
    /// </summary>
    public class RegistryResource : ResourceBase
    {
        public class RegistryProperties
        {
            /// <summary>
            /// Description
            /// A description of the registry to be created.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// RegistryName
            /// The name of the schema registry.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RegistryName { get; set; }

            /// <summary>
            /// Tags
            /// Tags to associate with the registry.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
            public List<TagsEntry> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EventSchemas::Registry";

        public RegistryProperties Properties { get; } = new RegistryProperties();

    }

    public static class RegistryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegistryName = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegistryName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegistryArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegistryArn");
    }
}
