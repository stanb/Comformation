using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioCodecSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiocodecsettings.html
    /// </summary>
    public class AudioCodecSettings
    {

        /// <summary>
        /// Eac3Settings
        /// The setup of an EAC3 audio codec in the output.
        /// Required: No
        /// Type: Eac3Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Eac3Settings")]
        public Eac3Settings Eac3Settings { get; set; }

        /// <summary>
        /// Ac3Settings
        /// The setup of an AC3 audio codec in the output.
        /// Required: No
        /// Type: Ac3Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ac3Settings")]
        public Ac3Settings Ac3Settings { get; set; }

        /// <summary>
        /// Mp2Settings
        /// The setup of an MP2 audio codec in the output.
        /// Required: No
        /// Type: Mp2Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mp2Settings")]
        public Mp2Settings Mp2Settings { get; set; }

        /// <summary>
        /// PassThroughSettings
        /// The setup to pass through the Dolby audio codec to the output.
        /// Required: No
        /// Type: PassThroughSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PassThroughSettings")]
        public PassThroughSettings PassThroughSettings { get; set; }

        /// <summary>
        /// WavSettings
        /// Settings for audio encoded with the WAV codec.
        /// Required: No
        /// Type: WavSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WavSettings")]
        public WavSettings WavSettings { get; set; }

        /// <summary>
        /// AacSettings
        /// The setup of the AAC audio codec in the output.
        /// Required: No
        /// Type: AacSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AacSettings")]
        public AacSettings AacSettings { get; set; }

    }
}
