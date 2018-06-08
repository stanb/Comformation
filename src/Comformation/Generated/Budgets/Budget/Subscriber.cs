using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS Billing and Cost Management Budget Subscriber
    /// The Subscriber property type specifies who to notify for a Billing and Cost Management budget notification.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html
    /// </summary>
    public class Subscriber
    {

        /// <summary>
        /// SubscriptionType
        /// The type of notification that AWS sends to a subscriber, such as email or SNS.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubscriptionType")]
        public Union<string, IntrinsicFunction> SubscriptionType { get; set; }

        /// <summary>
        /// Address
        /// The address that AWS sends budget notifications to, either an SNS topic or an email.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

    }
}
