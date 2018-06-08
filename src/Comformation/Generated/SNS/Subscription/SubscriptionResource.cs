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
            /// Protocol
            /// The subscription's protocol. For more information, see the Subscribe Protocol parameter in the
            /// Amazon Simple Notification Service API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

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
