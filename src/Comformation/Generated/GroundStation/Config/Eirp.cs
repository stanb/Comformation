using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config Eirp
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-eirp.html
    /// </summary>
    public class Eirp
    {

        /// <summary>
        /// Value
        /// The value of the EIRP. Valid values are between 20. 0 to 50. 0 dBW.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Units
        /// The units of the EIRP.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Units")]
        public Union<string, IntrinsicFunction> Units { get; set; }

    }
}
