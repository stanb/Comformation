using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel SetVariable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-setvariable.html
    /// </summary>
    public class SetVariable
    {

        /// <summary>
        /// Value
        /// The new value of the variable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// VariableName
        /// The name of the variable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariableName")]
        public Union<string, IntrinsicFunction> VariableName { get; set; }

    }
}
