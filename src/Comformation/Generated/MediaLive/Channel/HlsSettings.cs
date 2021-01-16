using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlssettings.html
    /// </summary>
    public class HlsSettings
    {

        /// <summary>
        /// StandardHlsSettings
        /// The settings for a standard output (an output that is not audio-only).
        /// Required: No
        /// Type: StandardHlsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StandardHlsSettings")]
        public StandardHlsSettings StandardHlsSettings { get; set; }

        /// <summary>
        /// AudioOnlyHlsSettings
        /// The settings for an audio-only output.
        /// Required: No
        /// Type: AudioOnlyHlsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioOnlyHlsSettings")]
        public AudioOnlyHlsSettings AudioOnlyHlsSettings { get; set; }

        /// <summary>
        /// Fmp4HlsSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Fmp4HlsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Fmp4HlsSettings")]
        public Fmp4HlsSettings Fmp4HlsSettings { get; set; }

    }
}
