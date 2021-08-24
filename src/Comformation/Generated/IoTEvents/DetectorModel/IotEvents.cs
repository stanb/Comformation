using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel IotEvents
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotevents.html
    /// </summary>
    public class IotEvents
    {

        /// <summary>
        /// InputName
        /// The name of the AWS IoT Events input where the data is sent.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputName")]
        public Union<string, IntrinsicFunction> InputName { get; set; }

        /// <summary>
        /// Payload
        /// You can configure the action payload when you send a message to an AWS IoT Events input.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

    }
}
