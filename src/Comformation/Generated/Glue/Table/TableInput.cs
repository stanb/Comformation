using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS::Glue::Table TableInput
    /// A structure used to define a table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html
    /// </summary>
    public class TableInput
    {

        /// <summary>
        /// Owner
        /// The table owner.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// ViewOriginalText
        /// If the table is a view, the original text of the view; otherwise null.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewOriginalText")]
        public Union<string, IntrinsicFunction> ViewOriginalText { get; set; }

        /// <summary>
        /// Description
        /// A description of the table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// TableType
        /// The type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc. ).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableType")]
        public Union<string, IntrinsicFunction> TableType { get; set; }

        /// <summary>
        /// Parameters
        /// These key-value pairs define properties associated with the table.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// ViewExpandedText
        /// If the table is a view, the expanded text of the view; otherwise null.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewExpandedText")]
        public Union<string, IntrinsicFunction> ViewExpandedText { get; set; }

        /// <summary>
        /// StorageDescriptor
        /// A storage descriptor containing information about the physical storage of this table.
        /// Required: No
        /// Type: StorageDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageDescriptor")]
        public StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>
        /// PartitionKeys
        /// A list of columns by which the table is partitioned. Only primitive types are supported as partition
        /// keys.
        /// 	
        /// When you create a table used by Amazon Athena, and you do not specify any partitionKeys, you must at
        /// least set the value of partitionKeys to an empty list. For example:
        /// &quot;PartitionKeys&quot;: []
        /// Required: No
        /// Type: List of Column
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PartitionKeys")]
        public List<Column> PartitionKeys { get; set; }

        /// <summary>
        /// Retention
        /// The retention time for this table.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Retention")]
        public Union<int, IntrinsicFunction> Retention { get; set; }

        /// <summary>
        /// Name
        /// The table name. For Hive compatibility, this is folded to lowercase when it is stored.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
