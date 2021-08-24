using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config DecodeConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-decodeconfig.html
    /// </summary>
    public class DecodeConfig
    {

        /// <summary>
        /// UnvalidatedJSON
        /// The decoding settings are in JSON format and define a set of steps to perform to decode the data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnvalidatedJSON")]
        public Union<string, IntrinsicFunction> UnvalidatedJSON { get; set; }

    }
}
