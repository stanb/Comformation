using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Groups
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html
    /// </summary>
    public class Groups
    {

        /// <summary>
        /// Type
        /// Specifies how to handle multiple dimensions for the segment. For example, if you specify three
        /// dimensions for the segment, whether the resulting segment includes endpoints that match all, any, or
        /// none of the dimensions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// SourceType
        /// Specifies how to handle multiple base segments for the segment. For example, if you specify three
        /// base segments for the segment, whether the resulting segment is based on all, any, or none of the
        /// base segments.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceType")]
        public Union<string, IntrinsicFunction> SourceType { get; set; }

        /// <summary>
        /// Dimensions
        /// An array that defines the dimensions for the segment.
        /// Required: No
        /// Type: List of SegmentDimensions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<SegmentDimensions> Dimensions { get; set; }

        /// <summary>
        /// SourceSegments
        /// The base segment to build the segment on. A base segment, also referred to as a source segment,
        /// defines the initial population of endpoints for a segment. When you add dimensions to a segment,
        /// Amazon Pinpoint filters the base segment by using the dimensions that you specify. You can specify
        /// more than one dimensional segment or only one imported segment.
        /// Required: No
        /// Type: List of SourceSegments
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceSegments")]
        public List<SourceSegments> SourceSegments { get; set; }

    }
}
