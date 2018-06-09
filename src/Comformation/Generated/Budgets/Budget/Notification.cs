using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget Notification
    /// The Notification property type specifies who to notify for a Billing and Cost Management budget.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html
    /// </summary>
    public class Notification
    {

        /// <summary>
        /// ComparisonOperator
        /// The comparison used for this notification. Valid Values are GREATER_THAN, LESS_THAN, and EQUAL_TO.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// NotificationType
        /// Whether the notification is for how much you have spent or for how much you are forecasted to spend.
        /// For ACTUAL thresholds, AWS notifies you when you go over the threshold, and for FORECASTED
        /// thresholds AWS notifies you when you are forecasted to go over the threshold. Valid values are
        /// ACTUAL and FORECASTED.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NotificationType")]
        public Union<string, IntrinsicFunction> NotificationType { get; set; }

        /// <summary>
        /// Threshold
        /// The threshold associated with a notification. The minimum valid value is 0. 1, and the maximum valid
        /// value is 1000000000.
        /// Required: Yes
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<double, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        /// ThresholdType
        /// The type of threshold for a notification. Valid values are PERCENTAGE and ABSOLUTE_VALUE.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ThresholdType")]
        public Union<string, IntrinsicFunction> ThresholdType { get; set; }

    }
}
