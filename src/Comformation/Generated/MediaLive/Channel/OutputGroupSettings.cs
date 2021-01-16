using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputgroupsettings.html
    /// </summary>
    public class OutputGroupSettings
    {

        /// <summary>
        /// HlsGroupSettings
        /// The configuration of an HLS output group.
        /// Required: No
        /// Type: HlsGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsGroupSettings")]
        public HlsGroupSettings HlsGroupSettings { get; set; }

        /// <summary>
        /// FrameCaptureGroupSettings
        /// The configuration of a frame capture output group.
        /// Required: No
        /// Type: FrameCaptureGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FrameCaptureGroupSettings")]
        public FrameCaptureGroupSettings FrameCaptureGroupSettings { get; set; }

        /// <summary>
        /// MultiplexGroupSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: MultiplexGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MultiplexGroupSettings")]
        public MultiplexGroupSettings MultiplexGroupSettings { get; set; }

        /// <summary>
        /// ArchiveGroupSettings
        /// The configuration of an archive output group.
        /// The parent of this entity is OutputGroupSettings.
        /// Required: No
        /// Type: ArchiveGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArchiveGroupSettings")]
        public ArchiveGroupSettings ArchiveGroupSettings { get; set; }

        /// <summary>
        /// MediaPackageGroupSettings
        /// The configuration of a MediaPackage output group.
        /// Required: No
        /// Type: MediaPackageGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaPackageGroupSettings")]
        public MediaPackageGroupSettings MediaPackageGroupSettings { get; set; }

        /// <summary>
        /// UdpGroupSettings
        /// The configuration of a UDP output group.
        /// Required: No
        /// Type: UdpGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UdpGroupSettings")]
        public UdpGroupSettings UdpGroupSettings { get; set; }

        /// <summary>
        /// MsSmoothGroupSettings
        /// The configuration of a Microsoft Smooth output group.
        /// Required: No
        /// Type: MsSmoothGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MsSmoothGroupSettings")]
        public MsSmoothGroupSettings MsSmoothGroupSettings { get; set; }

        /// <summary>
        /// RtmpGroupSettings
        /// The configuration of an RTMP output group.
        /// Required: No
        /// Type: RtmpGroupSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RtmpGroupSettings")]
        public RtmpGroupSettings RtmpGroupSettings { get; set; }

    }
}
