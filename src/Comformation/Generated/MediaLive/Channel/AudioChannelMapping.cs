using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioChannelMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiochannelmapping.html
    /// </summary>
    public class AudioChannelMapping
    {

        /// <summary>
        /// OutputChannel
        /// The index of the output channel that is being produced.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputChannel")]
        public Union<int, IntrinsicFunction> OutputChannel { get; set; }

        /// <summary>
        /// InputChannelLevels
        /// The indices and gain values for each input channel that should be remixed into this output channel.
        /// Required: No
        /// Type: List of InputChannelLevel
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputChannelLevels")]
        public List<InputChannelLevel> InputChannelLevels { get; set; }

    }
}
