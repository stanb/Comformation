using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config DemodulationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-demodulationconfig.html
    /// </summary>
    public class DemodulationConfig
    {

        /// <summary>
        /// UnvalidatedJSON
        /// The demodulation settings are in JSON format and define parameters for demodulation, for example
        /// which modulation scheme (e. g. PSK, QPSK, etc. ) and matched filter to use.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnvalidatedJSON")]
        public Union<string, IntrinsicFunction> UnvalidatedJSON { get; set; }

    }
}
