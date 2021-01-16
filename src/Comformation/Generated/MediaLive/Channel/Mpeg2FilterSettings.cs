using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Mpeg2FilterSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mpeg2filtersettings.html
    /// </summary>
    public class Mpeg2FilterSettings
    {

        /// <summary>
        /// TemporalFilterSettings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: TemporalFilterSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemporalFilterSettings")]
        public TemporalFilterSettings TemporalFilterSettings { get; set; }

    }
}
