using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Fmp4HlsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fmp4hlssettings.html
    /// </summary>
    public class Fmp4HlsSettings
    {

        /// <summary>
        /// AudioRenditionSets
        /// List all the audio groups that are used with the video output stream. Input all the audio GROUP-IDs
        /// that are associated to the video, separate by &#39;,&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioRenditionSets")]
        public Union<string, IntrinsicFunction> AudioRenditionSets { get; set; }

        /// <summary>
        /// NielsenId3Behavior
        /// If set to passthrough, Nielsen inaudible tones for media tracking will be detected in the input
        /// audio and an equivalent ID3 tag will be inserted in the output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NielsenId3Behavior")]
        public Union<string, IntrinsicFunction> NielsenId3Behavior { get; set; }

        /// <summary>
        /// TimedMetadataBehavior
        /// When set to passthrough, timed metadata is passed through from input to output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataBehavior")]
        public Union<string, IntrinsicFunction> TimedMetadataBehavior { get; set; }

    }
}
