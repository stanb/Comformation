using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config AntennaDownlinkConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-antennadownlinkconfig.html
    /// </summary>
    public class AntennaDownlinkConfig
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

    }
}
