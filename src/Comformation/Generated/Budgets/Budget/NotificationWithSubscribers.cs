using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget NotificationWithSubscribers
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html
    /// </summary>
    public class NotificationWithSubscribers
    {

        /// <summary>
        /// Subscribers
        /// 		
        /// A list of subscribers who are subscribed to this notification.
        /// 	
        /// Required: Yes
        /// Type: List of Subscriber
        /// Maximum: 11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subscribers")]
        public List<Subscriber> Subscribers { get; set; }

        /// <summary>
        /// Notification
        /// 		
        /// The notification that is associated with a budget.
        /// 	
        /// Required: Yes
        /// Type: Notification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Notification")]
        public Notification Notification { get; set; }

    }
}
