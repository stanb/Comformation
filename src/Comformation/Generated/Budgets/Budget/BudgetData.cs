using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget BudgetData
    /// The BudgetData property type specifies all of the parameters that AWS CloudFormation uses to create the
    /// budget. These parameters include the time period that the budget covers, the amount that the budget is for,
    /// the name of the budget, what costs, usage, or RI utilization the Billing and Cost Management budget is for,
    /// and whether the budget tracks what you have spent or what you are forecast to spend.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html
    /// </summary>
    public class BudgetData
    {

        /// <summary>
        /// BudgetLimit
        /// The total amount of cost, usage, or RI utilization that you want to track with your budget.
        /// The BudgetLimit is required for cost or usage budgets, but optional for RI utilization budgets. RI
        /// utilization budgets default to the only valid value for RI utilization budgets, which is 100.
        /// Required: No
        /// Type: Billing and Cost Management Budget Spend
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BudgetLimit")]
        public Union<Spend, IntrinsicFunction> BudgetLimit { get; set; }

        /// <summary>
        /// TimePeriod
        /// The period of time covered by a budget. Has a start date and an end date. The start date must come
        /// before the end date. There are no restrictions on the end date.
        /// If you create your budget and don&#39;t specify a start date, AWS defaults to the start of your chosen
        /// time period (i. e. DAILY, MONTHLY, QUARTERLY, ANNUALLY). For example, if you create your budget on
        /// January 24th 2018, choose DAILY, and don&#39;t set a start date, AWS sets your start date to 01/24/18
        /// 00:00 UTC. If you choose MONTHLY, AWS sets your start date to 01/01/18 00:00 UTC. If you don&#39;t
        /// specify an end date, AWS sets your end date to 06/15/87 00:00 UTC.
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers.
        /// Required: No
        /// Type: Billing and Cost Management Budget TimePeriod
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimePeriod")]
        public Union<TimePeriod, IntrinsicFunction> TimePeriod { get; set; }

        /// <summary>
        /// TimeUnit
        /// The length of time until a budget resets the actual and forecasted spend to zero.
        /// Valid values are: DAILY, MONTHLY, QUARTERLY, and ANNUALLY.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeUnit")]
        public Union<string, IntrinsicFunction> TimeUnit { get; set; }

        /// <summary>
        /// CostFilters
        /// The cost filters applied to a budget, such as service or region.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CostFilters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CostFilters { get; set; }

        /// <summary>
        /// BudgetName
        /// The name of a budget. Unique within accounts. : and \ characters are not allowed in the BudgetName.
        /// If you do not include a BudgetName in the template, Billing and Cost Management assigns your budget
        /// a randomly generated name.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BudgetName")]
        public Union<string, IntrinsicFunction> BudgetName { get; set; }

        /// <summary>
        /// CostTypes
        /// The types of costs included in this budget, such as credits, subscriptions, or taxes.
        /// Required: No
        /// Type: Billing and Cost Management Budget CostTypes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CostTypes")]
        public Union<CostTypes, IntrinsicFunction> CostTypes { get; set; }

        /// <summary>
        /// BudgetType
        /// Whether this budget tracks monetary costs, usage, or RI utilization.
        /// Valid values are USAGE, COST, RI_UTILIZATION, and RI_COVERAGE.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BudgetType")]
        public Union<string, IntrinsicFunction> BudgetType { get; set; }

    }
}
