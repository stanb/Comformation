using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment GPSPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint.html
    /// </summary>
    public class GPSPoint
    {

        /// <summary>
        /// RangeInKilometers
        /// The range, in kilometers, from the GPS coordinates.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeInKilometers")]
        public Union<double, IntrinsicFunction> RangeInKilometers { get; set; }

        /// <summary>
        /// Coordinates
        /// The GPS coordinates to measure distance from.
        /// Required: Yes
        /// Type: Coordinates
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Coordinates")]
        public Coordinates Coordinates { get; set; }

    }
}
