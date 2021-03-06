using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Budgets.Budget
{
    /// <summary>
    /// AWS::Budgets::Budget Subscriber
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html
    /// </summary>
    public class Subscriber
    {

        /// <summary>
        /// SubscriptionType
        /// 		
        /// The type of notification that AWS sends to a subscriber.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: EMAIL | SNS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubscriptionType")]
        public Union<string, IntrinsicFunction> SubscriptionType { get; set; }

        /// <summary>
        /// Address
        /// 		
        /// The address that AWS sends budget notifications to, either an SNS topic or an email.
        /// 		
        /// When you create a subscriber, the value of Address can&#39;t contain line breaks.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

    }
}
