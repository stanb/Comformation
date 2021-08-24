using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet FilterOperation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-filteroperation.html
    /// </summary>
    public class FilterOperation
    {

        /// <summary>
        /// ConditionExpression
        /// An expression that must evaluate to a Boolean value. Rows for which the expression evaluates to true
        /// are kept in the dataset.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 4096
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public Union<string, IntrinsicFunction> ConditionExpression { get; set; }

    }
}
