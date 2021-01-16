using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeGuruProfiler.ProfilingGroup
{
    /// <summary>
    /// AWS::CodeGuruProfiler::ProfilingGroup Channel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html
    /// </summary>
    public class Channel
    {

        /// <summary>
        /// channelId
        /// The channel ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("channelId")]
        public Union<string, IntrinsicFunction> channelId { get; set; }

        /// <summary>
        /// channelUri
        /// The channel URI.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("channelUri")]
        public Union<string, IntrinsicFunction> channelUri { get; set; }

    }
}
