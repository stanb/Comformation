using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Behavior
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior.html
    /// </summary>
    public class Behavior
    {

        /// <summary>
        /// Recency
        /// The dimension settings that are based on how recently an endpoint was active.
        /// Required: No
        /// Type: Recency
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Recency")]
        public Recency Recency { get; set; }

    }
}
