using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet JoinInstruction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-joininstruction.html
    /// </summary>
    public class JoinInstruction
    {

        /// <summary>
        /// OnClause
        /// The join instructions provided in the ON clause of a join.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnClause")]
        public Union<string, IntrinsicFunction> OnClause { get; set; }

        /// <summary>
        /// Type
        /// The type of join that it is.
        /// Required: Yes
        /// Type: String
        /// Allowed values: INNER | LEFT | OUTER | RIGHT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// LeftJoinKeyProperties
        /// Join key properties of the left operand.
        /// Required: No
        /// Type: JoinKeyProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LeftJoinKeyProperties")]
        public JoinKeyProperties LeftJoinKeyProperties { get; set; }

        /// <summary>
        /// LeftOperand
        /// The operand on the left side of a join.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: [0-9a-zA-Z-]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LeftOperand")]
        public Union<string, IntrinsicFunction> LeftOperand { get; set; }

        /// <summary>
        /// RightOperand
        /// The operand on the right side of a join.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: [0-9a-zA-Z-]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RightOperand")]
        public Union<string, IntrinsicFunction> RightOperand { get; set; }

        /// <summary>
        /// RightJoinKeyProperties
        /// Join key properties of the right operand.
        /// Required: No
        /// Type: JoinKeyProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RightJoinKeyProperties")]
        public JoinKeyProperties RightJoinKeyProperties { get; set; }

    }
}
