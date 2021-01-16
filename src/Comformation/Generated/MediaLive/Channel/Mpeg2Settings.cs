using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Mpeg2Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2settings.html
    /// </summary>
    public class Mpeg2Settings
    {

        /// <summary>
        /// ColorSpace
        /// Choose the type of color space conversion to apply to the output. For detailed information on
        /// setting up both the input and the output to obtain the desired color space in the output, see the
        /// section on \&quot;MediaLive Features - Video - color space\&quot; in the MediaLive User Guide. PASSTHROUGH:
        /// Keep the color space of the input content - do not convert it. AUTO:Convert all content that is SD
        /// to rec 601, and convert all content that is HD to rec 709.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpace")]
        public Union<string, IntrinsicFunction> ColorSpace { get; set; }

        /// <summary>
        /// FixedAfd
        /// Complete this field only when afdSignaling is set to FIXED. Enter the AFD value (4 bits) to write on
        /// all frames of the video encode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FixedAfd")]
        public Union<string, IntrinsicFunction> FixedAfd { get; set; }

        /// <summary>
        /// GopSizeUnits
        /// Relates to the GOP structure. Specifies whether the gopSize is specified in frames or seconds. If
        /// you do not plan to change the default gopSize, leave the default. If you specify SECONDS, MediaLive
        /// will internally convert the gop size to a frame count.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSizeUnits")]
        public Union<string, IntrinsicFunction> GopSizeUnits { get; set; }

        /// <summary>
        /// FramerateNumerator
        /// The framerate numerator. For example, 24000. The framerate is the numerator divided by the
        /// denominator. For example, 24000 / 1001 = 23. 976 FPS.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateNumerator")]
        public Union<int, IntrinsicFunction> FramerateNumerator { get; set; }

        /// <summary>
        /// GopClosedCadence
        /// MPEG2: default is open GOP.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopClosedCadence")]
        public Union<int, IntrinsicFunction> GopClosedCadence { get; set; }

        /// <summary>
        /// AfdSignaling
        /// Indicates the AFD values that MediaLive will write into the video encode. If you do not know what
        /// AFD signaling is, or if your downstream system has not given you guidance, choose AUTO. AUTO:
        /// MediaLive will try to preserve the input AFD value (in cases where multiple AFD values are valid).
        /// FIXED: MediaLive will use the value you specify in fixedAFD.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AfdSignaling")]
        public Union<string, IntrinsicFunction> AfdSignaling { get; set; }

        /// <summary>
        /// DisplayAspectRatio
        /// Sets the pixel aspect ratio for the encode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisplayAspectRatio")]
        public Union<string, IntrinsicFunction> DisplayAspectRatio { get; set; }

        /// <summary>
        /// ScanType
        /// Set the scan type of the output to PROGRESSIVE or INTERLACED (top field first).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScanType")]
        public Union<string, IntrinsicFunction> ScanType { get; set; }

        /// <summary>
        /// TimecodeInsertion
        /// Determines how MediaLive inserts timecodes in the output video. For detailed information about
        /// setting up the input and the output for a timecode, see the section on \&quot;MediaLive Features -
        /// Timecode configuration\&quot; in the MediaLive User Guide. DISABLED: do not include timecodes.
        /// GOP_TIMECODE: Include timecode metadata in the GOP header.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimecodeInsertion")]
        public Union<string, IntrinsicFunction> TimecodeInsertion { get; set; }

        /// <summary>
        /// ColorMetadata
        /// Specifies whether to include the color space metadata. The metadata describes the color space that
        /// applies to the video (the colorSpace field). We recommend that you insert the metadata.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorMetadata")]
        public Union<string, IntrinsicFunction> ColorMetadata { get; set; }

        /// <summary>
        /// FramerateDenominator
        /// description&quot;: &quot;The framerate denominator. For example, 1001. The framerate is the numerator divided
        /// by the denominator. For example, 24000 / 1001 = 23. 976 FPS.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateDenominator")]
        public Union<int, IntrinsicFunction> FramerateDenominator { get; set; }

        /// <summary>
        /// GopSize
        /// Relates to the GOP structure. The GOP size (keyframe interval) in the units specified in
        /// gopSizeUnits. If you do not know what GOP is, use the default. If gopSizeUnits is frames, then the
        /// gopSize must be an integer and must be greater than or equal to 1. If gopSizeUnits is seconds, the
        /// gopSize must be greater than 0, but does not need to be an integer.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSize")]
        public Union<double, IntrinsicFunction> GopSize { get; set; }

        /// <summary>
        /// AdaptiveQuantization
        /// Choose Off to disable adaptive quantization. Or choose another value to enable the quantizer and set
        /// its strength. The strengths are: Auto, Off, Low, Medium, High. When you enable this field, MediaLive
        /// allows intra-frame quantizers to vary, which might improve visual quality.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdaptiveQuantization")]
        public Union<string, IntrinsicFunction> AdaptiveQuantization { get; set; }

        /// <summary>
        /// SubgopLength
        /// Relates to the GOP structure. If you do not know what GOP is, use the default. FIXED: Set the number
        /// of B-frames in each sub-GOP to the value in gopNumBFrames. DYNAMIC: Let MediaLive optimize the
        /// number of B-frames in each sub-GOP, to improve visual quality.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubgopLength")]
        public Union<string, IntrinsicFunction> SubgopLength { get; set; }

        /// <summary>
        /// FilterSettings
        /// Optionally specify a noise reduction filter, which can improve quality of compressed content. If you
        /// do not choose a filter, no filter will be applied. TEMPORAL: This filter is useful for both source
        /// content that is noisy (when it has excessive digital artifacts) and source content that is clean.
        /// When the content is noisy, the filter cleans up the source content before the encoding phase, with
        /// these two effects: First, it improves the output video quality because the content has been cleaned
        /// up. Secondly, it decreases the bandwidth because MediaLive does not waste bits on encoding noise.
        /// When the content is reasonably clean, the filter tends to decrease the bitrate.
        /// Required: No
        /// Type: Mpeg2FilterSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterSettings")]
        public Mpeg2FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// GopNumBFrames
        /// Relates to the GOP structure. The number of B-frames between reference frames. If you do not know
        /// what a B-frame is, use the default.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopNumBFrames")]
        public Union<int, IntrinsicFunction> GopNumBFrames { get; set; }

    }
}
