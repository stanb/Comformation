using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputChannelLevel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputchannellevel.html
    /// </summary>
    public class InputChannelLevel
    {

        /// <summary>
        /// InputChannel
        /// The index of the input channel that is used as a source.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputChannel")]
        public Union<int, IntrinsicFunction> InputChannel { get; set; }

        /// <summary>
        /// Gain
        /// The remixing value. Units are in dB, and acceptable values are within the range from -60 (mute) to 6
        /// dB.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gain")]
        public Union<int, IntrinsicFunction> Gain { get; set; }

    }
}
