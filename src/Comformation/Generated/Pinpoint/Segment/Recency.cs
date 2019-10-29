using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Recency
    /// Specifies how recently segment members were active.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html
    /// </summary>
    public class Recency
    {

        /// <summary>
        /// Duration
        /// The duration to use when determining which users have been active or inactive with your app.
        /// Possible values: HR_24 | DAY_7 | DAY_14 | DAY_30.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Duration")]
        public Union<string, IntrinsicFunction> Duration { get; set; }

        /// <summary>
        /// RecencyType
        /// The type of recency dimension to use for the segment. Valid values are: ACTIVE and INACTIVE. If the
        /// value is ACTIVE, the segment includes users who have used your app within the specified duration are
        /// included in the segment. If the value is INACTIVE, the segment includes users who haven&#39;t used your
        /// app within the specified duration are included in the segment.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecencyType")]
        public Union<string, IntrinsicFunction> RecencyType { get; set; }

    }
}
