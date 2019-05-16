using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget BudgetData
    /// Represents the output of the CreateBudget operation. The content consists of the detailed metadata and data
    /// file information, and the current status of the budget object.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html
    /// </summary>
    public class BudgetData
    {

        /// <summary>
        /// BudgetLimit
        /// The total amount of cost, usage, RI utilization, or RI coverage that you want to track with your
        /// budget.
        /// BudgetLimit is required for cost or usage budgets, but optional for RI utilization or coverage
        /// budgets. RI utilization or coverage budgets default to 100, which is the only valid value for RI
        /// utilization or coverage budgets.
        /// Required: No
        /// Type: Spend
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BudgetLimit")]
        public Spend BudgetLimit { get; set; }

        /// <summary>
        /// TimePeriod
        /// 		 		 		
        /// The period of time that is covered by a budget. The period has a start date and an end 			date. The
        /// start date must come before the end date. There are no restrictions on the end date.
        /// 		
        /// The start date for a budget. If you created your budget and didn&#39;t specify a start 			date, the
        /// start date defaults to the start of the chosen time period (MONTHLY, QUARTERLY, or 			ANNUALLY). For
        /// example, if you create your budget on January 24, 2019, choose 			MONTHLY, and don&#39;t set a start
        /// date, the start date defaults to 			01/01/19 00:00 UTC. The defaults are the same for the AWS
        /// Billing and Cost 			Management console and the API.
        /// 		
        /// You can change your start date with the UpdateBudget operation.
        /// 		
        /// After the end date, AWS deletes the budget and all associated notifications and subscribers.
        /// 	
        /// Required: No
        /// Type: TimePeriod
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimePeriod")]
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// TimeUnit
        /// 		
        /// The length of time until a budget resets the actual and forecasted spend. DAILY is available only
        /// for 			RI_UTILIZATION and RI_COVERAGE budgets.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ANNUALLY | DAILY | MONTHLY | QUARTERLY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeUnit")]
        public Union<string, IntrinsicFunction> TimeUnit { get; set; }

        /// <summary>
        /// CostFilters
        /// The cost filters, such as service or region, that are applied to a budget.
        /// AWS Budgets supports the following services as a filter for RI budgets:
        /// Amazon Elastic Compute Cloud - Compute Amazon Redshift Amazon Relational Database Service Amazon
        /// ElastiCache Amazon Elasticsearch Service
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CostFilters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CostFilters { get; set; }

        /// <summary>
        /// BudgetName
        /// 		
        /// The name of a budget. The value must be unique within an account. BudgetName can&#39;t include 			: and
        /// \ characters. If you don&#39;t include value for BudgetName in the template, 			Billing and Cost
        /// Management assigns your budget a randomly generated name.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BudgetName")]
        public Union<string, IntrinsicFunction> BudgetName { get; set; }

        /// <summary>
        /// CostTypes
        /// The types of costs that are included in this COST budget.
        /// USAGE, RI_UTILIZATION, and RI_COVERAGE budgets do not have CostTypes.
        /// Required: No
        /// Type: CostTypes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CostTypes")]
        public CostTypes CostTypes { get; set; }

        /// <summary>
        /// BudgetType
        /// Whether this budget tracks monetary costs, usage, RI utilization, or RI coverage.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: COST | RI_COVERAGE | RI_UTILIZATION | USAGE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BudgetType")]
        public Union<string, IntrinsicFunction> BudgetType { get; set; }

    }
}
