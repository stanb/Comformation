using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel H264Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h264settings.html
    /// </summary>
    public class H264Settings
    {

        /// <summary>
        /// NumRefFrames
        /// The number of reference frames to use. The encoder might use more than requested if you use B-frames
        /// or interlaced encoding.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRefFrames")]
        public Union<int, IntrinsicFunction> NumRefFrames { get; set; }

        /// <summary>
        /// TemporalAq
        /// If set to enabled, adjusts quantization within each frame based on the temporal variation of content
        /// complexity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemporalAq")]
        public Union<string, IntrinsicFunction> TemporalAq { get; set; }

        /// <summary>
        /// Slices
        /// The number of slices per picture. The number must be less than or equal to the number of macroblock
        /// rows for progressive pictures, and less than or equal to half the number of macroblock rows for
        /// interlaced pictures. This field is optional. If you don&#39;t specify a value, MediaLive chooses the
        /// number of slices based on the encode resolution.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slices")]
        public Union<int, IntrinsicFunction> Slices { get; set; }

        /// <summary>
        /// FramerateControl
        /// Indicates how the output video frame rate is specified. If you select &quot;specified,&quot; the output video
        /// frame rate is determined by framerateNumerator and framerateDenominator. If you select
        /// &quot;initializeFromSource,&quot; the output video frame rate is set equal to the input video frame rate of
        /// the first input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateControl")]
        public Union<string, IntrinsicFunction> FramerateControl { get; set; }

        /// <summary>
        /// QvbrQualityLevel
        /// Controls the target quality for the video encode. This applies only when the rate control mode is
        /// QVBR. Set values for the QVBR quality level field and Max bitrate field that suit your most
        /// important viewing devices. Recommended values are: - Primary screen: Quality level: 8 to 10. Max
        /// bitrate: 4M - PC or tablet: Quality level: 7. Max bitrate: 1. 5M to 3M - Smartphone: Quality level:
        /// 6. Max bitrate: 1M to 1. 5M.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QvbrQualityLevel")]
        public Union<int, IntrinsicFunction> QvbrQualityLevel { get; set; }

        /// <summary>
        /// FramerateNumerator
        /// The frame rate numerator. The frame rate is a fraction, for example, 24000/1001 = 23. 976 fps.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateNumerator")]
        public Union<int, IntrinsicFunction> FramerateNumerator { get; set; }

        /// <summary>
        /// ParControl
        /// Indicates how the output pixel aspect ratio is specified. If &quot;specified&quot; is selected, the output
        /// video pixel aspect ratio is determined by parNumerator and parDenominator. If &quot;initializeFromSource&quot;
        /// is selected, the output pixels aspect ratio will be set equal to the input video pixel aspect ratio
        /// of the first input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParControl")]
        public Union<string, IntrinsicFunction> ParControl { get; set; }

        /// <summary>
        /// GopClosedCadence
        /// The frequency of closed GOPs. In streaming applications, we recommend that you set this to 1 so that
        /// a decoder joining mid-stream will receive an IDR frame as quickly as possible. Setting this value to
        /// 0 will break output segmenting.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopClosedCadence")]
        public Union<int, IntrinsicFunction> GopClosedCadence { get; set; }

        /// <summary>
        /// FlickerAq
        /// If set to enabled, adjusts the quantization within each frame to reduce flicker or pop on I-frames.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlickerAq")]
        public Union<string, IntrinsicFunction> FlickerAq { get; set; }

        /// <summary>
        /// Profile
        /// An H. 264 profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Profile")]
        public Union<string, IntrinsicFunction> Profile { get; set; }

        /// <summary>
        /// QualityLevel
        /// Leave as STANDARD_QUALITY or choose a different value (which might result in additional costs to run
        /// the channel). - ENHANCED_QUALITY: Produces a slightly better video quality without an increase in
        /// the bitrate. Has an effect only when the Rate control mode is QVBR or CBR. If this channel is in a
        /// MediaLive multiplex, the value must be ENHANCED_QUALITY. - STANDARD_QUALITY: Valid for any Rate
        /// control mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QualityLevel")]
        public Union<string, IntrinsicFunction> QualityLevel { get; set; }

        /// <summary>
        /// MinIInterval
        /// Meaningful only if sceneChangeDetect is set to enabled. This setting enforces separation between
        /// repeated (cadence) I-frames and I-frames inserted by Scene Change Detection. If a scene change
        /// I-frame is within I-interval frames of a cadence I-frame, the GOP is shrunk or stretched to the
        /// scene change I-frame. GOP stretch requires enabling lookahead as well as setting the I-interval. The
        /// normal cadence resumes for the next GOP. Note that the maximum GOP stretch = GOP size +
        /// Min-I-interval - 1.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinIInterval")]
        public Union<int, IntrinsicFunction> MinIInterval { get; set; }

        /// <summary>
        /// SceneChangeDetect
        /// The scene change detection. On: inserts I-frames when the scene change is detected. Off: does not
        /// force an I-frame when the scene change is detected.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SceneChangeDetect")]
        public Union<string, IntrinsicFunction> SceneChangeDetect { get; set; }

        /// <summary>
        /// ForceFieldPictures
        /// This setting applies only when scan type is &quot;interlaced. &quot; It controls whether coding is performed
        /// on a field basis or on a frame basis. (When the video is progressive, the coding is always performed
        /// on a frame basis. ) enabled: Force MediaLive to code on a field basis, so that odd and even sets of
        /// fields are coded separately. disabled: Code the two sets of fields separately (on a field basis) or
        /// together (on a frame basis using PAFF), depending on what is most appropriate for the content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForceFieldPictures")]
        public Union<string, IntrinsicFunction> ForceFieldPictures { get; set; }

        /// <summary>
        /// FramerateDenominator
        /// The frame rate denominator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateDenominator")]
        public Union<int, IntrinsicFunction> FramerateDenominator { get; set; }

        /// <summary>
        /// Softness
        /// Softness. Selects a quantizer matrix. Larger values reduce high-frequency content in the encoded
        /// image.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Softness")]
        public Union<int, IntrinsicFunction> Softness { get; set; }

        /// <summary>
        /// GopSize
        /// The GOP size (keyframe interval) in units of either frames or seconds per gopSizeUnits. The value
        /// must be greater than zero.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSize")]
        public Union<double, IntrinsicFunction> GopSize { get; set; }

        /// <summary>
        /// AdaptiveQuantization
        /// The adaptive quantization. This allows intra-frame quantizers to vary to improve visual quality.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdaptiveQuantization")]
        public Union<string, IntrinsicFunction> AdaptiveQuantization { get; set; }

        /// <summary>
        /// FilterSettings
        /// Optional filters that you can apply to an encode.
        /// Required: No
        /// Type: H264FilterSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterSettings")]
        public H264FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// ColorSpaceSettings
        /// Settings to configure the color space handling for the video.
        /// Required: No
        /// Type: H264ColorSpaceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpaceSettings")]
        public H264ColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// EntropyEncoding
        /// The entropy encoding mode. Use cabac (must be in Main or High profile) or cavlc.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntropyEncoding")]
        public Union<string, IntrinsicFunction> EntropyEncoding { get; set; }

        /// <summary>
        /// SpatialAq
        /// If set to enabled, adjusts quantization within each frame based on the spatial variation of content
        /// complexity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpatialAq")]
        public Union<string, IntrinsicFunction> SpatialAq { get; set; }

        /// <summary>
        /// ParDenominator
        /// The Pixel Aspect Ratio denominator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParDenominator")]
        public Union<int, IntrinsicFunction> ParDenominator { get; set; }

        /// <summary>
        /// FixedAfd
        /// A four-bit AFD value to write on all frames of video in the output stream. Valid only when
        /// afdSignaling is set to Fixed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FixedAfd")]
        public Union<string, IntrinsicFunction> FixedAfd { get; set; }

        /// <summary>
        /// GopSizeUnits
        /// Indicates if the gopSize is specified in frames or seconds. If seconds, the system converts the
        /// gopSize into a frame count at runtime.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSizeUnits")]
        public Union<string, IntrinsicFunction> GopSizeUnits { get; set; }

        /// <summary>
        /// AfdSignaling
        /// Indicates that AFD values will be written into the output stream. If afdSignaling is auto, the
        /// system tries to preserve the input AFD value (in cases where multiple AFD values are valid). If set
        /// to fixed, the AFD value is the value configured in the fixedAfd parameter.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AfdSignaling")]
        public Union<string, IntrinsicFunction> AfdSignaling { get; set; }

        /// <summary>
        /// Bitrate
        /// The average bitrate in bits/second. This is required when the rate control mode is VBR or CBR. It
        /// isn&#39;t used for QVBR. In a Microsoft Smooth output group, each output must have a unique value when
        /// its bitrate is rounded down to the nearest multiple of 1000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<int, IntrinsicFunction> Bitrate { get; set; }

        /// <summary>
        /// ParNumerator
        /// The Pixel Aspect Ratio numerator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParNumerator")]
        public Union<int, IntrinsicFunction> ParNumerator { get; set; }

        /// <summary>
        /// RateControlMode
        /// The rate control mode. QVBR: The quality will match the specified quality level except when it is
        /// constrained by the maximum bitrate. We recommend this if you or your viewers pay for bandwidth. VBR:
        /// The quality and bitrate vary, depending on the video complexity. We recommend this instead of QVBR
        /// if you want to maintain a specific average bitrate over the duration of the channel. CBR: The
        /// quality varies, depending on the video complexity. We recommend this only if you distribute your
        /// assets to devices that can&#39;t handle variable bitrates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RateControlMode")]
        public Union<string, IntrinsicFunction> RateControlMode { get; set; }

        /// <summary>
        /// ScanType
        /// Sets the scan type of the output to progressive or top-field-first interlaced.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScanType")]
        public Union<string, IntrinsicFunction> ScanType { get; set; }

        /// <summary>
        /// BufSize
        /// The size of the buffer (HRD buffer model) in bits/second.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufSize")]
        public Union<int, IntrinsicFunction> BufSize { get; set; }

        /// <summary>
        /// TimecodeInsertion
        /// Determines how timecodes should be inserted into the video elementary stream. disabled: don&#39;t
        /// include timecodes. picTimingSei: pass through picture timing SEI messages from the source specified
        /// in Timecode Config.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimecodeInsertion")]
        public Union<string, IntrinsicFunction> TimecodeInsertion { get; set; }

        /// <summary>
        /// ColorMetadata
        /// Includes color space metadata in the output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorMetadata")]
        public Union<string, IntrinsicFunction> ColorMetadata { get; set; }

        /// <summary>
        /// BufFillPct
        /// The percentage of the buffer that should initially be filled (HRD buffer model).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufFillPct")]
        public Union<int, IntrinsicFunction> BufFillPct { get; set; }

        /// <summary>
        /// GopBReference
        /// If enabled, uses reference B frames for GOP structures that have B frames &amp;gt; 1.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopBReference")]
        public Union<string, IntrinsicFunction> GopBReference { get; set; }

        /// <summary>
        /// LookAheadRateControl
        /// The amount of lookahead. A value of low can decrease latency and memory usage, while high can
        /// produce better quality for certain content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LookAheadRateControl")]
        public Union<string, IntrinsicFunction> LookAheadRateControl { get; set; }

        /// <summary>
        /// Level
        /// The H. 264 level.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Level")]
        public Union<string, IntrinsicFunction> Level { get; set; }

        /// <summary>
        /// MaxBitrate
        /// For QVBR: See the tooltip for Quality level. For VBR: Set the maximum bitrate in order to
        /// accommodate expected spikes in the complexity of the video.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public Union<int, IntrinsicFunction> MaxBitrate { get; set; }

        /// <summary>
        /// Syntax
        /// Produces a bitstream that is compliant with SMPTE RP-2027.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Syntax")]
        public Union<string, IntrinsicFunction> Syntax { get; set; }

        /// <summary>
        /// SubgopLength
        /// If set to fixed, uses gopNumBFrames B-frames per sub-GOP. If set to dynamic, optimizes the number of
        /// B-frames used for each sub-GOP to improve visual quality.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubgopLength")]
        public Union<string, IntrinsicFunction> SubgopLength { get; set; }

        /// <summary>
        /// GopNumBFrames
        /// The number of B-frames between reference frames.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopNumBFrames")]
        public Union<int, IntrinsicFunction> GopNumBFrames { get; set; }

    }
}
