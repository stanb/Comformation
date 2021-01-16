using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel RemixSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-remixsettings.html
    /// </summary>
    public class RemixSettings
    {

        /// <summary>
        /// ChannelsOut
        /// The number of output channels to be produced. Valid values: 1, 2, 4, 6, 8.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelsOut")]
        public Union<int, IntrinsicFunction> ChannelsOut { get; set; }

        /// <summary>
        /// ChannelMappings
        /// A mapping of input channels to output channels, with appropriate gain adjustments.
        /// Required: No
        /// Type: List of AudioChannelMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelMappings")]
        public List<AudioChannelMapping> ChannelMappings { get; set; }

        /// <summary>
        /// ChannelsIn
        /// The number of input channels to be used.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelsIn")]
        public Union<int, IntrinsicFunction> ChannelsIn { get; set; }

    }
}
