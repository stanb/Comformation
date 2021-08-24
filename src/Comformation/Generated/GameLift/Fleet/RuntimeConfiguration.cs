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
        /// The maximum amount of time (in seconds) allowed to launch a new game session and have it report
        /// ready to host players. During this time, the game session is in status ACTIVATING. If the game
        /// session does not become active before the timeout, it is ended and the game session status is
        /// changed to TERMINATED.
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
        /// The number of game sessions in status ACTIVATING to allow on an instance. This setting limits the
        /// instance resources that can be used for new game activations at any one time.
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
        /// A collection of server process configurations that identify what server processes to run on each
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
