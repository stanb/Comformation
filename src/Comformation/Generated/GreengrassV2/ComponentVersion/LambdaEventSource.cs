using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaEventSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdaeventsource.html
    /// </summary>
    public class LambdaEventSource
    {

        /// <summary>
        /// Topic
        /// The topic to which to subscribe to receive event messages.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

        /// <summary>
        /// Type
        /// The type of event source. Choose from the following options:
        /// PUB_SUB – Subscribe to local publish/subscribe messages. This event source type doesn&#39;t support MQTT
        /// wildcards (+ and #) in the event source topic. IOT_CORE – Subscribe to AWS IoT Core MQTT messages.
        /// This event source type supports MQTT wildcards (+ and #) in the event source topic.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
