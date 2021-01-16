using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioSelectorSettings
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

        /// <summary>
        /// AudioTrackSelection
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: AudioTrackSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioTrackSelection")]
        public AudioTrackSelection AudioTrackSelection { get; set; }

    }
}
