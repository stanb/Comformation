using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel EmbeddedSourceSettings
    /// Information about the embedded captions to extract from the input.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html
    /// </summary>
    public class EmbeddedSourceSettings
    {

        /// <summary>
        /// Source608ChannelNumber
        /// Specifies the 608/708 channel number within the video track from which to extract captions. This is
        /// unused for passthrough.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source608ChannelNumber")]
        public Union<int, IntrinsicFunction> Source608ChannelNumber { get; set; }

        /// <summary>
        /// Scte20Detection
        /// Set to &quot;auto&quot; to handle streams with intermittent or non-aligned SCTE-20 and embedded captions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte20Detection")]
        public Union<string, IntrinsicFunction> Scte20Detection { get; set; }

        /// <summary>
        /// Source608TrackNumber
        /// This field is unused and deprecated.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source608TrackNumber")]
        public Union<int, IntrinsicFunction> Source608TrackNumber { get; set; }

        /// <summary>
        /// Convert608To708
        /// If this is upconvert, 608 data is both passed through the &quot;608 compatibility bytes&quot; fields of the
        /// 708 wrapper as well as translated into 708. If 708 data is present in the source content, it is
        /// discarded.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Convert608To708")]
        public Union<string, IntrinsicFunction> Convert608To708 { get; set; }

    }
}
