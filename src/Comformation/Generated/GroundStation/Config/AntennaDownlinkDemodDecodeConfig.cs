using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config AntennaDownlinkDemodDecodeConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkdemoddecodeconfig.html
    /// </summary>
    public class AntennaDownlinkDemodDecodeConfig
    {

        /// <summary>
        /// SpectrumConfig
        /// Defines the spectrum configuration.
        /// Required: No
        /// Type: SpectrumConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpectrumConfig")]
        public SpectrumConfig SpectrumConfig { get; set; }

        /// <summary>
        /// DemodulationConfig
        /// Defines how the RF signal will be demodulated.
        /// Required: No
        /// Type: DemodulationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DemodulationConfig")]
        public DemodulationConfig DemodulationConfig { get; set; }

        /// <summary>
        /// DecodeConfig
        /// Defines how the RF signal will be decoded.
        /// Required: No
        /// Type: DecodeConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DecodeConfig")]
        public DecodeConfig DecodeConfig { get; set; }

    }
}
