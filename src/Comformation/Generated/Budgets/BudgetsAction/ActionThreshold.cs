using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.BudgetsAction
{
    /// <summary>
    /// AWS::Budgets::BudgetsAction ActionThreshold
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budgetsaction-actionthreshold.html
    /// </summary>
    public class ActionThreshold
    {

        /// <summary>
        /// Value
        /// The threshold of a notification.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Type
        /// The type of threshold for a notification.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ABSOLUTE_VALUE | PERCENTAGE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
