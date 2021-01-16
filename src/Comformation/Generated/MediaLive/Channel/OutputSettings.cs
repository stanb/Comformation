using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputsettings.html
    /// </summary>
    public class OutputSettings
    {

        /// <summary>
        /// MediaPackageOutputSettings
        /// The settings for a MediaPackage output.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: MediaPackageOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaPackageOutputSettings")]
        public MediaPackageOutputSettings MediaPackageOutputSettings { get; set; }

        /// <summary>
        /// MsSmoothOutputSettings
        /// The settings for a Microsoft Smooth output.
        /// Required: No
        /// Type: MsSmoothOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MsSmoothOutputSettings")]
        public MsSmoothOutputSettings MsSmoothOutputSettings { get; set; }

        /// <summary>
        /// FrameCaptureOutputSettings
        /// The settings for a frame capture output.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: FrameCaptureOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FrameCaptureOutputSettings")]
        public FrameCaptureOutputSettings FrameCaptureOutputSettings { get; set; }

        /// <summary>
        /// HlsOutputSettings
        /// The settings for an HLS output.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: HlsOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsOutputSettings")]
        public HlsOutputSettings HlsOutputSettings { get; set; }

        /// <summary>
        /// RtmpOutputSettings
        /// The settings for an RTMP output.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: RtmpOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RtmpOutputSettings")]
        public RtmpOutputSettings RtmpOutputSettings { get; set; }

        /// <summary>
        /// UdpOutputSettings
        /// The settings for a UDP output.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: UdpOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UdpOutputSettings")]
        public UdpOutputSettings UdpOutputSettings { get; set; }

        /// <summary>
        /// MultiplexOutputSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: MultiplexOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MultiplexOutputSettings")]
        public MultiplexOutputSettings MultiplexOutputSettings { get; set; }

        /// <summary>
        /// ArchiveOutputSettings
        /// The settings for an archive output.
        /// Required: No
        /// Type: ArchiveOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArchiveOutputSettings")]
        public ArchiveOutputSettings ArchiveOutputSettings { get; set; }

    }
}
