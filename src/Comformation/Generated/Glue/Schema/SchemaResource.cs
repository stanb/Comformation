using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Schema
{
    /// <summary>
    /// AWS::Glue::Schema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html
    /// </summary>
    public class SchemaResource : ResourceBase
    {
        public class SchemaProperties
        {
            /// <summary>
            /// Registry
            /// 	
            /// The registry where a schema is stored.
            /// Required: No
            /// Type: Registry
            /// Update requires: Replacement
            /// </summary>
            public Registry Registry { get; set; }

            /// <summary>
            /// Name
            /// 	
            /// Name of the schema to be created of max length of 255, and may only contain letters, numbers,
            /// hyphen, underscore, dollar sign, or hash mark. No whitespace.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// 	
            /// A description of the schema if specified when created.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DataFormat
            /// 	
            /// The data format of the schema definition. Currently only AVRO is supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DataFormat { get; set; }

            /// <summary>
            /// Compatibility
            /// 	
            /// The compatibility mode of the schema.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Compatibility { get; set; }

            /// <summary>
            /// SchemaDefinition
            /// 	
            /// The schema definition using the DataFormat setting for SchemaName.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchemaDefinition { get; set; }

            /// <summary>
            /// CheckpointVersion
            /// 	
            /// Specify the VersionNumber or the IsLatest for setting the checkpoint for the schema. This is only
            /// required for updating a checkpoint.
            /// Required: No
            /// Type: SchemaVersion
            /// Update requires: No interruption
            /// </summary>
            public SchemaVersion CheckpointVersion { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// AWS tags that contain a key value pair and may be searched by console, command line, or API.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Schema";

        public SchemaProperties Properties { get; } = new SchemaProperties();

    }

    public static class SchemaAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> InitialSchemaVersionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("InitialSchemaVersionId");
    }
}
