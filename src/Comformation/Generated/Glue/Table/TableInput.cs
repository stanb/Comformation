using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS Glue Table TableInput
    /// The TableInput property type specifies the metadata that's used to create or update an AWS Glue table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html
    /// </summary>
    public class TableInput
    {

        /// <summary>
        /// Owner
        /// The owner of the table. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// ViewOriginalText
        /// The original text of the view, if the table is a view. Otherwise, it's null.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewOriginalText")]
        public Union<string, IntrinsicFunction> ViewOriginalText { get; set; }

        /// <summary>
        /// Description
        /// The description of the table. It must match the URI address multi-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// TableType
        /// The type of the table, such as EXTERNAL_TABLE or VIRTUAL_VIEW.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableType")]
        public Union<string, IntrinsicFunction> TableType { get; set; }

        /// <summary>
        /// Parameters
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify the properties that are associated with
        /// the table.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// ViewExpandedText
        /// The expanded text of the view, if the table is a view. Otherwise it's null.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewExpandedText")]
        public Union<string, IntrinsicFunction> ViewExpandedText { get; set; }

        /// <summary>
        /// StorageDescriptor
        /// Information about the physical storage of the table.
        /// Required: No
        /// Type: AWS Glue Table StorageDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageDescriptor")]
        public Union<StorageDescriptor, IntrinsicFunction> StorageDescriptor { get; set; }

        /// <summary>
        /// PartitionKeys
        /// The columns in the table.
        /// Required: No
        /// Type: List of AWS Glue Table Column
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionKeys")]
        public Union<List<Column>, IntrinsicFunction> PartitionKeys { get; set; }

        /// <summary>
        /// Retention
        /// The retention time for the table.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Retention")]
        public Union<int, IntrinsicFunction> Retention { get; set; }

        /// <summary>
        /// Name
        /// The name of the table. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
