using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel H265FilterSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-h265filtersettings.html
    /// </summary>
    public class H265FilterSettings
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
