using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Segment
{
    /// <summary>
    /// AWS::Pinpoint::Segment Demographic
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html
    /// </summary>
    public class Demographic
    {

        /// <summary>
        /// AppVersion
        /// The app version criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppVersion")]
        public SetDimension AppVersion { get; set; }

        /// <summary>
        /// DeviceType
        /// The device type criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceType")]
        public SetDimension DeviceType { get; set; }

        /// <summary>
        /// Platform
        /// The device platform criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Platform")]
        public SetDimension Platform { get; set; }

        /// <summary>
        /// Channel
        /// The channel criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Channel")]
        public SetDimension Channel { get; set; }

        /// <summary>
        /// Model
        /// The device model criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Model")]
        public SetDimension Model { get; set; }

        /// <summary>
        /// Make
        /// The device make criteria for the segment.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Make")]
        public SetDimension Make { get; set; }

    }
}
