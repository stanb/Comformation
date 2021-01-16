using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition StorageDescriptor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html
    /// </summary>
    public class StorageDescriptor
    {

        /// <summary>
        /// StoredAsSubDirectories
        /// True if the table data is stored in subdirectories, or False if not.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StoredAsSubDirectories")]
        public Union<bool, IntrinsicFunction> StoredAsSubDirectories { get; set; }

        /// <summary>
        /// Parameters
        /// The user-supplied properties in key-value form.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// BucketColumns
        /// A list of reducer grouping columns, clustering columns, and bucketing columns in the table.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketColumns")]
        public List<Union<string, IntrinsicFunction>> BucketColumns { get; set; }

        /// <summary>
        /// NumberOfBuckets
        /// The number of buckets.
        /// You must specify this property if the partition contains any dimension columns.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberOfBuckets")]
        public Union<int, IntrinsicFunction> NumberOfBuckets { get; set; }

        /// <summary>
        /// OutputFormat
        /// The output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom
        /// format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputFormat")]
        public Union<string, IntrinsicFunction> OutputFormat { get; set; }

        /// <summary>
        /// Columns
        /// A list of the Columns in the table.
        /// Required: No
        /// Type: List of Column
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// SerdeInfo
        /// The serialization/deserialization (SerDe) information.
        /// Required: No
        /// Type: SerdeInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SerdeInfo")]
        public SerdeInfo SerdeInfo { get; set; }

        /// <summary>
        /// SortColumns
        /// A list specifying the sort order of each bucket in the table.
        /// Required: No
        /// Type: List of Order
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SortColumns")]
        public List<Order> SortColumns { get; set; }

        /// <summary>
        /// Compressed
        /// True if the data in the table is compressed, or False if not.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Compressed")]
        public Union<bool, IntrinsicFunction> Compressed { get; set; }

        /// <summary>
        /// SchemaReference
        /// An object that references a schema stored in the AWS Glue Schema Registry.
        /// 	 	
        /// When creating a table, you can pass an empty list of columns for the schema, and instead use a
        /// schema reference.
        /// Required: No
        /// Type: SchemaReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaReference")]
        public SchemaReference SchemaReference { get; set; }

        /// <summary>
        /// SkewedInfo
        /// The information about values that appear frequently in a column (skewed values).
        /// Required: No
        /// Type: SkewedInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedInfo")]
        public SkewedInfo SkewedInfo { get; set; }

        /// <summary>
        /// InputFormat
        /// The input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputFormat")]
        public Union<string, IntrinsicFunction> InputFormat { get; set; }

        /// <summary>
        /// Location
        /// The physical location of the table. By default, this takes the form of the warehouse location,
        /// followed by the database location in the warehouse, followed by the table name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
