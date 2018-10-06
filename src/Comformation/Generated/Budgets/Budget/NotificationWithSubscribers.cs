using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget NotificationWithSubscribers
    /// The NotificationWithSubscribers property type specifies who to notify when a Billing and Cost Management
    /// budget passes or is predicted to pass its threshold.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html
    /// </summary>
    public class NotificationWithSubscribers
    {

        /// <summary>
        /// Subscribers
        /// A list of subscribers who are subscribed to this notification.
        /// Required: Yes
        /// Type: List of Billing and Cost Management Budget Subscriber
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subscribers")]
        public List<Subscriber> Subscribers { get; set; }

        /// <summary>
        /// Notification
        /// A notification associated with a budget. A budget can have up to five notifications.
        /// Each notification must have at least one subscriber. A notification can have one SNS subscriber and
        /// up to ten email subscribers, for a total of 11 subscribers.
        /// For example, if you have a budget for 200 dollars and you want to be notified when you go over 160
        /// dollars, create a notification with the following parameters:
        /// A thresholdType of PERCENTAGE A threshold of 80 A notificationType of ACTUAL A comparisonOperator of
        /// GREATER_THAN
        /// Required: Yes
        /// Type: Billing and Cost Management Budget Notification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Notification")]
        public Notification Notification { get; set; }

    }
}
