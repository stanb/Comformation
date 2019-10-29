using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioLanguageSelection
    /// Information about the audio language to extract.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html
    /// </summary>
    public class AudioLanguageSelection
    {

        /// <summary>
        /// LanguageCode
        /// Selects a specific three-letter language code from within an audio source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCode")]
        public Union<string, IntrinsicFunction> LanguageCode { get; set; }

        /// <summary>
        /// LanguageSelectionPolicy
        /// When set to &quot;strict,&quot; the transport stream demux strictly identifies audio streams by their language
        /// descriptor. If a PMT update occurs such that an audio stream matching the initially selected
        /// language is no longer present, then mute is encoded until the language returns. If set to &quot;loose,&quot;
        /// then on a PMT update the demux chooses another audio stream in the program with the same stream type
        /// if it can&#39;t find one with the same language.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageSelectionPolicy")]
        public Union<string, IntrinsicFunction> LanguageSelectionPolicy { get; set; }

    }
}
