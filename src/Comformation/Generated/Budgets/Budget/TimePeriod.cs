using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget TimePeriod
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html
    /// </summary>
    public class TimePeriod
    {

        /// <summary>
        /// Start
        /// 		
        /// The start date for a budget. If you created your budget and didn&#39;t specify a start 			date, the
        /// start date defaults to the start of the chosen time period (MONTHLY, QUARTERLY, or 			ANNUALLY). For
        /// example, if you create your budget on January 24, 2019, choose 			MONTHLY, and don&#39;t set a start
        /// date, the start date defaults to 			01/01/19 00:00 UTC. The defaults are the same for the AWS
        /// Billing and Cost Management console and the API.
        /// 		
        /// You can change your start date with the UpdateBudget operation.
        /// 		
        /// Valid values depend on the value of BudgetType:
        /// 			
        /// 				 				 			 If BudgetType is COST or USAGE: Valid values are 					MONTHLY, QUARTERLY, and
        /// ANNUALLY. If BudgetType is RI_UTILIZATION or RI_COVERAGE: Valid values are 					DAILY, MONTHLY,
        /// QUARTERLY, and ANNUALLY.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Start")]
        public Union<string, IntrinsicFunction> Start { get; set; }

        /// <summary>
        /// End
        /// 		
        /// The end date for a budget. If you didn&#39;t specify an end date, AWS set your end date to 06/15/87
        /// 00:00 UTC. The defaults are the same for the AWS Billing and Cost Management console and the API.
        /// 		
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers. You can
        /// change your end date with the UpdateBudget operation.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<string, IntrinsicFunction> End { get; set; }

    }
}
