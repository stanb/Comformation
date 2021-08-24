using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Topic
{
    /// <summary>
    /// AWS::SNS::Topic Subscription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-subscription.html
    /// </summary>
    public class Subscription
    {

        /// <summary>
        /// Endpoint
        /// The endpoint that receives notifications from the Amazon SNS topic. The endpoint value depends on
        /// the protocol that you specify. For more information, see the Endpoint parameter of the Subscribe
        /// action in the Amazon SNS API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// Protocol
        /// The subscription&#39;s protocol. For more information, see the Protocol parameter of the Subscribe
        /// action in the Amazon SNS API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
