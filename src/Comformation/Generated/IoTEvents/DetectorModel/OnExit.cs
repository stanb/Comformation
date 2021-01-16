using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel OnExit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-onexit.html
    /// </summary>
    public class OnExit
    {

        /// <summary>
        /// Events
        /// Specifies the actions that are performed when the state is exited and the condition is TRUE.
        /// Required: No
        /// Type: List of Event
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Events")]
        public List<Event> Events { get; set; }

    }
}
