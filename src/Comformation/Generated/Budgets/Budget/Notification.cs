using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget Notification
    /// A notification that is associated with a budget. A budget can have up to five notifications.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html
    /// </summary>
    public class Notification
    {

        /// <summary>
        /// ComparisonOperator
        /// The comparison that is used for this notification.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: EQUAL_TO | GREATER_THAN | LESS_THAN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// NotificationType
        /// Whether the notification is for how much you have spent (ACTUAL) or for how much you&#39;re forecasted
        /// to spend (FORECASTED).
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ACTUAL | FORECASTED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationType")]
        public Union<string, IntrinsicFunction> NotificationType { get; set; }

        /// <summary>
        /// Threshold
        /// The threshold that is associated with a notification. Thresholds are always a percentage.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<double, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        /// ThresholdType
        /// The type of threshold for a notification. For ABSOLUTE_VALUE thresholds, AWS notifies you when you
        /// go over or are forecasted to go over your total cost threshold. For PERCENTAGE thresholds, AWS
        /// notifies you when you go over or are forecasted to go over a certain percentage of your forecasted
        /// spend. For example, if you have a budget for 200 dollars and you have a PERCENTAGE threshold of 80%,
        /// AWS notifies you when you go over 160 dollars.
        /// Required: No
        /// Type: String
        /// Allowed Values: ABSOLUTE_VALUE | PERCENTAGE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThresholdType")]
        public Union<string, IntrinsicFunction> ThresholdType { get; set; }

    }
}
