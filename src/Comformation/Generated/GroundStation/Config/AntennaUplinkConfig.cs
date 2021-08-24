using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config AntennaUplinkConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennauplinkconfig.html
    /// </summary>
    public class AntennaUplinkConfig
    {

        /// <summary>
        /// SpectrumConfig
        /// Defines the spectrum configuration.
        /// Required: No
        /// Type: UplinkSpectrumConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpectrumConfig")]
        public UplinkSpectrumConfig SpectrumConfig { get; set; }

        /// <summary>
        /// TargetEirp
        /// The equivalent isotropically radiated power (EIRP) to use for uplink transmissions. Valid values are
        /// between 20. 0 to 50. 0 dBW.
        /// Required: No
        /// Type: Eirp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetEirp")]
        public Eirp TargetEirp { get; set; }

        /// <summary>
        /// TransmitDisabled
        /// Whether or not uplink transmit is disabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransmitDisabled")]
        public Union<bool, IntrinsicFunction> TransmitDisabled { get; set; }

    }
}
