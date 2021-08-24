using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config UplinkEchoConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-uplinkechoconfig.html
    /// </summary>
    public class UplinkEchoConfig
    {

        /// <summary>
        /// Enabled
        /// Whether or not uplink echo is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// AntennaUplinkConfigArn
        /// Defines the ARN of the uplink config to echo back to a dataflow endpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AntennaUplinkConfigArn")]
        public Union<string, IntrinsicFunction> AntennaUplinkConfigArn { get; set; }

    }
}
