using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameSessionQueue
{
    /// <summary>
    /// AWS::GameLift::GameSessionQueue PlayerLatencyPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-playerlatencypolicy.html
    /// </summary>
    public class PlayerLatencyPolicy
    {

        /// <summary>
        /// PolicyDurationSeconds
        /// The length of time, in seconds, that the policy is enforced while placing a new game session. A null
        /// value for this property means that the policy is enforced until the queue times out.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyDurationSeconds")]
        public Union<int, IntrinsicFunction> PolicyDurationSeconds { get; set; }

        /// <summary>
        /// MaximumIndividualPlayerLatencyMilliseconds
        /// The maximum latency value that is allowed for any player, in milliseconds. All policies must have a
        /// value set for this property.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumIndividualPlayerLatencyMilliseconds")]
        public Union<int, IntrinsicFunction> MaximumIndividualPlayerLatencyMilliseconds { get; set; }

    }
}
