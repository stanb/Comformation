using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionLanguageMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionlanguagemapping.html
    /// </summary>
    public class CaptionLanguageMapping
    {

        /// <summary>
        /// LanguageCode
        /// A three-character ISO 639-2 language code (see http://www. loc. gov/standards/iso639-2).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCode")]
        public Union<string, IntrinsicFunction> LanguageCode { get; set; }

        /// <summary>
        /// LanguageDescription
        /// The textual description of language.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageDescription")]
        public Union<string, IntrinsicFunction> LanguageDescription { get; set; }

        /// <summary>
        /// CaptionChannel
        /// The closed caption channel being described by this CaptionLanguageMapping. Each channel mapping must
        /// have a unique channel number (maximum of 4).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionChannel")]
        public Union<int, IntrinsicFunction> CaptionChannel { get; set; }

    }
}
