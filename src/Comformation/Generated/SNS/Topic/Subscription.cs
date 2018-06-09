using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Topic
{
    /// <summary>
    /// Amazon SNS Subscription Property Type
    /// Subscription is an embedded property of the AWS::SNS::Topic resource that describes the subscription endpoints
    /// for an Amazon Simple Notification Service (Amazon SNS) topic.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-subscription.html
    /// </summary>
    public class Subscription
    {

        /// <summary>
        /// Endpoint
        /// The subscription&#39;s endpoint (format depends on the protocol). For more information, see the
        /// Subscribe Endpoint parameter in the Amazon Simple Notification Service API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// Protocol
        /// The subscription&#39;s protocol. For more information, see the Subscribe Protocol parameter in the
        /// Amazon Simple Notification Service API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
