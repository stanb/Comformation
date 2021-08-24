using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe RecipeStep
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipestep.html
    /// </summary>
    public class RecipeStep
    {

        /// <summary>
        /// Action
        /// The particular action to be performed in the recipe step.
        /// Required: Yes
        /// Type: Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Action Action { get; set; }

        /// <summary>
        /// ConditionExpressions
        /// One or more conditions that must be met for the recipe step to succeed.
        /// Note All of the conditions in the array must be met. In other words, all of the conditions must be
        /// combined using a logical AND operation.
        /// Required: No
        /// Type: List of ConditionExpression
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConditionExpressions")]
        public List<ConditionExpression> ConditionExpressions { get; set; }

    }
}
