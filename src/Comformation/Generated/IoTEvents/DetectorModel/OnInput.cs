using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel OnInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-oninput.html
    /// </summary>
    public class OnInput
    {

        /// <summary>
        /// Events
        /// Specifies the actions performed when the condition evaluates to TRUE.
        /// Required: No
        /// Type: List of Event
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Events")]
        public List<Event> Events { get; set; }

        /// <summary>
        /// TransitionEvents
        /// Specifies the actions performed, and the next state entered, when a condition evaluates to TRUE.
        /// Required: No
        /// Type: List of TransitionEvent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionEvents")]
        public List<TransitionEvent> TransitionEvents { get; set; }

    }
}
