using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html
    /// </summary>
    public class CostTypes
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesupport
        /// </summary>
        [JsonProperty("IncludeSupport")]
        public Union<bool, IntrinsicFunction> IncludeSupport { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeothersubscription
        /// </summary>
        [JsonProperty("IncludeOtherSubscription")]
        public Union<bool, IntrinsicFunction> IncludeOtherSubscription { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includetax
        /// </summary>
        [JsonProperty("IncludeTax")]
        public Union<bool, IntrinsicFunction> IncludeTax { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesubscription
        /// </summary>
        [JsonProperty("IncludeSubscription")]
        public Union<bool, IntrinsicFunction> IncludeSubscription { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useblended
        /// </summary>
        [JsonProperty("UseBlended")]
        public Union<bool, IntrinsicFunction> UseBlended { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeupfront
        /// </summary>
        [JsonProperty("IncludeUpfront")]
        public Union<bool, IntrinsicFunction> IncludeUpfront { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includediscount
        /// </summary>
        [JsonProperty("IncludeDiscount")]
        public Union<bool, IntrinsicFunction> IncludeDiscount { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includecredit
        /// </summary>
        [JsonProperty("IncludeCredit")]
        public Union<bool, IntrinsicFunction> IncludeCredit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerecurring
        /// </summary>
        [JsonProperty("IncludeRecurring")]
        public Union<bool, IntrinsicFunction> IncludeRecurring { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useamortized
        /// </summary>
        [JsonProperty("UseAmortized")]
        public Union<bool, IntrinsicFunction> UseAmortized { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerefund
        /// </summary>
        [JsonProperty("IncludeRefund")]
        public Union<bool, IntrinsicFunction> IncludeRefund { get; set; }

    }
}
