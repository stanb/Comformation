using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet LogicalTableSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-logicaltablesource.html
    /// </summary>
    public class LogicalTableSource
    {

        /// <summary>
        /// PhysicalTableId
        /// Physical table ID.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: [0-9a-zA-Z-]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhysicalTableId")]
        public Union<string, IntrinsicFunction> PhysicalTableId { get; set; }

        /// <summary>
        /// JoinInstruction
        /// Specifies the result of a join of two logical tables.
        /// Required: No
        /// Type: JoinInstruction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JoinInstruction")]
        public JoinInstruction JoinInstruction { get; set; }

    }
}
