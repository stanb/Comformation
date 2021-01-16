using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel H265Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265settings.html
    /// </summary>
    public class H265Settings
    {

        /// <summary>
        /// Slices
        /// Number of slices per picture. Must be less than or equal to the number of macroblock rows for
        /// progressive pictures, and less than or equal to half the number of macroblock rows for interlaced
        /// pictures. This field is optional; when no value is specified the encoder will choose the number of
        /// slices based on encode resolution.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Slices")]
        public Union<int, IntrinsicFunction> Slices { get; set; }

        /// <summary>
        /// QvbrQualityLevel
        /// Controls the target quality for the video encode. Applies only when the rate control mode is QVBR.
        /// Set values for the QVBR quality level field and Max bitrate field that suit your most important
        /// viewing devices. Recommended values are: - Primary screen: Quality level: 8 to 10. Max bitrate: 4M -
        /// PC or tablet: Quality level: 7. Max bitrate: 1. 5M to 3M - Smartphone: Quality level: 6. Max
        /// bitrate: 1M to 1. 5M
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QvbrQualityLevel")]
        public Union<int, IntrinsicFunction> QvbrQualityLevel { get; set; }

        /// <summary>
        /// FramerateNumerator
        /// Framerate numerator - framerate is a fraction, e. g. 24000 / 1001 = 23. 976 fps.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateNumerator")]
        public Union<int, IntrinsicFunction> FramerateNumerator { get; set; }

        /// <summary>
        /// GopClosedCadence
        /// Frequency of closed GOPs. In streaming applications, it is recommended that this be set to 1 so a
        /// decoder joining mid-stream will receive an IDR frame as quickly as possible. Setting this value to 0
        /// will break output segmenting.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopClosedCadence")]
        public Union<int, IntrinsicFunction> GopClosedCadence { get; set; }

        /// <summary>
        /// FlickerAq
        /// If set to enabled, adjust quantization within each frame to reduce flicker or &#39;pop&#39; on I-frames.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlickerAq")]
        public Union<string, IntrinsicFunction> FlickerAq { get; set; }

        /// <summary>
        /// Profile
        /// H. 265 Profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Profile")]
        public Union<string, IntrinsicFunction> Profile { get; set; }

        /// <summary>
        /// MinIInterval
        /// Only meaningful if sceneChangeDetect is set to enabled. Defaults to 5 if multiplex rate control is
        /// used. Enforces separation between repeated (cadence) I-frames and I-frames inserted by Scene Change
        /// Detection. If a scene change I-frame is within I-interval frames of a cadence I-frame, the GOP is
        /// shrunk and/or stretched to the scene change I-frame. GOP stretch requires enabling lookahead as well
        /// as setting I-interval. The normal cadence resumes for the next GOP. Note: Maximum GOP stretch = GOP
        /// size + Min-I-interval - 1
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinIInterval")]
        public Union<int, IntrinsicFunction> MinIInterval { get; set; }

        /// <summary>
        /// SceneChangeDetect
        /// Scene change detection.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SceneChangeDetect")]
        public Union<string, IntrinsicFunction> SceneChangeDetect { get; set; }

        /// <summary>
        /// FramerateDenominator
        /// Framerate denominator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FramerateDenominator")]
        public Union<int, IntrinsicFunction> FramerateDenominator { get; set; }

        /// <summary>
        /// GopSize
        /// GOP size (keyframe interval) in units of either frames or seconds per gopSizeUnits. If gopSizeUnits
        /// is frames, gopSize must be an integer and must be greater than or equal to 1. If gopSizeUnits is
        /// seconds, gopSize must be greater than 0, but need not be an integer.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSize")]
        public Union<double, IntrinsicFunction> GopSize { get; set; }

        /// <summary>
        /// AdaptiveQuantization
        /// Adaptive quantization. Allows intra-frame quantizers to vary to improve visual quality.
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
        /// Type: H265FilterSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterSettings")]
        public H265FilterSettings FilterSettings { get; set; }

        /// <summary>
        /// AlternativeTransferFunction
        /// Whether or not EML should insert an Alternative Transfer Function SEI message to support backwards
        /// compatibility with non-HDR decoders and displays.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlternativeTransferFunction")]
        public Union<string, IntrinsicFunction> AlternativeTransferFunction { get; set; }

        /// <summary>
        /// ColorSpaceSettings
        /// Color Space settings
        /// Required: No
        /// Type: H265ColorSpaceSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorSpaceSettings")]
        public H265ColorSpaceSettings ColorSpaceSettings { get; set; }

        /// <summary>
        /// Tier
        /// H. 265 Tier.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tier")]
        public Union<string, IntrinsicFunction> Tier { get; set; }

        /// <summary>
        /// ParDenominator
        /// Pixel Aspect Ratio denominator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParDenominator")]
        public Union<int, IntrinsicFunction> ParDenominator { get; set; }

        /// <summary>
        /// FixedAfd
        /// Four bit AFD value to write on all frames of video in the output stream. Only valid when
        /// afdSignaling is set to &#39;Fixed&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FixedAfd")]
        public Union<string, IntrinsicFunction> FixedAfd { get; set; }

        /// <summary>
        /// GopSizeUnits
        /// Indicates if the gopSize is specified in frames or seconds. If seconds the system will convert the
        /// gopSize into a frame count at run time.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GopSizeUnits")]
        public Union<string, IntrinsicFunction> GopSizeUnits { get; set; }

        /// <summary>
        /// AfdSignaling
        /// Indicates that AFD values will be written into the output stream. If afdSignaling is &quot;auto&quot;, the
        /// system will try to preserve the input AFD value (in cases where multiple AFD values are valid). If
        /// set to &quot;fixed&quot;, the AFD value will be the value configured in the fixedAfd parameter.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AfdSignaling")]
        public Union<string, IntrinsicFunction> AfdSignaling { get; set; }

        /// <summary>
        /// Bitrate
        /// Average bitrate in bits/second. Required when the rate control mode is VBR or CBR. Not used for
        /// QVBR. In an MS Smooth output group, each output must have a unique value when its bitrate is rounded
        /// down to the nearest multiple of 1000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<int, IntrinsicFunction> Bitrate { get; set; }

        /// <summary>
        /// ParNumerator
        /// Pixel Aspect Ratio numerator.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParNumerator")]
        public Union<int, IntrinsicFunction> ParNumerator { get; set; }

        /// <summary>
        /// RateControlMode
        /// Rate control mode. QVBR: Quality will match the specified quality level except when it is
        /// constrained by the maximum bitrate. Recommended if you or your viewers pay for bandwidth. CBR:
        /// Quality varies, depending on the video complexity. Recommended only if you distribute your assets to
        /// devices that cannot handle variable bitrates. Multiplex: This rate control mode is only supported
        /// (and is required) when the video is being delivered to a MediaLive Multiplex in which case the rate
        /// control configuration is controlled by the properties within the Multiplex Program.
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
        /// Size of buffer (HRD buffer model) in bits.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufSize")]
        public Union<int, IntrinsicFunction> BufSize { get; set; }

        /// <summary>
        /// TimecodeInsertion
        /// Determines how timecodes should be inserted into the video elementary stream. - &#39;disabled&#39;: Do not
        /// include timecodes - &#39;picTimingSei&#39;: Pass through picture timing SEI messages from the source
        /// specified in Timecode Config
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimecodeInsertion")]
        public Union<string, IntrinsicFunction> TimecodeInsertion { get; set; }

        /// <summary>
        /// ColorMetadata
        /// Includes colorspace metadata in the output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColorMetadata")]
        public Union<string, IntrinsicFunction> ColorMetadata { get; set; }

        /// <summary>
        /// LookAheadRateControl
        /// Amount of lookahead. A value of low can decrease latency and memory usage, while high can produce
        /// better quality for certain content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LookAheadRateControl")]
        public Union<string, IntrinsicFunction> LookAheadRateControl { get; set; }

        /// <summary>
        /// Level
        /// H. 265 Level.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Level")]
        public Union<string, IntrinsicFunction> Level { get; set; }

        /// <summary>
        /// MaxBitrate
        /// For QVBR: See the tooltip for Quality level
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public Union<int, IntrinsicFunction> MaxBitrate { get; set; }

    }
}
