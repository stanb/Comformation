using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroup.html
    /// </summary>
    public class OutputGroup
    {

        /// <summary>
        /// Outputs
        /// The settings for the outputs in the output group.
        /// Required: No
        /// Type: List of Output
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Outputs")]
        public List<Output> Outputs { get; set; }

        /// <summary>
        /// OutputGroupSettings
        /// The settings associated with the output group.
        /// Required: No
        /// Type: OutputGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputGroupSettings")]
        public OutputGroupSettings OutputGroupSettings { get; set; }

        /// <summary>
        /// Name
        /// A custom output group name that you can optionally define. Only letters, numbers, and the underscore
        /// character are allowed. The maximum length is 32 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
