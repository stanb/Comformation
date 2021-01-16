using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsInputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html
    /// </summary>
    public class HlsInputSettings
    {

        /// <summary>
        /// BufferSegments
        /// When specified, reading of the HLS input begins this many buffer segments from the end (most
        /// recently written segment). When not specified, the HLS input begins with the first segment specified
        /// in the m3u8.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferSegments")]
        public Union<int, IntrinsicFunction> BufferSegments { get; set; }

        /// <summary>
        /// Retries
        /// The number of consecutive times that attempts to read a manifest or segment must fail before the
        /// input is considered unavailable.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Retries")]
        public Union<int, IntrinsicFunction> Retries { get; set; }

        /// <summary>
        /// Bandwidth
        /// When specified, the HLS stream with the m3u8 BANDWIDTH that most closely matches this value is
        /// chosen. Otherwise, the highest bandwidth stream in the m3u8 is chosen. The bitrate is specified in
        /// bits per second, as in an HLS manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bandwidth")]
        public Union<int, IntrinsicFunction> Bandwidth { get; set; }

        /// <summary>
        /// RetryInterval
        /// The number of seconds between retries when an attempt to read a manifest or segment fails.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryInterval")]
        public Union<int, IntrinsicFunction> RetryInterval { get; set; }

    }
}
