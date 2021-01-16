using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioSilenceFailoverSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiosilencefailoversettings.html
    /// </summary>
    public class AudioSilenceFailoverSettings
    {

        /// <summary>
        /// AudioSelectorName
        /// The name of the audio selector in the input that MediaLive should monitor to detect silence. Select
        /// your most important rendition. If you didn&#39;t create an audio selector in this input, leave blank.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public Union<string, IntrinsicFunction> AudioSelectorName { get; set; }

        /// <summary>
        /// AudioSilenceThresholdMsec
        /// The amount of time (in milliseconds) that the active input must be silent before automatic input
        /// failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioSilenceThresholdMsec")]
        public Union<int, IntrinsicFunction> AudioSilenceThresholdMsec { get; set; }

    }
}
