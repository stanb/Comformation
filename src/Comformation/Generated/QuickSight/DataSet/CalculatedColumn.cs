using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet CalculatedColumn
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-calculatedcolumn.html
    /// </summary>
    public class CalculatedColumn
    {

        /// <summary>
        /// ColumnId
        /// A unique ID to identify a calculated column. During a dataset update, if the column ID of a
        /// calculated column matches that of an existing calculated column, Amazon QuickSight preserves the
        /// existing calculated column.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnId")]
        public Union<string, IntrinsicFunction> ColumnId { get; set; }

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
        /// Expression
        /// An expression that defines the calculated column.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 4096
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

    }
}
