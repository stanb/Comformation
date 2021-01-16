using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Eac3Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-eac3settings.html
    /// </summary>
    public class Eac3Settings
    {

        /// <summary>
        /// CodingMode
        /// The Dolby Digital Plus coding mode. This mode determines the number of channels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodingMode")]
        public Union<string, IntrinsicFunction> CodingMode { get; set; }

        /// <summary>
        /// SurroundMode
        /// When encoding 2/0 audio, sets whether Dolby Surround is matrix-encoded into the two channels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SurroundMode")]
        public Union<string, IntrinsicFunction> SurroundMode { get; set; }

        /// <summary>
        /// PassthroughControl
        /// When set to whenPossible, input DD+ audio will be passed through if it is present on the input. This
        /// detection is dynamic over the life of the transcode. Inputs that alternate between DD+ and non-DD+
        /// content will have a consistent DD+ output as the system alternates between passthrough and encoding.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PassthroughControl")]
        public Union<string, IntrinsicFunction> PassthroughControl { get; set; }

        /// <summary>
        /// Dialnorm
        /// Sets the dialnorm for the output. If blank and the input audio is Dolby Digital Plus, dialnorm will
        /// be passed through.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dialnorm")]
        public Union<int, IntrinsicFunction> Dialnorm { get; set; }

        /// <summary>
        /// LoRoSurroundMixLevel
        /// The Left only/Right only surround mix level. Used only for a 3/2 coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoRoSurroundMixLevel")]
        public Union<double, IntrinsicFunction> LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// PhaseControl
        /// When set to shift90Degrees, applies a 90-degree phase shift to the surround channels. Used only for
        /// a 3/2 coding mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhaseControl")]
        public Union<string, IntrinsicFunction> PhaseControl { get; set; }

        /// <summary>
        /// LtRtCenterMixLevel
        /// The Left total/Right total center mix level. Used only for a 3/2 coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LtRtCenterMixLevel")]
        public Union<double, IntrinsicFunction> LtRtCenterMixLevel { get; set; }

        /// <summary>
        /// LfeFilter
        /// When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding. Valid only
        /// with a codingMode32 coding mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LfeFilter")]
        public Union<string, IntrinsicFunction> LfeFilter { get; set; }

        /// <summary>
        /// LfeControl
        /// When encoding 3/2 audio, setting to lfe enables the LFE channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LfeControl")]
        public Union<string, IntrinsicFunction> LfeControl { get; set; }

        /// <summary>
        /// Bitrate
        /// The average bitrate in bits/second. Valid bitrates depend on the coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<double, IntrinsicFunction> Bitrate { get; set; }

        /// <summary>
        /// DrcLine
        /// Sets the Dolby dynamic range compression profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrcLine")]
        public Union<string, IntrinsicFunction> DrcLine { get; set; }

        /// <summary>
        /// DcFilter
        /// When set to enabled, activates a DC highpass filter for all input channels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DcFilter")]
        public Union<string, IntrinsicFunction> DcFilter { get; set; }

        /// <summary>
        /// MetadataControl
        /// When set to followInput, encoder metadata is sourced from the DD, DD+, or DolbyE decoder that
        /// supplies this audio data. If the audio is not supplied from one of these streams, then the static
        /// metadata settings are used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetadataControl")]
        public Union<string, IntrinsicFunction> MetadataControl { get; set; }

        /// <summary>
        /// LtRtSurroundMixLevel
        /// The Left total/Right total surround mix level. Used only for the 3/2 coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LtRtSurroundMixLevel")]
        public Union<double, IntrinsicFunction> LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// LoRoCenterMixLevel
        /// The Left only/Right only center mix level. Used only for the 3/2 coding mode.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoRoCenterMixLevel")]
        public Union<double, IntrinsicFunction> LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// DrcRf
        /// Sets the profile for heavy Dolby dynamic range compression, ensuring that the instantaneous signal
        /// peaks do not exceed specified levels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DrcRf")]
        public Union<string, IntrinsicFunction> DrcRf { get; set; }

        /// <summary>
        /// AttenuationControl
        /// When set to attenuate3Db, applies a 3 dB attenuation to the surround channels. Used only for the 3/2
        /// coding mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttenuationControl")]
        public Union<string, IntrinsicFunction> AttenuationControl { get; set; }

        /// <summary>
        /// BitstreamMode
        /// Specifies the bitstream mode (bsmod) for the emitted E-AC-3 stream. For more information, see ATSC
        /// A/52-2012 (Annex E).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BitstreamMode")]
        public Union<string, IntrinsicFunction> BitstreamMode { get; set; }

        /// <summary>
        /// SurroundExMode
        /// When encoding 3/2 audio, sets whether an extra center back surround channel is matrix encoded into
        /// the left and right surround channels.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SurroundExMode")]
        public Union<string, IntrinsicFunction> SurroundExMode { get; set; }

        /// <summary>
        /// StereoDownmix
        /// A stereo downmix preference. Used only for the 3/2 coding mode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StereoDownmix")]
        public Union<string, IntrinsicFunction> StereoDownmix { get; set; }

    }
}
