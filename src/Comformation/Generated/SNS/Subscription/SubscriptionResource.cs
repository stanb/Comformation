using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Subscription
{
    /// <summary>
    /// AWS::SNS::Subscription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html
    /// </summary>
    public class SubscriptionResource : ResourceBase
    {
        public class SubscriptionProperties
        {
            /// <summary>
            /// DeliveryPolicy
            /// The delivery policy JSON assigned to the subscription. Enables the subscriber to define the message
            /// delivery retry strategy in the case of an HTTP/S endpoint subscribed to the topic. For more
            /// information, see GetSubscriptionAttributes in the Amazon Simple Notification Service API Reference
            /// and Message Delivery Retries in the Amazon SNS Developer Guide.
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
            /// The filter policy JSON assigned to the subscription. Enables the subscriber to filter out unwanted
            /// messages. For more information, see GetSubscriptionAttributes in the Amazon Simple Notification
            /// Service API Reference and Message Filtering in the Amazon SNS Developer Guide.
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
            /// RedrivePolicy
            /// When specified, sends undeliverable messages to the specified Amazon SQS dead-letter queue. Messages
            /// that can&#39;t be delivered due to client errors (for example, when the subscribed endpoint is
            /// unreachable) or server errors (for example, when the service that powers the subscribed endpoint
            /// becomes unavailable) are held in the dead-letter queue for further analysis or reprocessing.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RedrivePolicy { get; set; }

            /// <summary>
            /// Region
            /// For cross-region subscriptions, the region in which the topic resides.
            /// If no region is specified, CloudFormation uses the region of the caller as the default.
            /// If you perform an update operation that only updates the Region property of a AWS::SNS::Subscription
            /// resource, that operation will fail unless you are either:
            /// Updating the Region from NULL to the caller region. Updating the Region from the caller region to
            /// NULL.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Region { get; set; }

            /// <summary>
            /// SubscriptionRoleArn
            /// This property applies only to Amazon Kinesis Data Firehose delivery stream subscriptions. Specify
            /// the ARN of the IAM role that has the following:
            /// Permission to write to the Amazon Kinesis Data Firehose delivery stream Amazon SNS listed as a
            /// trusted entity
            /// Specifying a valid ARN for this attribute is required for Kinesis Data Firehose delivery stream
            /// subscriptions. For more information, see Fanout to Amazon Kinesis Data Firehose delivery streams in
            /// the Amazon SNS Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SubscriptionRoleArn { get; set; }

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
