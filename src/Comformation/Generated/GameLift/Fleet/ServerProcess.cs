using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet ServerProcess
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-serverprocess.html
    /// </summary>
    public class ServerProcess
    {

        /// <summary>
        /// ConcurrentExecutions
        /// The number of server processes using this configuration that run concurrently on each instance.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConcurrentExecutions")]
        public Union<int, IntrinsicFunction> ConcurrentExecutions { get; set; }

        /// <summary>
        /// LaunchPath
        /// The location of a game build executable or the Realtime script file that contains the Init()
        /// function. Game builds and Realtime scripts are installed on instances at the root:
        /// Windows (custom game builds only): C:\game. Example: &quot;C:\game\MyGame\server. exe&quot; Linux:
        /// /local/game. Examples: &quot;/local/game/MyGame/server. exe&quot; or &quot;/local/game/MyRealtimeScript. js&quot;
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchPath")]
        public Union<string, IntrinsicFunction> LaunchPath { get; set; }

        /// <summary>
        /// Parameters
        /// An optional list of parameters to pass to the server executable or Realtime script on launch.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<string, IntrinsicFunction> Parameters { get; set; }

    }
}
