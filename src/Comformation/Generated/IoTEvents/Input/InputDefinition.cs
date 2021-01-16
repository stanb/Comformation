using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.Input
{
    /// <summary>
    /// AWS::IoTEvents::Input InputDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-inputdefinition.html
    /// </summary>
    public class InputDefinition
    {

        /// <summary>
        /// Attributes
        /// The attributes from the JSON payload that are made available by the input. Inputs are derived from
        /// messages sent to the AWS IoT Events system using BatchPutMessage. Each such message contains a JSON
        /// payload, and those attributes (and their paired values) specified here are available for use in the
        /// condition expressions used by detectors that monitor this input.
        /// Required: No
        /// Type: List of Attribute
        /// Maximum: 200
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public List<Attribute> Attributes { get; set; }

    }
}
