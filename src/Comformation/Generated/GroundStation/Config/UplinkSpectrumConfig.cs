using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config UplinkSpectrumConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkspectrumconfig.html
    /// </summary>
    public class UplinkSpectrumConfig
    {

        /// <summary>
        /// CenterFrequency
        /// The center frequency of the spectrum. Valid values are between 2200 to 2300 MHz and 7750 to 8400 MHz
        /// for downlink and 2025 to 2120 MHz for uplink.
        /// Required: No
        /// Type: Frequency
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CenterFrequency")]
        public Frequency CenterFrequency { get; set; }

        /// <summary>
        /// Polarization
        /// The polarization of the spectrum. Valid values are &quot;RIGHT_HAND&quot; and &quot;LEFT_HAND&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Polarization")]
        public Union<string, IntrinsicFunction> Polarization { get; set; }

    }
}
