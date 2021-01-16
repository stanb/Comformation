using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment SetDimension
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-setdimension.html
    /// </summary>
    public class SetDimension
    {

        /// <summary>
        /// DimensionType
        /// The type of segment dimension to use. Valid values are: INCLUSIVE, endpoints that match the criteria
        /// are included in the segment; and, EXCLUSIVE, endpoints that match the criteria are excluded from the
        /// segment.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionType")]
        public Union<string, IntrinsicFunction> DimensionType { get; set; }

        /// <summary>
        /// Values
        /// The criteria values to use for the segment dimension. Depending on the value of the DimensionType
        /// property, endpoints are included or excluded from the segment if their values match the criteria
        /// values.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
