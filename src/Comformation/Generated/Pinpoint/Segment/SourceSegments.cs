using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment SourceSegments
    /// The base segment to build the segment on. A base segment, also called a source segment, defines the initial
    /// population of endpoints for a segment. When you add dimensions to the segment, Amazon Pinpoint filters the
    /// base segment by using the dimensions that you specify.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups-sourcesegments.html
    /// </summary>
    public class SourceSegments
    {

        /// <summary>
        /// Version
        /// The version number of the source segment.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<int, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// Id
        /// The unique ID of the source segment.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
