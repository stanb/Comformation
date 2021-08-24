using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet CastColumnTypeOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-castcolumntypeoperation.html
    /// </summary>
    public class CastColumnTypeOperation
    {

        /// <summary>
        /// ColumnName
        /// Column name.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnName")]
        public Union<string, IntrinsicFunction> ColumnName { get; set; }

        /// <summary>
        /// Format
        /// When casting a column from string to datetime type, you can supply a string in a format supported by
        /// Amazon QuickSight to denote the source data format.
        /// Required: No
        /// Type: String
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// NewColumnType
        /// New column data type.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DATETIME | DECIMAL | INTEGER | STRING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NewColumnType")]
        public Union<string, IntrinsicFunction> NewColumnType { get; set; }

    }
}
