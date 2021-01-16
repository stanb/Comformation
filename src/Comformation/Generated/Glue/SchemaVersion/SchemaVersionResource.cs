using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SchemaVersion
{
    /// <summary>
    /// AWS::Glue::SchemaVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversion.html
    /// </summary>
    public class SchemaVersionResource : ResourceBase
    {
        public class SchemaVersionProperties
        {
            /// <summary>
            /// Schema
            /// 	
            /// The schema that includes the schema version.
            /// Required: Yes
            /// Type: Schema
            /// Update requires: Replacement
            /// </summary>
            public Schema Schema { get; set; }

            /// <summary>
            /// SchemaDefinition
            /// 	
            /// The schema definition for the schema version.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchemaDefinition { get; set; }

        }

        public string Type { get; } = "AWS::Glue::SchemaVersion";

        public SchemaVersionProperties Properties { get; } = new SchemaVersionProperties();

    }

    public static class SchemaVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VersionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VersionId");
    }
}
