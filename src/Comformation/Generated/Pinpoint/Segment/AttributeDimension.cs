using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment AttributeDimension
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-attributedimension.html
    /// </summary>
    public class AttributeDimension
    {

        /// <summary>
        /// AttributeType
        /// The type of segment dimension to use. Valid values are:
        /// INCLUSIVE – endpoints that have attributes matching the values are included in the segment.
        /// EXCLUSIVE – endpoints that have attributes matching the values are excluded from the segment.
        /// CONTAINS – endpoints that have attributes&#39; substrings match the values are included in the segment.
        /// BEFORE – endpoints with attributes read as ISO_INSTANT datetimes before the value are included in
        /// the segment. AFTER - endpoints with attributes read as ISO_INSTANT datetimes after the value are
        /// included in the segment. BETWEEN - endpoints with attributes read as ISO_INSTANT datetimes between
        /// the values are included in the segment. ON - endpoints with attributes read as ISO_INSTANT dates on
        /// the value are included in the segment. Time is ignored in this comparison.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeType")]
        public Union<string, IntrinsicFunction> AttributeType { get; set; }

        /// <summary>
        /// Values
        /// The criteria values to use for the segment dimension. Depending on the value of the AttributeType
        /// property, endpoints are included or excluded from the segment if their attribute values match the
        /// criteria values.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
