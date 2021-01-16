using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionDescription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captiondescription.html
    /// </summary>
    public class CaptionDescription
    {

        /// <summary>
        /// DestinationSettings
        /// Additional settings for a captions destination that depend on the destination type.
        /// Required: No
        /// Type: CaptionDestinationSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationSettings")]
        public CaptionDestinationSettings DestinationSettings { get; set; }

        /// <summary>
        /// LanguageCode
        /// An ISO 639-2 three-digit code. For more information, see http://www. loc. gov/standards/iso639-2/.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCode")]
        public Union<string, IntrinsicFunction> LanguageCode { get; set; }

        /// <summary>
        /// LanguageDescription
        /// Human-readable information to indicate the captions that are available for players (for example,
        /// English or Spanish).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageDescription")]
        public Union<string, IntrinsicFunction> LanguageDescription { get; set; }

        /// <summary>
        /// CaptionSelectorName
        /// Specifies which input captions selector to use as a captions source when generating output captions.
        /// This field should match a captionSelector name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaptionSelectorName")]
        public Union<string, IntrinsicFunction> CaptionSelectorName { get; set; }

        /// <summary>
        /// Name
        /// The name of the captions description. The name is used to associate a captions description with an
        /// output. Names must be unique within a channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
