using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint StreamSelection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-streamselection.html
    /// </summary>
    public class StreamSelection
    {

        /// <summary>
        /// MinVideoBitsPerSecond
        /// The lower limit of the bitrates that this endpoint serves. If the video track is below this
        /// threshold, then AWS Elemental MediaPackage excludes it from output. If you don&#39;t specify a value, it
        /// defaults to 0 bits per second.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinVideoBitsPerSecond")]
        public Union<int, IntrinsicFunction> MinVideoBitsPerSecond { get; set; }

        /// <summary>
        /// MaxVideoBitsPerSecond
        /// The upper limit of the bitrates that this endpoint serves. If the video track exceeds this
        /// threshold, then AWS Elemental MediaPackage excludes it from output. If you don&#39;t specify a value, it
        /// defaults to 2147483647 bits per second.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxVideoBitsPerSecond")]
        public Union<int, IntrinsicFunction> MaxVideoBitsPerSecond { get; set; }

        /// <summary>
        /// StreamOrder
        /// Order in which the different video bitrates are presented to the player.
        /// Valid values: ORIGINAL, VIDEO_BITRATE_ASCENDING, VIDEO_BITRATE_DESCENDING.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamOrder")]
        public Union<string, IntrinsicFunction> StreamOrder { get; set; }

    }
}
