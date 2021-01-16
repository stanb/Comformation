using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioTrack
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiotrack.html
    /// </summary>
    public class AudioTrack
    {

        /// <summary>
        /// Track
        /// 1-based integer value that maps to a specific audio track
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Track")]
        public Union<int, IntrinsicFunction> Track { get; set; }

    }
}
