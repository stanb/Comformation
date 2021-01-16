using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.MatchmakingConfiguration
{
    /// <summary>
    /// AWS::GameLift::MatchmakingConfiguration GameProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-matchmakingconfiguration-gameproperty.html
    /// </summary>
    public class GameProperty
    {

        /// <summary>
        /// Value
        /// The game property value.
        /// Required: Yes
        /// Type: String
        /// Maximum: 96
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The game property identifier.
        /// Required: Yes
        /// Type: String
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
