using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AvailBlanking
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availblanking.html
    /// </summary>
    public class AvailBlanking
    {

        /// <summary>
        /// State
        /// When set to enabled, the video, audio, and captions are blanked when insertion metadata is added.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// AvailBlankingImage
        /// The blanking image to be used. Keep empty for solid black. Only . bmp and . png images are
        /// supported.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailBlankingImage")]
        public InputLocation AvailBlankingImage { get; set; }

    }
}
