using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config FrequencyBandwidth
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-frequencybandwidth.html
    /// </summary>
    public class FrequencyBandwidth
    {

        /// <summary>
        /// Value
        /// The value of the bandwidth. AWS Ground Station currently has the following bandwidth limitations:
        /// For AntennaDownlinkDemodDecodeconfig, valid values are between 125 kHz to 650 MHz. For
        /// AntennaDownlinkconfig, valid values are between 10 kHz to 54 MHz. For AntennaUplinkConfig, valid
        /// values are between 10 kHz to 54 MHz.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Units
        /// The units of the bandwidth.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Units")]
        public Union<string, IntrinsicFunction> Units { get; set; }

    }
}
