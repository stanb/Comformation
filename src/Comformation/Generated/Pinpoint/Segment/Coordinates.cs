using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Coordinates
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates.html
    /// </summary>
    public class Coordinates
    {

        /// <summary>
        /// Latitude
        /// The latitude coordinate of the location.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Latitude")]
        public Union<double, IntrinsicFunction> Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// The longitude coordinate of the location.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Longitude")]
        public Union<double, IntrinsicFunction> Longitude { get; set; }

    }
}
