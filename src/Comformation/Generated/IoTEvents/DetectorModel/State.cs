using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel State
    /// Information that defines a state of a detector.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-state.html
    /// </summary>
    public class State
    {

        /// <summary>
        /// OnInput
        /// When an input is received and the &quot;condition&quot; is TRUE, perform the specified &quot;actions&quot;.
        /// Required: No
        /// Type: OnInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnInput")]
        public OnInput OnInput { get; set; }

        /// <summary>
        /// OnExit
        /// When exiting this state, perform these &quot;actions&quot; if the specified &quot;condition&quot; is TRUE.
        /// Required: No
        /// Type: OnExit
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnExit")]
        public OnExit OnExit { get; set; }

        /// <summary>
        /// StateName
        /// The name of the state.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StateName")]
        public Union<string, IntrinsicFunction> StateName { get; set; }

        /// <summary>
        /// OnEnter
        /// When entering this state, perform these &quot;actions&quot; if the &quot;condition&quot; is TRUE.
        /// Required: No
        /// Type: OnEnter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnEnter")]
        public OnEnter OnEnter { get; set; }

    }
}
