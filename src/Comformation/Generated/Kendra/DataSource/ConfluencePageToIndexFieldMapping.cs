using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluencePageToIndexFieldMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepagetoindexfieldmapping.html
    /// </summary>
    public class ConfluencePageToIndexFieldMapping
    {

        /// <summary>
        /// DataSourceFieldName
        /// The name of the field in the data source.
        /// Required: Yes
        /// Type: String
        /// Allowed values: AUTHOR | CONTENT_STATUS | CREATED_DATE | DISPLAY_URL | ITEM_TYPE | LABELS |
        /// MODIFIED_DATE | PARENT_ID | SPACE_KEY | SPACE_NAME | URL | VERSION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSourceFieldName")]
        public Union<string, IntrinsicFunction> DataSourceFieldName { get; set; }

        /// <summary>
        /// DateFieldFormat
        /// The format for date fields in the data source. If the field specified in DataSourceFieldName is a
        /// date field you must specify the date format. If the field is not a date field, an exception is
        /// thrown.
        /// Required: No
        /// Type: String
        /// Minimum: 4
        /// Maximum: 40
        /// Pattern: ^(?!\s). *(?&amp;lt;!\s)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateFieldFormat")]
        public Union<string, IntrinsicFunction> DateFieldFormat { get; set; }

        /// <summary>
        /// IndexFieldName
        /// The name of the index field to map to the Confluence data source field. The index field type must
        /// match the Confluence field type.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 30
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexFieldName")]
        public Union<string, IntrinsicFunction> IndexFieldName { get; set; }

    }
}
