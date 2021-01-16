using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel WavSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-wavsettings.html
    /// </summary>
    public class WavSettings
    {

        /// <summary>
        /// CodingMode
        /// The audio coding mode for the WAV audio. The mode determines the number of channels in the audio.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodingMode")]
        public Union<string, IntrinsicFunction> CodingMode { get; set; }

        /// <summary>
        /// SampleRate
        /// Sample rate in Hz.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampleRate")]
        public Union<double, IntrinsicFunction> SampleRate { get; set; }

        /// <summary>
        /// BitDepth
        /// Bits per sample.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BitDepth")]
        public Union<double, IntrinsicFunction> BitDepth { get; set; }

    }
}
