using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe ConditionExpression
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-conditionexpression.html
    /// </summary>
    public class ConditionExpression
    {

        /// <summary>
        /// Condition
        /// A specific condition to apply to a recipe action. For more information, see Recipe structure in the
        /// AWS Glue DataBrew Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[A-Z\_]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

        /// <summary>
        /// Value
        /// A value that the condition must evaluate to for the condition to succeed.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// TargetColumn
        /// A column to apply this condition to.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetColumn")]
        public Union<string, IntrinsicFunction> TargetColumn { get; set; }

    }
}
