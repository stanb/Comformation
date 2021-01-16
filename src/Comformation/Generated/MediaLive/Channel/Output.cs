using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Output
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-output.html
    /// </summary>
    public class Output
    {

        /// <summary>
        /// OutputSettings
        /// The output type-specific settings.
        /// Required: No
        /// Type: OutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSettings")]
        public OutputSettings OutputSettings { get; set; }

        /// <summary>
        /// CaptionDescriptionNames
        /// The names of the caption descriptions that are used as captions sources for this output.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionDescriptionNames")]
        public List<Union<string, IntrinsicFunction>> CaptionDescriptionNames { get; set; }

        /// <summary>
        /// AudioDescriptionNames
        /// The names of the audio descriptions that are used as audio sources for this output.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioDescriptionNames")]
        public List<Union<string, IntrinsicFunction>> AudioDescriptionNames { get; set; }

        /// <summary>
        /// OutputName
        /// The name that is used to identify an output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputName")]
        public Union<string, IntrinsicFunction> OutputName { get; set; }

        /// <summary>
        /// VideoDescriptionName
        /// The name of the VideoDescription that is used as the source for this output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoDescriptionName")]
        public Union<string, IntrinsicFunction> VideoDescriptionName { get; set; }

    }
}
