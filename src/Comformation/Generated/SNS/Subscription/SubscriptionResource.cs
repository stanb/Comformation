using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Subscription
{
    /// <summary>
    /// AWS::SNS::Subscription
    /// The AWS::SNS::Subscription resource subscribes an endpoint to an Amazon Simple Notification Service (Amazon
    /// SNS) topic. The owner of the endpoint must confirm the subscription before Amazon SNS creates the
    /// subscription.
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
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DeliveryPolicy { get; set; }

            /// <summary>
            /// Endpoint
            /// The endpoint that receives notifications from the Amazon SNS topic. The endpoint value depends on
            /// the protocol that you specify. For more information, see the Subscribe Endpoint parameter in the
            /// Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Endpoint { get; set; }

            /// <summary>
            /// FilterPolicy
            /// The filter policy JSON that is assigned to the subscription. For more information, see
            /// GetSubscriptionAttributes in the Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> FilterPolicy { get; set; }

            /// <summary>
            /// Protocol
            /// The subscription&#39;s protocol. For more information, see the Subscribe Protocol parameter in the
            /// Amazon Simple Notification Service API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// RawMessageDelivery
            /// true if raw message delivery is enabled for the subscription. Raw messages are free of JSON
            /// formatting and can be sent to HTTP/S and Amazon SQS endpoints. For more information, see
            /// GetSubscriptionAttributes in the Amazon Simple Notification Service API Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> RawMessageDelivery { get; set; }

            /// <summary>
            /// Region
            /// The region in which the topic resides.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Region { get; set; }

            /// <summary>
            /// TopicArn
            /// The Amazon Resource Name (ARN) of the topic to subscribe to.
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
