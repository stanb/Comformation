using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Event
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html
    /// </summary>
    public class Event
    {

        /// <summary>
        /// Actions
        /// The actions to be performed.
        /// Required: No
        /// Type: List of Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// Condition
        /// Optional. The Boolean expression that, when TRUE, causes the actions to be performed. If not
        /// present, the actions are performed (=TRUE). If the expression result is not a Boolean value, the
        /// actions are not performed (=FALSE).
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

        /// <summary>
        /// EventName
        /// The name of the event.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventName")]
        public Union<string, IntrinsicFunction> EventName { get; set; }

    }
}
