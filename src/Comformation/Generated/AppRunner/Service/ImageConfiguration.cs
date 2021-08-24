using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service ImageConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imageconfiguration.html
    /// </summary>
    public class ImageConfiguration
    {

        /// <summary>
        /// StartCommand
        /// An optional command that App Runner runs to start the application in the source image. If specified,
        /// this command overrides the Docker image’s default start command.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 51200
        /// Pattern: . *
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
        /// Environment variables that are available to your running App Runner service. An array of key-value
        /// pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren&#39;t valid.
        /// Required: No
        /// Type: List of KeyValuePair
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuntimeEnvironmentVariables")]
        public List<KeyValuePair> RuntimeEnvironmentVariables { get; set; }

    }
}
