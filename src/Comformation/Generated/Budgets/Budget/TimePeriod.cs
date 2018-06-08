using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget TimePeriod
    /// The TimePeriod property type specifies the period of time covered by a Billing and Cost Management budget.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html
    /// </summary>
    public class TimePeriod
    {

        /// <summary>
        /// Start
        /// The start date for a budget. If you create your budget and don't specify a start date, AWS defaults
        /// to the start of your chosen time period (i. e. DAILY, MONTHLY, QUARTERLY, ANNUALLY). For example, if
        /// you create your budget on January 24th 2018, choose DAILY, and don't set a start date, AWS sets your
        /// start date to 01/24/18 00:00 UTC. If you choose MONTHLY, AWS sets your start date to 01/01/18 00:00
        /// UTC. The defaults are the same for the AWS Billing and Cost Management console and the API.
        /// You can change your start date with the UpdateBudget API operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Start")]
        public Union<string, IntrinsicFunction> Start { get; set; }

        /// <summary>
        /// End
        /// The end date for a budget. If you don't specify an end date, AWS sets your end date to 06/15/2087
        /// 00:00 UTC. The defaults are the same for the AWS Billing and Cost Management console and the API.
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<string, IntrinsicFunction> End { get; set; }

    }
}
