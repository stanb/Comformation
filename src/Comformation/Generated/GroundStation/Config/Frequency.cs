using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config Frequency
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequency.html
    /// </summary>
    public class Frequency
    {

        /// <summary>
        /// Value
        /// The value of the frequency. Valid values are between 2200 to 2300 MHz and 7750 to 8400 MHz for
        /// downlink and 2025 to 2120 MHz for uplink.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Units
        /// The units of the frequency.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Units")]
        public Union<string, IntrinsicFunction> Units { get; set; }

    }
}
