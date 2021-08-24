using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html
    /// </summary>
    public class InputSettings
    {

        /// <summary>
        /// DeblockFilter
        /// Enables or disables the deblock filter when filtering.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeblockFilter")]
        public Union<string, IntrinsicFunction> DeblockFilter { get; set; }

        /// <summary>
        /// FilterStrength
        /// Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterStrength")]
        public Union<int, IntrinsicFunction> FilterStrength { get; set; }

        /// <summary>
        /// InputFilter
        /// Turns on the filter for this input. MPEG-2 inputs have the deblocking filter enabled by default. 1)
        /// auto - filtering is applied depending on input type/quality 2) disabled - no filtering is applied to
        /// the input 3) forced - filtering is applied regardless of the input type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputFilter")]
        public Union<string, IntrinsicFunction> InputFilter { get; set; }

        /// <summary>
        /// SourceEndBehavior
        /// The loop input if it is a file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceEndBehavior")]
        public Union<string, IntrinsicFunction> SourceEndBehavior { get; set; }

        /// <summary>
        /// VideoSelector
        /// Information about one video to extract from the input.
        /// Required: No
        /// Type: VideoSelector
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoSelector")]
        public VideoSelector VideoSelector { get; set; }

        /// <summary>
        /// Smpte2038DataPreference
        /// Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in this input.
        /// Applicable data types are captions, timecode, AFD, and SCTE-104 messages. - PREFER: Extract from
        /// SMPTE-2038 if present in this input, otherwise extract from another source (if any). - IGNORE: Never
        /// extract any ancillary data from SMPTE-2038.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Smpte2038DataPreference")]
        public Union<string, IntrinsicFunction> Smpte2038DataPreference { get; set; }

        /// <summary>
        /// AudioSelectors
        /// Information about the specific audio to extract from the input.
        /// The parent of this entity is InputSettings.
        /// Required: No
        /// Type: List of AudioSelector
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioSelectors")]
        public List<AudioSelector> AudioSelectors { get; set; }

        /// <summary>
        /// CaptionSelectors
        /// Information about the specific captions to extract from the input.
        /// Required: No
        /// Type: List of CaptionSelector
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionSelectors")]
        public List<CaptionSelector> CaptionSelectors { get; set; }

        /// <summary>
        /// DenoiseFilter
        /// Enables or disables the denoise filter when filtering.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DenoiseFilter")]
        public Union<string, IntrinsicFunction> DenoiseFilter { get; set; }

        /// <summary>
        /// NetworkInputSettings
        /// Information about how to connect to the upstream system.
        /// Required: No
        /// Type: NetworkInputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInputSettings")]
        public NetworkInputSettings NetworkInputSettings { get; set; }

    }
}
