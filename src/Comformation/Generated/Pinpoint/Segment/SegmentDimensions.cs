using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment SegmentDimensions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html
    /// </summary>
    public class SegmentDimensions
    {

        /// <summary>
        /// Demographic
        /// The demographic-based criteria, such as device platform, for the segment.
        /// Required: No
        /// Type: Demographic
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Demographic")]
        public Demographic Demographic { get; set; }

        /// <summary>
        /// Metrics
        /// One or more custom metrics to use as criteria for the segment.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metrics")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Metrics { get; set; }

        /// <summary>
        /// Attributes
        /// One or more custom attributes to use as criteria for the segment.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Attributes { get; set; }

        /// <summary>
        /// Behavior
        /// The behavior-based criteria, such as how recently users have used your app, for the segment.
        /// Required: No
        /// Type: Behavior
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Behavior")]
        public Behavior Behavior { get; set; }

        /// <summary>
        /// UserAttributes
        /// One or more custom user attributes to use as criteria for the segment.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserAttributes")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UserAttributes { get; set; }

        /// <summary>
        /// Location
        /// The location-based criteria, such as region or GPS coordinates, for the segment.
        /// Required: No
        /// Type: Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Location Location { get; set; }

    }
}
