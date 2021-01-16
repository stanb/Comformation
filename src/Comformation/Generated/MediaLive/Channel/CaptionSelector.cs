using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CaptionSelector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html
    /// </summary>
    public class CaptionSelector
    {

        /// <summary>
        /// LanguageCode
        /// When specified, this field indicates the three-letter language code of the captions track to extract
        /// from the source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LanguageCode")]
        public Union<string, IntrinsicFunction> LanguageCode { get; set; }

        /// <summary>
        /// SelectorSettings
        /// Information about the specific audio to extract from the input.
        /// Required: No
        /// Type: CaptionSelectorSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectorSettings")]
        public CaptionSelectorSettings SelectorSettings { get; set; }

        /// <summary>
        /// Name
        /// The name identifier for a captions selector. This name is used to associate this captions selector
        /// with one or more captions descriptions. Names must be unique within a channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
