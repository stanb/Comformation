using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.SubscriptionDefinition
{
    /// <summary>
    /// AWS IoT Greengrass SubscriptionDefinition SubscriptionDefinitionVersion
    /// 		A subscription definition version contains a list of subscriptions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscriptiondefinitionversion.html
    /// </summary>
    public class SubscriptionDefinitionVersion
    {

        /// <summary>
        /// Subscriptions
        /// The subscriptions in this version.
        /// Required: Yes
        /// Type: List of Subscription
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subscriptions")]
        public List<Subscription> Subscriptions { get; set; }

    }
}
