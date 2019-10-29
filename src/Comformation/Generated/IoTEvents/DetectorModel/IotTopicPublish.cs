using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel IotTopicPublish
    /// Sends information about the detector model instance and the event which triggered the action in an MQTT
    /// message with the given topic to the AWS IoT message broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iottopicpublish.html
    /// </summary>
    public class IotTopicPublish
    {

        /// <summary>
        /// MqttTopic
        /// The MQTT topic of the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MqttTopic")]
        public Union<string, IntrinsicFunction> MqttTopic { get; set; }

    }
}
