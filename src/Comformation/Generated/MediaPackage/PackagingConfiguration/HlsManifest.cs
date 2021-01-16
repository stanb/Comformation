using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration HlsManifest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-hlsmanifest.html
    /// </summary>
    public class HlsManifest
    {

        /// <summary>
        /// AdMarkers
        /// This setting controls ad markers in the packaged content. NONE omits SCTE-35 ad markers from the
        /// output. PASSTHROUGH copies SCTE-35 ad markers from the source content to the output. SCTE35_ENHANCED
        /// generates ad markers and blackout tags in the output, based on SCTE-35 messages in the source
        /// content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdMarkers")]
        public Union<string, IntrinsicFunction> AdMarkers { get; set; }

        /// <summary>
        /// IncludeIframeOnlyStream
        /// Applies to stream sets with a single video track only. When enabled, the output includes an
        /// additional I-frame only stream, along with the other tracks.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeIframeOnlyStream")]
        public Union<bool, IntrinsicFunction> IncludeIframeOnlyStream { get; set; }

        /// <summary>
        /// ManifestName
        /// A short string that&#39;s appended to the end of the endpoint URL to create a unique path to this
        /// packaging configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestName")]
        public Union<string, IntrinsicFunction> ManifestName { get; set; }

        /// <summary>
        /// ProgramDateTimeIntervalSeconds
        /// Inserts EXT-X-PROGRAM-DATE-TIME tags in the output manifest at the interval that you specify.
        /// Additionally, ID3Timed metadata messages are generated every 5 seconds starting when the content was
        /// ingested.
        /// Irrespective of this parameter, if any ID3Timed metadata is in the HLS input, it is passed through
        /// to the HLS output.
        /// Omit this attribute or enter 0 to indicate that the EXT-X-PROGRAM-DATE-TIME tags are not included in
        /// the manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramDateTimeIntervalSeconds")]
        public Union<int, IntrinsicFunction> ProgramDateTimeIntervalSeconds { get; set; }

        /// <summary>
        /// RepeatExtXKey
        /// Repeat the EXT-X-KEY directive for every media segment. This might result in an increase in client
        /// requests to the DRM server.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepeatExtXKey")]
        public Union<bool, IntrinsicFunction> RepeatExtXKey { get; set; }

        /// <summary>
        /// StreamSelection
        /// Video bitrate limitations for outputs from this packaging configuration.
        /// Required: No
        /// Type: StreamSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamSelection")]
        public StreamSelection StreamSelection { get; set; }

    }
}
