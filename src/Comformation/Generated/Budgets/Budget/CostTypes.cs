using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget CostTypes
    /// The types of cost that are included in a COST budget, such as tax and subscriptions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html
    /// </summary>
    public class CostTypes
    {

        /// <summary>
        /// IncludeSupport
        /// Specifies whether a budget includes support subscription fees.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSupport")]
        public Union<bool, IntrinsicFunction> IncludeSupport { get; set; }

        /// <summary>
        /// IncludeOtherSubscription
        /// Specifies whether a budget includes non-RI subscription costs.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeOtherSubscription")]
        public Union<bool, IntrinsicFunction> IncludeOtherSubscription { get; set; }

        /// <summary>
        /// IncludeTax
        /// Specifies whether a budget includes taxes.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeTax")]
        public Union<bool, IntrinsicFunction> IncludeTax { get; set; }

        /// <summary>
        /// IncludeSubscription
        /// Specifies whether a budget includes subscriptions.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSubscription")]
        public Union<bool, IntrinsicFunction> IncludeSubscription { get; set; }

        /// <summary>
        /// UseBlended
        /// Specifies whether a budget uses a blended rate.
        /// The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseBlended")]
        public Union<bool, IntrinsicFunction> UseBlended { get; set; }

        /// <summary>
        /// IncludeUpfront
        /// Specifies whether a budget includes upfront RI costs.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeUpfront")]
        public Union<bool, IntrinsicFunction> IncludeUpfront { get; set; }

        /// <summary>
        /// IncludeDiscount
        /// Specifies whether a budget includes discounts.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeDiscount")]
        public Union<bool, IntrinsicFunction> IncludeDiscount { get; set; }

        /// <summary>
        /// IncludeCredit
        /// Specifies whether a budget includes credits.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeCredit")]
        public Union<bool, IntrinsicFunction> IncludeCredit { get; set; }

        /// <summary>
        /// IncludeRecurring
        /// Specifies whether a budget includes recurring fees such as monthly RI fees.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeRecurring")]
        public Union<bool, IntrinsicFunction> IncludeRecurring { get; set; }

        /// <summary>
        /// UseAmortized
        /// Specifies whether a budget uses the amortized rate.
        /// The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseAmortized")]
        public Union<bool, IntrinsicFunction> UseAmortized { get; set; }

        /// <summary>
        /// IncludeRefund
        /// Specifies whether a budget includes refunds.
        /// The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeRefund")]
        public Union<bool, IntrinsicFunction> IncludeRefund { get; set; }

    }
}
