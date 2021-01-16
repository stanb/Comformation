using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VideoCodecSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videocodecsettings.html
    /// </summary>
    public class VideoCodecSettings
    {

        /// <summary>
        /// Mpeg2Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Mpeg2Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mpeg2Settings")]
        public Mpeg2Settings Mpeg2Settings { get; set; }

        /// <summary>
        /// FrameCaptureSettings
        /// The settings for the video codec in a frame capture output.
        /// Required: No
        /// Type: FrameCaptureSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FrameCaptureSettings")]
        public FrameCaptureSettings FrameCaptureSettings { get; set; }

        /// <summary>
        /// H264Settings
        /// The settings for the H. 264 codec in the output.
        /// Required: No
        /// Type: H264Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("H264Settings")]
        public H264Settings H264Settings { get; set; }

        /// <summary>
        /// H265Settings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: H265Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("H265Settings")]
        public H265Settings H265Settings { get; set; }

    }
}
