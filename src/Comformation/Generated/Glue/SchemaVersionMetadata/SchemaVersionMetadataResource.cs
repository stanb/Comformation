using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SchemaVersionMetadata
{
    /// <summary>
    /// AWS::Glue::SchemaVersionMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversionmetadata.html
    /// </summary>
    public class SchemaVersionMetadataResource : ResourceBase
    {
        public class SchemaVersionMetadataProperties
        {
            /// <summary>
            /// SchemaVersionId
            /// 	
            /// The version number of the schema.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchemaVersionId { get; set; }

            /// <summary>
            /// Key
            /// 	
            /// A metadata key in a key-value pair for metadata.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Key { get; set; }

            /// <summary>
            /// Value
            /// 	
            /// A metadata key&#39;s corresponding value.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Value { get; set; }

        }

        public string Type { get; } = "AWS::Glue::SchemaVersionMetadata";

        public SchemaVersionMetadataProperties Properties { get; } = new SchemaVersionMetadataProperties();

    }
}
