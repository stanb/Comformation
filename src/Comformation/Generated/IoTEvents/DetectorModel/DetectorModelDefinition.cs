using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel DetectorModelDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-detectormodeldefinition.html
    /// </summary>
    public class DetectorModelDefinition
    {

        /// <summary>
        /// InitialStateName
        /// The state that is entered at the creation of each detector (instance).
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InitialStateName")]
        public Union<string, IntrinsicFunction> InitialStateName { get; set; }

        /// <summary>
        /// States
        /// Information about the states of the detector.
        /// Required: Yes
        /// Type: List of State
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("States")]
        public List<State> States { get; set; }

    }
}
