using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel OnEnter
    /// When entering this state, perform these &quot;actions&quot; if the &quot;condition&quot; is TRUE.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-onenter.html
    /// </summary>
    public class OnEnter
    {

        /// <summary>
        /// Events
        /// Specifies the actions that are performed when the state is entered and the &quot;condition&quot; is TRUE.
        /// Required: No
        /// Type: List of Event
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Events")]
        public List<Event> Events { get; set; }

    }
}
