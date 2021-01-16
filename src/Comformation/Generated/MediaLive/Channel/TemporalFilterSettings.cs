using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel TemporalFilterSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-temporalfiltersettings.html
    /// </summary>
    public class TemporalFilterSettings
    {

        /// <summary>
        /// PostFilterSharpening
        /// If you enable this filter, the results are the following: - If the source content is noisy (it
        /// contains excessive digital artifacts), the filter cleans up the source. - If the source content is
        /// already clean, the filter tends to decrease the bitrate, especially when the rate control mode is
        /// QVBR.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PostFilterSharpening")]
        public Union<string, IntrinsicFunction> PostFilterSharpening { get; set; }

        /// <summary>
        /// Strength
        /// Choose a filter strength. We recommend a strength of 1 or 2. A higher strength might take out good
        /// information, resulting in an image that is overly soft.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Strength")]
        public Union<string, IntrinsicFunction> Strength { get; set; }

    }
}
