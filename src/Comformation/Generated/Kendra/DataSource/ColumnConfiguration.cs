using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ColumnConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-columnconfiguration.html
    /// </summary>
    public class ColumnConfiguration
    {

        /// <summary>
        /// DocumentIdColumnName
        /// The column that provides the document&#39;s unique identifier.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentIdColumnName")]
        public Union<string, IntrinsicFunction> DocumentIdColumnName { get; set; }

        /// <summary>
        /// DocumentDataColumnName
        /// The column that contains the contents of the document.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentDataColumnName")]
        public Union<string, IntrinsicFunction> DocumentDataColumnName { get; set; }

        /// <summary>
        /// DocumentTitleColumnName
        /// The column that contains the title of the document.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentTitleColumnName")]
        public Union<string, IntrinsicFunction> DocumentTitleColumnName { get; set; }

        /// <summary>
        /// FieldMappings
        /// An array of objects that map database column names to the corresponding fields in an index. You must
        /// first create the fields in the index using the UpdateIndex operation.
        /// Required: No
        /// Type: DataSourceToIndexFieldMappingList
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

        /// <summary>
        /// ChangeDetectingColumns
        /// One to five columns that indicate when a document in the database has changed.
        /// Required: Yes
        /// Type: ChangeDetectingColumns
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChangeDetectingColumns")]
        public ChangeDetectingColumns ChangeDetectingColumns { get; set; }

    }
}
