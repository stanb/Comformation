using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EventSchemas.Schema
{
    /// <summary>
    /// AWS::EventSchemas::Schema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html
    /// </summary>
    public class SchemaResource : ResourceBase
    {
        public class SchemaProperties
        {
            /// <summary>
            /// Type
            /// The type of schema.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// A description of the schema.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Content
            /// The source of the schema definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// RegistryName
            /// The name of the schema registry.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RegistryName { get; set; }

            /// <summary>
            /// SchemaName
            /// The name of the schema.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchemaName { get; set; }

            /// <summary>
            /// Tags
            /// Tags associated with the schema.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
            public List<TagsEntry> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EventSchemas::Schema";

        public SchemaProperties Properties { get; } = new SchemaProperties();

    }

    public static class SchemaAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SchemaVersion = new ResourceAttribute<Union<string, IntrinsicFunction>>("SchemaVersion");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SchemaArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SchemaArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SchemaName = new ResourceAttribute<Union<string, IntrinsicFunction>>("SchemaName");
    }
}
