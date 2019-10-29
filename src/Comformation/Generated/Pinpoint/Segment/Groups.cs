using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Groups
    /// An array that defines the set of segment criteria to evaluate when handling segment groups for the segment.
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
        /// An array that defines the dimensions to include or exclude from the segment.
        /// Required: No
        /// Type: List of SegmentDimensions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<SegmentDimensions> Dimensions { get; set; }

        /// <summary>
        /// SourceSegments
        /// The base segment to build the segment on. A base segment, also called a source segment, defines the
        /// initial population of endpoints for a segment. When you add dimensions to the segment, Amazon
        /// Pinpoint filters the base segment by using the dimensions that you specify.
        /// You can specify more than one dimensional segment or only one imported segment. If you specify an
        /// imported segment, the segment size estimate that displays on the Amazon Pinpoint console indicates
        /// the size of the imported segment without any filters applied to it.
        /// Required: No
        /// Type: List of SourceSegments
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceSegments")]
        public List<SourceSegments> SourceSegments { get; set; }

    }
}
