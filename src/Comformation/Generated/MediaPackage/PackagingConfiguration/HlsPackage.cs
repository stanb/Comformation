using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration HlsPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlspackage.html
    /// </summary>
    public class HlsPackage
    {

        /// <summary>
        /// Encryption
        /// Parameters for encrypting content.
        /// Required: No
        /// Type: HlsEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encryption")]
        public HlsEncryption Encryption { get; set; }

        /// <summary>
        /// HlsManifests
        /// A list of HLS manifest configurations that are available from this endpoint.
        /// Required: Yes
        /// Type: List of HlsManifest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsManifests")]
        public List<HlsManifest> HlsManifests { get; set; }

        /// <summary>
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each fragment. Actual fragments are rounded to the nearest multiple of the
        /// source fragment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

        /// <summary>
        /// UseAudioRenditionGroup
        /// When true, AWS Elemental MediaPackage bundles all audio tracks in a rendition group. All other
        /// tracks in the stream can be used with any audio rendition from the group.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseAudioRenditionGroup")]
        public Union<bool, IntrinsicFunction> UseAudioRenditionGroup { get; set; }

    }
}
