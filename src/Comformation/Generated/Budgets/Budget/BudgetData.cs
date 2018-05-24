using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html
    /// </summary>
    public class BudgetData
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetlimit
        /// </summary>
        [JsonProperty("BudgetLimit")]
        public Union<Spend, IntrinsicFunction> BudgetLimit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeperiod
        /// </summary>
        [JsonProperty("TimePeriod")]
        public Union<TimePeriod, IntrinsicFunction> TimePeriod { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeunit
        /// </summary>
        [JsonProperty("TimeUnit")]
        public Union<string, IntrinsicFunction> TimeUnit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costfilters
        /// </summary>
        [JsonProperty("CostFilters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CostFilters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetname
        /// </summary>
        [JsonProperty("BudgetName")]
        public Union<string, IntrinsicFunction> BudgetName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costtypes
        /// </summary>
        [JsonProperty("CostTypes")]
        public Union<CostTypes, IntrinsicFunction> CostTypes { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgettype
        /// </summary>
        [JsonProperty("BudgetType")]
        public Union<string, IntrinsicFunction> BudgetType { get; set; }

    }
}
