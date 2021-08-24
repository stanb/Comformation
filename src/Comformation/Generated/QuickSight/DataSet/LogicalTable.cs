using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet LogicalTable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltable.html
    /// </summary>
    public class LogicalTable
    {

        /// <summary>
        /// Alias
        /// A display name for the logical table.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alias")]
        public Union<string, IntrinsicFunction> Alias { get; set; }

        /// <summary>
        /// DataTransforms
        /// Transform operations that act on this logical table.
        /// Required: No
        /// Type: List of TransformOperation
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataTransforms")]
        public List<TransformOperation> DataTransforms { get; set; }

        /// <summary>
        /// Source
        /// Source of this logical table.
        /// Required: Yes
        /// Type: LogicalTableSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public LogicalTableSource Source { get; set; }

    }
}
