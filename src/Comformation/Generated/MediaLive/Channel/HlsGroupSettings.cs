using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsgroupsettings.html
    /// </summary>
    public class HlsGroupSettings
    {

        /// <summary>
        /// SegmentationMode
        /// useInputSegmentation has been deprecated. The configured segment size is always used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentationMode")]
        public Union<string, IntrinsicFunction> SegmentationMode { get; set; }

        /// <summary>
        /// Destination
        /// A directory or HTTP destination for the HLS segments, manifest files, and encryption keys (if
        /// enabled).
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// CodecSpecification
        /// The specification to use (RFC-6381 or the default RFC-4281) during m3u8 playlist generation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodecSpecification")]
        public Union<string, IntrinsicFunction> CodecSpecification { get; set; }

        /// <summary>
        /// IvSource
        /// Used with encryptionType. The IV (initialization vector) is a 128-bit number used in conjunction
        /// with the key for encrypting blocks. If this setting is &quot;followsSegmentNumber,&quot; it causes the IV to
        /// change every segment (to match the segment number). If this is set to &quot;explicit,&quot; you must enter a
        /// constantIv value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IvSource")]
        public Union<string, IntrinsicFunction> IvSource { get; set; }

        /// <summary>
        /// TimedMetadataId3Frame
        /// Indicates the ID3 frame that has the timecode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataId3Frame")]
        public Union<string, IntrinsicFunction> TimedMetadataId3Frame { get; set; }

        /// <summary>
        /// KeyFormatVersions
        /// Either a single positive integer version value or a slash-delimited list of version values (1/2/3).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyFormatVersions")]
        public Union<string, IntrinsicFunction> KeyFormatVersions { get; set; }

        /// <summary>
        /// RedundantManifest
        /// ENABLED: The master manifest (. m3u8 file) for each pipeline includes information about both
        /// pipelines: first its own media files, then the media files of the other pipeline. This feature
        /// allows a playout device that supports stale manifest detection to switch from one manifest to the
        /// other, when the current manifest seems to be stale. There are still two destinations and two master
        /// manifests, but both master manifests reference the media files from both pipelines. DISABLED: The
        /// master manifest (. m3u8 file) for each pipeline includes information about its own pipeline only.
        /// For an HLS output group with MediaPackage as the destination, the DISABLED behavior is always
        /// followed. MediaPackage regenerates the manifests it serves to players, so a redundant manifest from
        /// MediaLive is irrelevant.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedundantManifest")]
        public Union<string, IntrinsicFunction> RedundantManifest { get; set; }

        /// <summary>
        /// OutputSelection
        /// MANIFESTSANDSEGMENTS: Generates manifests (the master manifest, if applicable, and media manifests)
        /// for this output group. SEGMENTSONLY: Doesn&#39;t generate any manifests for this output group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSelection")]
        public Union<string, IntrinsicFunction> OutputSelection { get; set; }

        /// <summary>
        /// KeyProviderSettings
        /// The key provider settings.
        /// Required: No
        /// Type: KeyProviderSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyProviderSettings")]
        public KeyProviderSettings KeyProviderSettings { get; set; }

        /// <summary>
        /// StreamInfResolution
        /// The include or exclude RESOLUTION attribute for a video in the EXT-X-STREAM-INF tag of a variant
        /// manifest.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamInfResolution")]
        public Union<string, IntrinsicFunction> StreamInfResolution { get; set; }

        /// <summary>
        /// CaptionLanguageMappings
        /// A mapping of up to 4 captions channels to captions languages. This is meaningful only if
        /// captionLanguageSetting is set to &quot;insert. &quot;
        /// Required: No
        /// Type: List of CaptionLanguageMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionLanguageMappings")]
        public List<CaptionLanguageMapping> CaptionLanguageMappings { get; set; }

        /// <summary>
        /// HlsId3SegmentTagging
        /// State of HLS ID3 Segment Tagging
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsId3SegmentTagging")]
        public Union<string, IntrinsicFunction> HlsId3SegmentTagging { get; set; }

        /// <summary>
        /// IFrameOnlyPlaylists
        /// DISABLED: Don&#39;t create an I-frame-only manifest, but do create the master and media manifests
        /// (according to the Output Selection field). STANDARD: Create an I-frame-only manifest for each output
        /// that contains video, as well as the other manifests (according to the Output Selection field). The
        /// I-frame manifest contains a #EXT-X-I-FRAMES-ONLY tag to indicate it is I-frame only, and one or more
        /// #EXT-X-BYTERANGE entries identifying the I-frame position. For example,
        /// #EXT-X-BYTERANGE:160364@1461888&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IFrameOnlyPlaylists")]
        public Union<string, IntrinsicFunction> IFrameOnlyPlaylists { get; set; }

        /// <summary>
        /// CaptionLanguageSetting
        /// Applies only to 608 embedded output captions. Insert: Include CLOSED-CAPTIONS lines in the manifest.
        /// Specify at least one language in the CC1 Language Code field. One CLOSED-CAPTION line is added for
        /// each Language Code that you specify. Make sure to specify the languages in the order in which they
        /// appear in the original source (if the source is embedded format) or the order of the captions
        /// selectors (if the source is other than embedded). Otherwise, languages in the manifest will not
        /// match properly with the output captions. None: Include the CLOSED-CAPTIONS=NONE line in the
        /// manifest. Omit: Omit any CLOSED-CAPTIONS line from the manifest.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionLanguageSetting")]
        public Union<string, IntrinsicFunction> CaptionLanguageSetting { get; set; }

        /// <summary>
        /// KeepSegments
        /// Applies only if the Mode field is LIVE. Specifies the number of media segments (. ts files) to
        /// retain in the destination directory.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeepSegments")]
        public Union<int, IntrinsicFunction> KeepSegments { get; set; }

        /// <summary>
        /// ConstantIv
        /// Used with encryptionType. This is a 128-bit, 16-byte hex value that is represented by a 32-character
        /// text string. If ivSource is set to &quot;explicit,&quot; this parameter is required and is used as the IV for
        /// encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstantIv")]
        public Union<string, IntrinsicFunction> ConstantIv { get; set; }

        /// <summary>
        /// DirectoryStructure
        /// Places segments in subdirectories.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DirectoryStructure")]
        public Union<string, IntrinsicFunction> DirectoryStructure { get; set; }

        /// <summary>
        /// EncryptionType
        /// Encrypts the segments with the specified encryption scheme. Exclude this parameter if you don&#39;t want
        /// encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionType")]
        public Union<string, IntrinsicFunction> EncryptionType { get; set; }

        /// <summary>
        /// AdMarkers
        /// Chooses one or more ad marker types to pass SCTE35 signals through to this group of Apple HLS
        /// outputs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdMarkers")]
        public List<Union<string, IntrinsicFunction>> AdMarkers { get; set; }

        /// <summary>
        /// HlsCdnSettings
        /// The parameters that control interactions with the CDN.
        /// Required: No
        /// Type: HlsCdnSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsCdnSettings")]
        public HlsCdnSettings HlsCdnSettings { get; set; }

        /// <summary>
        /// IndexNSegments
        /// Applies only if the Mode field is LIVE. Specifies the maximum number of segments in the media
        /// manifest file. After this maximum, older segments are removed from the media manifest. This number
        /// must be less than or equal to the Keep Segments field.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexNSegments")]
        public Union<int, IntrinsicFunction> IndexNSegments { get; set; }

        /// <summary>
        /// DiscontinuityTags
        /// Specifies whether to insert EXT-X-DISCONTINUITY tags in the HLS child manifests for this output
        /// group. Typically, choose Insert because these tags are required in the manifest (according to the
        /// HLS specification) and serve an important purpose. Choose Never Insert only if the downstream system
        /// is doing real-time failover (without using the MediaLive automatic failover feature) and only if
        /// that downstream system has advised you to exclude the tags.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DiscontinuityTags")]
        public Union<string, IntrinsicFunction> DiscontinuityTags { get; set; }

        /// <summary>
        /// InputLossAction
        /// A parameter that controls output group behavior on an input loss.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossAction")]
        public Union<string, IntrinsicFunction> InputLossAction { get; set; }

        /// <summary>
        /// Mode
        /// If &quot;vod,&quot; all segments are indexed and kept permanently in the destination and manifest. If &quot;live,&quot;
        /// only the number segments specified in keepSegments and indexNSegments are kept. Newer segments
        /// replace older segments, which might prevent players from rewinding all the way to the beginning of
        /// the channel. VOD mode uses HLS EXT-X-PLAYLIST-TYPE of EVENT while the channel is running, converting
        /// it to a &quot;VOD&quot; type manifest on completion of the stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// TsFileMode
        /// SEGMENTEDFILES: Emits the program as segments -multiple . ts media files. SINGLEFILE: Applies only
        /// if the Mode field is VOD. Emits the program as a single . ts media file. The media manifest includes
        /// #EXT-X-BYTERANGE tags to index segments for playback. A typical use for this value is when sending
        /// the output to AWS Elemental MediaConvert, which can accept only a single media file. Playback while
        /// the channel is running is not guaranteed due to HTTP server caching.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TsFileMode")]
        public Union<string, IntrinsicFunction> TsFileMode { get; set; }

        /// <summary>
        /// BaseUrlManifest1
        /// Optional. One value per output group. Complete this field only if you are completing Base URL
        /// manifest A, and the downstream system has notified you that the child manifest files for pipeline 1
        /// of all outputs are in a location different from the child manifest files for pipeline 0.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseUrlManifest1")]
        public Union<string, IntrinsicFunction> BaseUrlManifest1 { get; set; }

        /// <summary>
        /// ClientCache
        /// When set to &quot;disabled,&quot; sets the #EXT-X-ALLOW-CACHE:no tag in the manifest, which prevents clients
        /// from saving media segments for later replay.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientCache")]
        public Union<string, IntrinsicFunction> ClientCache { get; set; }

        /// <summary>
        /// MinSegmentLength
        /// When set, minimumSegmentLength is enforced by looking ahead and back within the specified range for
        /// a nearby avail and extending the segment size if needed.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinSegmentLength")]
        public Union<int, IntrinsicFunction> MinSegmentLength { get; set; }

        /// <summary>
        /// KeyFormat
        /// Specifies how the key is represented in the resource identified by the URI. If the parameter is
        /// absent, an implicit value of &quot;identity&quot; is used. A reverse DNS string can also be specified.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyFormat")]
        public Union<string, IntrinsicFunction> KeyFormat { get; set; }

        /// <summary>
        /// IvInManifest
        /// Used with encryptionType. The IV (initialization vector) is a 128-bit number used in conjunction
        /// with the key for encrypting blocks. If set to &quot;include,&quot; the IV is listed in the manifest.
        /// Otherwise, the IV is not in the manifest.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IvInManifest")]
        public Union<string, IntrinsicFunction> IvInManifest { get; set; }

        /// <summary>
        /// BaseUrlContent1
        /// Optional. One value per output group. This field is required only if you are completing Base URL
        /// content A, and the downstream system has notified you that the media files for pipeline 1 of all
        /// outputs are in a location different from the media files for pipeline 0.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseUrlContent1")]
        public Union<string, IntrinsicFunction> BaseUrlContent1 { get; set; }

        /// <summary>
        /// ManifestCompression
        /// When set to gzip, compresses HLS playlist.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestCompression")]
        public Union<string, IntrinsicFunction> ManifestCompression { get; set; }

        /// <summary>
        /// ManifestDurationFormat
        /// Indicates whether the output manifest should use a floating point or integer values for segment
        /// duration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestDurationFormat")]
        public Union<string, IntrinsicFunction> ManifestDurationFormat { get; set; }

        /// <summary>
        /// TimedMetadataId3Period
        /// The timed metadata interval, in seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataId3Period")]
        public Union<int, IntrinsicFunction> TimedMetadataId3Period { get; set; }

        /// <summary>
        /// IncompleteSegmentBehavior
        /// Specifies whether to include the final (incomplete) segment in the media output when the pipeline
        /// stops producing output because of a channel stop, a channel pause or a loss of input to the
        /// pipeline. Auto means that MediaLive decides whether to include the final segment, depending on the
        /// channel class and the types of output groups. Suppress means to never include the incomplete
        /// segment. We recommend you choose Auto and let MediaLive control the behavior.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncompleteSegmentBehavior")]
        public Union<string, IntrinsicFunction> IncompleteSegmentBehavior { get; set; }

        /// <summary>
        /// ProgramDateTimePeriod
        /// The period of insertion of the EXT-X-PROGRAM-DATE-TIME entry, in seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramDateTimePeriod")]
        public Union<int, IntrinsicFunction> ProgramDateTimePeriod { get; set; }

        /// <summary>
        /// SegmentLength
        /// The length of the MPEG-2 Transport Stream segments to create, in seconds. Note that segments will
        /// end on the next keyframe after this number of seconds, so the actual segment length might be longer.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentLength")]
        public Union<int, IntrinsicFunction> SegmentLength { get; set; }

        /// <summary>
        /// TimestampDeltaMilliseconds
        /// Provides an extra millisecond delta offset to fine tune the timestamps.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampDeltaMilliseconds")]
        public Union<int, IntrinsicFunction> TimestampDeltaMilliseconds { get; set; }

        /// <summary>
        /// ProgramDateTime
        /// Includes or excludes the EXT-X-PROGRAM-DATE-TIME tag in . m3u8 manifest files. The value is
        /// calculated as follows: Either the program date and time are initialized using the input timecode
        /// source, or the time is initialized using the input timecode source and the date is initialized using
        /// the timestampOffset.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramDateTime")]
        public Union<string, IntrinsicFunction> ProgramDateTime { get; set; }

        /// <summary>
        /// SegmentsPerSubdirectory
        /// The number of segments to write to a subdirectory before starting a new one. For this setting to
        /// have an effect, directoryStructure must be subdirectoryPerStream.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentsPerSubdirectory")]
        public Union<int, IntrinsicFunction> SegmentsPerSubdirectory { get; set; }

        /// <summary>
        /// BaseUrlContent
        /// A partial URI prefix that will be prepended to each output in the media . m3u8 file. The partial URI
        /// prefix can be used if the base manifest is delivered from a different URL than the main . m3u8 file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseUrlContent")]
        public Union<string, IntrinsicFunction> BaseUrlContent { get; set; }

        /// <summary>
        /// BaseUrlManifest
        /// A partial URI prefix that will be prepended to each output in the media . m3u8 file. The partial URI
        /// prefix can be used if the base manifest is delivered from a different URL than the main . m3u8 file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseUrlManifest")]
        public Union<string, IntrinsicFunction> BaseUrlManifest { get; set; }

    }
}
