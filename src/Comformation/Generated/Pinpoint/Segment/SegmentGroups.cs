using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment SegmentGroups
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups.html
    /// </summary>
    public class SegmentGroups
    {

        /// <summary>
        /// Groups
        /// Specifies the set of segment criteria to evaluate when handling segment groups for the segment.
        /// Required: No
        /// Type: List of Groups
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Groups")]
        public List<Groups> Groups { get; set; }

        /// <summary>
        /// Include
        /// Specifies how to handle multiple segment groups for the segment. For example, if the segment
        /// includes three segment groups, whether the resulting segment includes endpoints that match all, any,
        /// or none of the segment groups.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Include")]
        public Union<string, IntrinsicFunction> Include { get; set; }

    }
}
