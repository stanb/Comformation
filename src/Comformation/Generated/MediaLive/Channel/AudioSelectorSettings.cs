using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioSelectorSettings
    /// Information about the audio to extract from the input.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html
    /// </summary>
    public class AudioSelectorSettings
    {

        /// <summary>
        /// AudioPidSelection
        /// The PID of the audio to select.
        /// Required: No
        /// Type: AudioPidSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioPidSelection")]
        public AudioPidSelection AudioPidSelection { get; set; }

        /// <summary>
        /// AudioLanguageSelection
        /// The language code of the audio to select.
        /// Required: No
        /// Type: AudioLanguageSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioLanguageSelection")]
        public AudioLanguageSelection AudioLanguageSelection { get; set; }

    }
}
