using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Ac3Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ac3settings.html
    /// </summary>
    public class Ac3Settings
    {

        /// <summary>
        /// CodingMode
        /// The Dolby Digital coding mode. This determines the number of channels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodingMode")]
        public Union<string, IntrinsicFunction> CodingMode { get; set; }

        /// <summary>
        /// DrcProfile
        /// If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined
        /// in the Dolby Digital specification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrcProfile")]
        public Union<string, IntrinsicFunction> DrcProfile { get; set; }

        /// <summary>
        /// MetadataControl
        /// When set to followInput, encoder metadata is sourced from the DD, DD+, or DolbyE decoder that
        /// supplies this audio data. If the audio is supplied from one of these streams, the static metadata
        /// settings are used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetadataControl")]
        public Union<string, IntrinsicFunction> MetadataControl { get; set; }

        /// <summary>
        /// Dialnorm
        /// Sets the dialnorm for the output. If excluded and the input audio is Dolby Digital, dialnorm is
        /// passed through.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dialnorm")]
        public Union<int, IntrinsicFunction> Dialnorm { get; set; }

        /// <summary>
        /// LfeFilter
        /// When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding. This is
        /// valid only in codingMode32Lfe mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LfeFilter")]
        public Union<string, IntrinsicFunction> LfeFilter { get; set; }

        /// <summary>
        /// BitstreamMode
        /// Specifies the bitstream mode (bsmod) for the emitted AC-3 stream. For more information about these
        /// values, see ATSC A/52-2012.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BitstreamMode")]
        public Union<string, IntrinsicFunction> BitstreamMode { get; set; }

        /// <summary>
        /// Bitrate
        /// The average bitrate in bits/second. Valid bitrates depend on the coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<double, IntrinsicFunction> Bitrate { get; set; }

    }
}
