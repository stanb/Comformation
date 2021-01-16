using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget Spend
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html
    /// </summary>
    public class Spend
    {

        /// <summary>
        /// Amount
        /// 		
        /// The cost or usage amount that is associated with a budget forecast, actual spend, or budget
        /// threshold.
        /// 	
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Amount")]
        public Union<double, IntrinsicFunction> Amount { get; set; }

        /// <summary>
        /// Unit
        /// 		
        /// The unit of measurement that is used for the budget forecast, actual spend, or budget threshold,
        /// such as USD or GB.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
