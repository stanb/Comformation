using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Location
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location.html
    /// </summary>
    public class Location
    {

        /// <summary>
        /// GPSPoint
        /// The GPS location and range for the segment.
        /// Required: No
        /// Type: GPSPoint
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GPSPoint")]
        public GPSPoint GPSPoint { get; set; }

        /// <summary>
        /// Country
        /// The country or region code, in ISO 3166-1 alpha-2 format, for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Country")]
        public SetDimension Country { get; set; }

    }
}
