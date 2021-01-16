using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioDescription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiodescription.html
    /// </summary>
    public class AudioDescription
    {

        /// <summary>
        /// AudioNormalizationSettings
        /// The advanced audio normalization settings.
        /// Required: No
        /// Type: AudioNormalizationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioNormalizationSettings")]
        public AudioNormalizationSettings AudioNormalizationSettings { get; set; }

        /// <summary>
        /// LanguageCode
        /// Indicates the language of the audio output track. Used only if languageControlMode is useConfigured,
        /// or there is no ISO 639 language code specified in the input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCode")]
        public Union<string, IntrinsicFunction> LanguageCode { get; set; }

        /// <summary>
        /// RemixSettings
        /// The settings that control how input audio channels are remixed into the output audio channels.
        /// Required: No
        /// Type: RemixSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemixSettings")]
        public RemixSettings RemixSettings { get; set; }

        /// <summary>
        /// AudioSelectorName
        /// The name of the AudioSelector that is used as the source for this AudioDescription.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public Union<string, IntrinsicFunction> AudioSelectorName { get; set; }

        /// <summary>
        /// StreamName
        /// Used for Microsoft Smooth and Apple HLS outputs. Indicates the name displayed by the player (for
        /// example, English or Director Commentary).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

        /// <summary>
        /// LanguageCodeControl
        /// Choosing followInput causes the ISO 639 language code of the output to follow the ISO 639 language
        /// code of the input. The languageCode setting is used when useConfigured is set, or when followInput
        /// is selected but there is no ISO 639 language code specified by the input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCodeControl")]
        public Union<string, IntrinsicFunction> LanguageCodeControl { get; set; }

        /// <summary>
        /// AudioType
        /// Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC
        /// 13818-1.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioType")]
        public Union<string, IntrinsicFunction> AudioType { get; set; }

        /// <summary>
        /// AudioTypeControl
        /// Determines how audio type is determined. followInput: If the input contains an ISO 639 audioType,
        /// then that value is passed through to the output. If the input contains no ISO 639 audioType, the
        /// value in Audio Type is included in the output. useConfigured: The value in Audio Type is included in
        /// the output. Note that this field and audioType are both ignored if inputType is broadcasterMixedAd.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioTypeControl")]
        public Union<string, IntrinsicFunction> AudioTypeControl { get; set; }

        /// <summary>
        /// CodecSettings
        /// The audio codec settings.
        /// Required: No
        /// Type: AudioCodecSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodecSettings")]
        public AudioCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Name
        /// The name of this AudioDescription. Outputs use this name to uniquely identify this AudioDescription.
        /// Description names should be unique within this channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
