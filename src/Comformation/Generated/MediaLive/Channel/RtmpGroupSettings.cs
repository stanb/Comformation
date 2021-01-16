using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel RtmpGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-rtmpgroupsettings.html
    /// </summary>
    public class RtmpGroupSettings
    {

        /// <summary>
        /// AuthenticationScheme
        /// An authentication scheme to use when connecting with a CDN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticationScheme")]
        public Union<string, IntrinsicFunction> AuthenticationScheme { get; set; }

        /// <summary>
        /// CacheLength
        /// The cache length, in seconds, that is used to calculate buffer size.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CacheLength")]
        public Union<int, IntrinsicFunction> CacheLength { get; set; }

        /// <summary>
        /// AdMarkers
        /// Choose the ad marker type for this output group. MediaLive will create a message based on the
        /// content of each SCTE-35 message, format it for that marker type, and insert it in the datastream.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdMarkers")]
        public List<Union<string, IntrinsicFunction>> AdMarkers { get; set; }

        /// <summary>
        /// InputLossAction
        /// Controls the behavior of this RTMP group if the input becomes unavailable. emitOutput: Emit a slate
        /// until the input returns. pauseOutput: Stop transmitting data until the input returns. This does not
        /// close the underlying RTMP connection.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossAction")]
        public Union<string, IntrinsicFunction> InputLossAction { get; set; }

        /// <summary>
        /// RestartDelay
        /// If a streaming output fails, the number of seconds to wait until a restart is initiated. A value of
        /// 0 means never restart.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestartDelay")]
        public Union<int, IntrinsicFunction> RestartDelay { get; set; }

        /// <summary>
        /// CaptionData
        /// Controls the types of data that pass to onCaptionInfo outputs. If set to all, 608 and 708 carried
        /// DTVCC data is passed. If set to field1AndField2608, DTVCC data is stripped out, but 608 data from
        /// both fields is passed. If set to field1608, only the data carried in 608 from field 1 video is
        /// passed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionData")]
        public Union<string, IntrinsicFunction> CaptionData { get; set; }

        /// <summary>
        /// CacheFullBehavior
        /// Controls behavior when the content cache fills up. If a remote origin server stalls the RTMP
        /// connection and doesn&#39;t accept content fast enough, the media cache fills up. When the cache reaches
        /// the duration specified by cacheLength, the cache stops accepting new content. If set to
        /// disconnectImmediately, the RTMP output forces a disconnect. Clear the media cache, and reconnect
        /// after restartDelay seconds. If set to waitForServer, the RTMP output waits up to 5 minutes to allow
        /// the origin server to begin accepting data again.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CacheFullBehavior")]
        public Union<string, IntrinsicFunction> CacheFullBehavior { get; set; }

    }
}
