using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Mp2Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mp2settings.html
    /// </summary>
    public class Mp2Settings
    {

        /// <summary>
        /// CodingMode
        /// The MPEG2 Audio coding mode. Valid values are codingMode10 (for mono) or codingMode20 (for stereo).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodingMode")]
        public Union<string, IntrinsicFunction> CodingMode { get; set; }

        /// <summary>
        /// SampleRate
        /// The sample rate in Hz.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampleRate")]
        public Union<double, IntrinsicFunction> SampleRate { get; set; }

        /// <summary>
        /// Bitrate
        /// The average bitrate in bits/second.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<double, IntrinsicFunction> Bitrate { get; set; }

    }
}
