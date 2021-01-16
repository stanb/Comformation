using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule AssetPropertyTimestamp
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertytimestamp.html
    /// </summary>
    public class AssetPropertyTimestamp
    {

        /// <summary>
        /// OffsetInNanos
        /// Optional. A string that contains the nanosecond time offset. Accepts substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OffsetInNanos")]
        public Union<string, IntrinsicFunction> OffsetInNanos { get; set; }

        /// <summary>
        /// TimeInSeconds
        /// A string that contains the time in seconds since epoch. Accepts substitution templates.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeInSeconds")]
        public Union<string, IntrinsicFunction> TimeInSeconds { get; set; }

    }
}
