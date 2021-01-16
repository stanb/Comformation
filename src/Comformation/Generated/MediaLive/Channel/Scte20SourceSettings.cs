using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Scte20SourceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html
    /// </summary>
    public class Scte20SourceSettings
    {

        /// <summary>
        /// Source608ChannelNumber
        /// Specifies the 608/708 channel number within the video track from which to extract captions.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source608ChannelNumber")]
        public Union<int, IntrinsicFunction> Source608ChannelNumber { get; set; }

        /// <summary>
        /// Convert608To708
        /// If upconvert, 608 data is both passed through the &quot;608 compatibility bytes&quot; fields of the 708
        /// wrapper as well as translated into 708. Any 708 data present in the source content is discarded.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Convert608To708")]
        public Union<string, IntrinsicFunction> Convert608To708 { get; set; }

    }
}
