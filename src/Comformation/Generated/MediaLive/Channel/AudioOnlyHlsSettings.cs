using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioOnlyHlsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioonlyhlssettings.html
    /// </summary>
    public class AudioOnlyHlsSettings
    {

        /// <summary>
        /// SegmentType
        /// Specifies the segment type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentType")]
        public Union<string, IntrinsicFunction> SegmentType { get; set; }

        /// <summary>
        /// AudioTrackType
        /// Four types of audio-only tracks are supported: Audio-Only Variant Stream The client can play back
        /// this audio-only stream instead of video in low-bandwidth scenarios. Represented as an
        /// EXT-X-STREAM-INF in the HLS manifest. Alternate Audio, Auto Select, Default Alternate rendition that
        /// the client should try to play back by default. Represented as an EXT-X-MEDIA in the HLS manifest
        /// with DEFAULT=YES, AUTOSELECT=YES Alternate Audio, Auto Select, Not Default Alternate rendition that
        /// the client might try to play back by default. Represented as an EXT-X-MEDIA in the HLS manifest with
        /// DEFAULT=NO, AUTOSELECT=YES Alternate Audio, not Auto Select Alternate rendition that the client will
        /// not try to play back by default. Represented as an EXT-X-MEDIA in the HLS manifest with DEFAULT=NO,
        /// AUTOSELECT=NO.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioTrackType")]
        public Union<string, IntrinsicFunction> AudioTrackType { get; set; }

        /// <summary>
        /// AudioOnlyImage
        /// Used with an audio-only stream. It must be a . jpg or . png file. If given, this image is used as
        /// the cover art for the audio-only output. Ideally, it should be formatted for an iPhone screen for
        /// two reasons. The iPhone does not resize the image; instead, it crops a centered image on the
        /// top/bottom and left/right. Additionally, this image file gets saved bit-for-bit into every 10-second
        /// segment file, so it increases bandwidth by {image file size} * {segment count} * {user count. }.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioOnlyImage")]
        public InputLocation AudioOnlyImage { get; set; }

        /// <summary>
        /// AudioGroupId
        /// Specifies the group that the audio rendition belongs to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioGroupId")]
        public Union<string, IntrinsicFunction> AudioGroupId { get; set; }

    }
}
