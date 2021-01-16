using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameSessionQueue
{
    /// <summary>
    /// AWS::GameLift::GameSessionQueue Destination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-destination.html
    /// </summary>
    public class Destination
    {

        /// <summary>
        /// DestinationArn
        /// The Amazon Resource Name (ARN) that is assigned to fleet or fleet alias. ARNs, which include a fleet
        /// ID or alias ID and a Region name, provide a unique identifier across all Regions.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [a-zA-Z0-9:/-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

    }
}
