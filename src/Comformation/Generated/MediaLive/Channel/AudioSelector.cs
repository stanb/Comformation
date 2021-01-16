using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioSelector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html
    /// </summary>
    public class AudioSelector
    {

        /// <summary>
        /// SelectorSettings
        /// Information about the specific audio to extract from the input.
        /// Required: No
        /// Type: AudioSelectorSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectorSettings")]
        public AudioSelectorSettings SelectorSettings { get; set; }

        /// <summary>
        /// Name
        /// A name for this AudioSelector.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
