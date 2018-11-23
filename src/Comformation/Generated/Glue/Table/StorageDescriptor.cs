using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS Glue Table StorageDescriptor
    /// The StorageDescriptor property type describes the physical storage of AWS Glue table data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html
    /// </summary>
    public class StorageDescriptor
    {

        /// <summary>
        /// StoredAsSubDirectories
        /// Indicates whether the table data is stored in subdirectories.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StoredAsSubDirectories")]
        public Union<bool, IntrinsicFunction> StoredAsSubDirectories { get; set; }

        /// <summary>
        /// Parameters
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify user-supplied properties.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// BucketColumns
        /// A list of UTF-8 strings that specify reducer grouping columns, clustering columns, and bucketing
        /// columns in the table.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketColumns")]
        public List<Union<string, IntrinsicFunction>> BucketColumns { get; set; }

        /// <summary>
        /// SkewedInfo
        /// Information about values that appear very frequently in a column (skewed values).
        /// Required: No
        /// Type: SkewedInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SkewedInfo")]
        public SkewedInfo SkewedInfo { get; set; }

        /// <summary>
        /// InputFormat
        /// The input format: SequenceFileInputFormat (binary), TextInputFormat, or a custom format. It must
        /// match the single-line string pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputFormat")]
        public Union<string, IntrinsicFunction> InputFormat { get; set; }

        /// <summary>
        /// NumberOfBuckets
        /// The number of buckets.
        /// Required: Conditional. You must specify this property if the table contains any dimension columns.
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumberOfBuckets")]
        public Union<int, IntrinsicFunction> NumberOfBuckets { get; set; }

        /// <summary>
        /// OutputFormat
        /// The output format: SequenceFileOutputFormat (binary), IgnoreKeyTextOutputFormat, or a custom format.
        /// It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputFormat")]
        public Union<string, IntrinsicFunction> OutputFormat { get; set; }

        /// <summary>
        /// Columns
        /// The columns in the table.
        /// Required: No
        /// Type: List of Column
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// SerdeInfo
        /// Information about a serialization/deserialization program (SerDe), which serves as an extractor and
        /// loader.
        /// Required: No
        /// Type: SerdeInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SerdeInfo")]
        public SerdeInfo SerdeInfo { get; set; }

        /// <summary>
        /// SortColumns
        /// The sort order of each bucket in the table.
        /// Required: No
        /// Type: List of Order
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SortColumns")]
        public List<Order> SortColumns { get; set; }

        /// <summary>
        /// Compressed
        /// Indicates whether the data in the table is compressed.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Compressed")]
        public Union<bool, IntrinsicFunction> Compressed { get; set; }

        /// <summary>
        /// Location
        /// The physical location of the table. By default, this takes the form of the warehouse location,
        /// followed by the database location in the warehouse, followed by the table name. It must match the
        /// URI address multi-line string pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
