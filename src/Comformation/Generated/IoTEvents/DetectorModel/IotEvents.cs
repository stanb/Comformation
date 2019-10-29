using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel IotEvents
    /// Sends an IoT Events input, passing in information about the detector model instance and the event which
    /// triggered the action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotevents.html
    /// </summary>
    public class IotEvents
    {

        /// <summary>
        /// InputName
        /// The name of the AWS IoT Events input where the data is sent.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputName")]
        public Union<string, IntrinsicFunction> InputName { get; set; }

    }
}
