using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service CodeConfigurationValues
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfigurationvalues.html
    /// </summary>
    public class CodeConfigurationValues
    {

        /// <summary>
        /// Runtime
        /// A runtime environment type for building and running an App Runner service. It represents a
        /// programming language runtime.
        /// Required: Yes
        /// Type: String
        /// Allowed values: NODEJS_12 | PYTHON_3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Runtime")]
        public Union<string, IntrinsicFunction> Runtime { get; set; }

        /// <summary>
        /// BuildCommand
        /// The command App Runner runs to build your application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BuildCommand")]
        public Union<string, IntrinsicFunction> BuildCommand { get; set; }

        /// <summary>
        /// StartCommand
        /// The command App Runner runs to start your application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartCommand")]
        public Union<string, IntrinsicFunction> StartCommand { get; set; }

        /// <summary>
        /// Port
        /// The port that your application listens to in the container.
        /// Default: 8080
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 51200
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<string, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// RuntimeEnvironmentVariables
        /// The environment variables that are available to your running App Runner service. An array of
        /// key-value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&#39;t valid.
        /// Required: No
        /// Type: List of KeyValuePair
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuntimeEnvironmentVariables")]
        public List<KeyValuePair> RuntimeEnvironmentVariables { get; set; }

    }
}
