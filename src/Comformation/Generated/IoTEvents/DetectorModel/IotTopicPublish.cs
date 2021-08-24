using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel IotTopicPublish
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iottopicpublish.html
    /// </summary>
    public class IotTopicPublish
    {

        /// <summary>
        /// MqttTopic
        /// The MQTT topic of the message. You can use a string expression that includes variables ($variable.
        /// &amp;lt;variable-name&amp;gt;) and input values ($input. &amp;lt;input-name&amp;gt;. &amp;lt;path-to-datum&amp;gt;) as the
        /// topic string.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MqttTopic")]
        public Union<string, IntrinsicFunction> MqttTopic { get; set; }

        /// <summary>
        /// Payload
        /// You can configure the action payload when you publish a message to an AWS IoT Core topic.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

    }
}
