using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel TransitionEvent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-transitionevent.html
    /// </summary>
    public class TransitionEvent
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
        /// Required. A Boolean expression that when TRUE causes the actions to be performed and the nextState
        /// to be entered.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

        /// <summary>
        /// EventName
        /// The name of the transition event.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventName")]
        public Union<string, IntrinsicFunction> EventName { get; set; }

        /// <summary>
        /// NextState
        /// The next state to enter.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NextState")]
        public Union<string, IntrinsicFunction> NextState { get; set; }

    }
}
