using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet RuntimeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-runtimeconfiguration.html
    /// </summary>
    public class RuntimeConfiguration
    {

        /// <summary>
        /// GameSessionActivationTimeoutSeconds
        /// The maximum amount of time (in seconds) that a game session can remain in status ACTIVATING. If the
        /// game session is not active before the timeout, activation is terminated and the game session status
        /// is changed to TERMINATED.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GameSessionActivationTimeoutSeconds")]
        public Union<int, IntrinsicFunction> GameSessionActivationTimeoutSeconds { get; set; }

        /// <summary>
        /// MaxConcurrentGameSessionActivations
        /// The maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously.
        /// This setting limits the amount of instance resources that can be used for new game activations at
        /// any one time.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConcurrentGameSessionActivations")]
        public Union<int, IntrinsicFunction> MaxConcurrentGameSessionActivations { get; set; }

        /// <summary>
        /// ServerProcesses
        /// A collection of server process configurations that describe which server processes to run on each
        /// instance in a fleet.
        /// Required: No
        /// Type: List of ServerProcess
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerProcesses")]
        public List<ServerProcess> ServerProcesses { get; set; }

    }
}
