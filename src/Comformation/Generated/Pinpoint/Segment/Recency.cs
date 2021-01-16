using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Recency
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html
    /// </summary>
    public class Recency
    {

        /// <summary>
        /// Duration
        /// The duration to use when determining whether an endpoint is active or inactive.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Duration")]
        public Union<string, IntrinsicFunction> Duration { get; set; }

        /// <summary>
        /// RecencyType
        /// The type of recency dimension to use for the segment. Valid values are: ACTIVE, endpoints that were
        /// active within the specified duration are included in the segment; and, INACTIVE, endpoints that
        /// weren&#39;t active within the specified duration are included in the segment.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecencyType")]
        public Union<string, IntrinsicFunction> RecencyType { get; set; }

    }
}
