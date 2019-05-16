using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Subscription
{
    /// <summary>
    /// AWS::SNS::Subscription
    /// The AWS::SNS::Subscription resource subscribes an endpoint to an Amazon Simple Notification Service (Amazon
    /// SNS) topic. For a subscription to be created, the owner of the endpoint must confirm the subscription.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html
    /// </summary>
    public class SubscriptionResource : ResourceBase
    {
        public class SubscriptionProperties
        {
            /// <summary>
            /// DeliveryPolicy
            /// The JSON serialization of the subscription&#39;s delivery policy. For more information, see
            /// GetSubscriptionAttributes in the Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DeliveryPolicy { get; set; }

            /// <summary>
            /// Endpoint
            /// The subscription&#39;s endpoint. The endpoint value depends on the protocol that you specify. For more
            /// information, see the Endpoint parameter of the Subscribe action in the Amazon Simple Notification
            /// Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Endpoint { get; set; }

            /// <summary>
            /// FilterPolicy
            /// The filter policy JSON assigned to the subscription. For more information, see
            /// GetSubscriptionAttributes in the Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> FilterPolicy { get; set; }

            /// <summary>
            /// Protocol
            /// The subscription&#39;s protocol. For more information, see the Protocol parameter of the Subscribe
            /// action in the Amazon Simple Notification Service API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// RawMessageDelivery
            /// When set to true, enables raw message delivery. Raw messages don&#39;t contain any JSON formatting and
            /// can be sent to Amazon SQS and HTTP/S endpoints. For more information, see GetSubscriptionAttributes
            /// in the Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> RawMessageDelivery { get; set; }

            /// <summary>
            /// Region
            /// For cross-region subscriptions, the region in which the topic resides.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Region { get; set; }

            /// <summary>
            /// TopicArn
            /// The ARN of the topic to subscribe to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TopicArn { get; set; }

        }

        public string Type { get; } = "AWS::SNS::Subscription";

        public SubscriptionProperties Properties { get; } = new SubscriptionProperties();

    }
}
