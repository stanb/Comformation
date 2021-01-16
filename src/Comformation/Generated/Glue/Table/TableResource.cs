using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS::Glue::Table
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// TableInput
            /// A structure used to define a table.
            /// Required: Yes
            /// Type: TableInput
            /// Update requires: No interruption
            /// </summary>
            public TableInput TableInput { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the database where the table metadata resides. For Hive compatibility, this must be all
            /// lowercase.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// CatalogId
            /// The ID of the Data Catalog in which to create the Table. If none is supplied, the AWS account ID is
            /// used by default.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Table";

        public TableProperties Properties { get; } = new TableProperties();

    }
}
