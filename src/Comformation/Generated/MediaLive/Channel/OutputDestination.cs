using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputDestination
    /// Configuration information for an output.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html
    /// </summary>
    public class OutputDestination
    {

        /// <summary>
        /// Id
        /// The ID for this destination.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Settings
        /// The destination settings for an output.
        /// Required: No
        /// Type: List of OutputDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Settings")]
        public List<OutputDestinationSettings> Settings { get; set; }

        /// <summary>
        /// MediaPackageSettings
        /// The destination settings for a MediaPackage output.
        /// Required: No
        /// Type: List of MediaPackageOutputDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaPackageSettings")]
        public List<MediaPackageOutputDestinationSettings> MediaPackageSettings { get; set; }

    }
}
