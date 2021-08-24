using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config SpectrumConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-spectrumconfig.html
    /// </summary>
    public class SpectrumConfig
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
        /// Bandwidth
        /// The bandwidth of the spectrum. AWS Ground Station currently has the following bandwidth limitations:
        /// For AntennaDownlinkDemodDecodeconfig, valid values are between 125 kHz to 650 MHz. For
        /// AntennaDownlinkconfig, valid values are between 10 kHz to 54 MHz. For AntennaUplinkConfig, valid
        /// values are between 10 kHz to 54 MHz.
        /// Required: No
        /// Type: FrequencyBandwidth
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bandwidth")]
        public FrequencyBandwidth Bandwidth { get; set; }

        /// <summary>
        /// Polarization
        /// The polarization of the spectrum. Valid values are &quot;RIGHT_HAND&quot; and &quot;LEFT_HAND&quot;. Capturing both
        /// &quot;RIGHT_HAND&quot; and &quot;LEFT_HAND&quot; polarization requires two separate configs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Polarization")]
        public Union<string, IntrinsicFunction> Polarization { get; set; }

    }
}
