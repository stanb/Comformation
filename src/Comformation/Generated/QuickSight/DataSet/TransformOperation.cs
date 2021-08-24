using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet TransformOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-transformoperation.html
    /// </summary>
    public class TransformOperation
    {

        /// <summary>
        /// TagColumnOperation
        /// An operation that tags a column with additional information.
        /// Required: No
        /// Type: TagColumnOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagColumnOperation")]
        public TagColumnOperation TagColumnOperation { get; set; }

        /// <summary>
        /// FilterOperation
        /// An operation that filters rows based on some condition.
        /// Required: No
        /// Type: FilterOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterOperation")]
        public FilterOperation FilterOperation { get; set; }

        /// <summary>
        /// CastColumnTypeOperation
        /// A transform operation that casts a column to a different type.
        /// Required: No
        /// Type: CastColumnTypeOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CastColumnTypeOperation")]
        public CastColumnTypeOperation CastColumnTypeOperation { get; set; }

        /// <summary>
        /// CreateColumnsOperation
        /// An operation that creates calculated columns. Columns created in one such operation form a lexical
        /// closure.
        /// Required: No
        /// Type: CreateColumnsOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreateColumnsOperation")]
        public CreateColumnsOperation CreateColumnsOperation { get; set; }

        /// <summary>
        /// RenameColumnOperation
        /// An operation that renames a column.
        /// Required: No
        /// Type: RenameColumnOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RenameColumnOperation")]
        public RenameColumnOperation RenameColumnOperation { get; set; }

        /// <summary>
        /// ProjectOperation
        /// An operation that projects columns. Operations that come after a projection can only refer to
        /// projected columns.
        /// Required: No
        /// Type: ProjectOperation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProjectOperation")]
        public ProjectOperation ProjectOperation { get; set; }

    }
}
