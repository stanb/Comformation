using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameSessionQueue
{
    /// <summary>
    /// AWS::GameLift::GameSessionQueue FilterConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-filterconfiguration.html
    /// </summary>
    public class FilterConfiguration
    {

        /// <summary>
        /// AllowedLocations
        /// A list of locations to allow game session placement in, in the form of AWS Region codes such as
        /// us-west-2.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedLocations")]
        public List<Union<string, IntrinsicFunction>> AllowedLocations { get; set; }

    }
}
