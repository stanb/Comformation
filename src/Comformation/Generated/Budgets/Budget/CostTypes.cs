using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget CostTypes
    /// The CostTypes property type specifies what costs, such as tax or subscriptions, are included in a Billing and
    /// Cost Management budget.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html
    /// </summary>
    public class CostTypes
    {

        /// <summary>
        /// IncludeSupport
        /// Specifies whether a budget includes support subscription fees.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSupport")]
        public Union<bool, IntrinsicFunction> IncludeSupport { get; set; }

        /// <summary>
        /// IncludeOtherSubscription
        /// Specifies whether a budget includes non-RI subscription costs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeOtherSubscription")]
        public Union<bool, IntrinsicFunction> IncludeOtherSubscription { get; set; }

        /// <summary>
        /// IncludeTax
        /// Specifies whether a budget includes taxes.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeTax")]
        public Union<bool, IntrinsicFunction> IncludeTax { get; set; }

        /// <summary>
        /// IncludeSubscription
        /// Specifies whether a budget includes subscriptions.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSubscription")]
        public Union<bool, IntrinsicFunction> IncludeSubscription { get; set; }

        /// <summary>
        /// UseBlended
        /// Specifies whether a budget uses blended rate.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseBlended")]
        public Union<bool, IntrinsicFunction> UseBlended { get; set; }

        /// <summary>
        /// IncludeUpfront
        /// Specifies whether a budget includes upfront RI costs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeUpfront")]
        public Union<bool, IntrinsicFunction> IncludeUpfront { get; set; }

        /// <summary>
        /// IncludeDiscount
        /// Specifies whether a budget includes discounts.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeDiscount")]
        public Union<bool, IntrinsicFunction> IncludeDiscount { get; set; }

        /// <summary>
        /// IncludeCredit
        /// Specifies whether a budget includes credits.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeCredit")]
        public Union<bool, IntrinsicFunction> IncludeCredit { get; set; }

        /// <summary>
        /// IncludeRecurring
        /// Specifies whether a budget includes recurring fees such as monthly RI fees.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeRecurring")]
        public Union<bool, IntrinsicFunction> IncludeRecurring { get; set; }

        /// <summary>
        /// UseAmortized
        /// Specifies whether a budget uses the amortized rate.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseAmortized")]
        public Union<bool, IntrinsicFunction> UseAmortized { get; set; }

        /// <summary>
        /// IncludeRefund
        /// Specifies whether a budget includes refunds.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeRefund")]
        public Union<bool, IntrinsicFunction> IncludeRefund { get; set; }

    }
}
