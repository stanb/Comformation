using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.SubscriptionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::SubscriptionDefinitionVersion
    /// The AWS::Greengrass::SubscriptionDefinitionVersion resource represents a subscription definition version for
    /// AWS IoT Greengrass. A subscription definition version contains a list of subscriptions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinitionversion.html
    /// </summary>
    public class SubscriptionDefinitionVersionResource : ResourceBase
    {
        public class SubscriptionDefinitionVersionProperties
        {
            /// <summary>
            /// SubscriptionDefinitionId
            /// The ID of the subscription definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubscriptionDefinitionId { get; set; }

            /// <summary>
            /// Subscriptions
            /// The subscriptions in this version.
            /// Required: Yes
            /// Type: List of Subscription property types
            /// Update requires: Replacement
            /// </summary>
			public List<Subscription> Subscriptions { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::SubscriptionDefinitionVersion";

        public SubscriptionDefinitionVersionProperties Properties { get; } = new SubscriptionDefinitionVersionProperties();

    }
}
