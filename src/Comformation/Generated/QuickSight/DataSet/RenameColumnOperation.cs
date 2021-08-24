using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet RenameColumnOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-renamecolumnoperation.html
    /// </summary>
    public class RenameColumnOperation
    {

        /// <summary>
        /// NewColumnName
        /// The new name for the column.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NewColumnName")]
        public Union<string, IntrinsicFunction> NewColumnName { get; set; }

        /// <summary>
        /// ColumnName
        /// The name of the column to be renamed.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnName")]
        public Union<string, IntrinsicFunction> ColumnName { get; set; }

    }
}
