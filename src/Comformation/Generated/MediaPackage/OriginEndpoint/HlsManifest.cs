using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint HlsManifest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-hlsmanifest.html
    /// </summary>
    public class HlsManifest
    {

        /// <summary>
        /// Id
        /// The manifest ID is required and must be unique within the OriginEndpoint. The ID can&#39;t be changed
        /// after the endpoint is created.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// ManifestName
        /// A short string that&#39;s appended to the end of the endpoint URL to create a unique path to this
        /// endpoint. The manifestName on the HLSManifest object overrides the manifestName that you provided on
        /// the originEndpoint object.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestName")]
        public Union<string, IntrinsicFunction> ManifestName { get; set; }

        /// <summary>
        /// Url
        /// The URL that&#39;s used to request this manifest from this endpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// PlaylistWindowSeconds
        /// Time window (in seconds) contained in each parent manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PlaylistWindowSeconds")]
        public Union<int, IntrinsicFunction> PlaylistWindowSeconds { get; set; }

        /// <summary>
        /// PlaylistType
        /// When specified as either event or vod, a corresponding EXT-X-PLAYLIST-TYPE entry is included in the
        /// media playlist. Indicates if the playlist is live-to-VOD content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PlaylistType")]
        public Union<string, IntrinsicFunction> PlaylistType { get; set; }

        /// <summary>
        /// AdMarkers
        /// Controls how ad markers are included in the packaged endpoint. Valid values are none, passthrough,
        /// or scte35_enhanced.
        /// NONE - omits all SCTE-35 ad markers from the output. PASSTHROUGH - creates a copy in the output of
        /// the SCTE-35 ad markers (comments) taken directly from the input manifest. SCTE35_ENHANCED -
        /// generates ad markers and blackout tags in the output based on the SCTE-35 messages from the input
        /// manifest.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdMarkers")]
        public Union<string, IntrinsicFunction> AdMarkers { get; set; }

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
        /// IncludeIframeOnlyStream
        /// Applies to stream sets with a single video track only. When true, the stream set includes an
        /// additional I-frame only stream, along with the other tracks. If false, this extra stream is not
        /// included.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeIframeOnlyStream")]
        public Union<bool, IntrinsicFunction> IncludeIframeOnlyStream { get; set; }

        /// <summary>
        /// AdTriggers
        /// Specifies the SCTE-35 message types that MediaPackage treats as ad markers in the output manifest.
        /// Valid values:
        /// BREAK DISTRIBUTOR_ADVERTISEMENT DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY
        /// DISTRIBUTOR_PLACEMENT_OPPORTUNITY PROVIDER_ADVERTISEMENT PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY
        /// PROVIDER_PLACEMENT_OPPORTUNITY SPLICE_INSERT
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdTriggers")]
        public List<Union<string, IntrinsicFunction>> AdTriggers { get; set; }

        /// <summary>
        /// AdsOnDeliveryRestrictions
        /// The flags on SCTE-35 segmentation descriptors that have to be present for MediaPackage to insert ad
        /// markers in the output manifest. For information about SCTE-35 in MediaPackage, see SCTE-35 Message
        /// Options in AWS Elemental MediaPackage.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdsOnDeliveryRestrictions")]
        public Union<string, IntrinsicFunction> AdsOnDeliveryRestrictions { get; set; }

    }
}
