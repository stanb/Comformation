using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel AssetPropertyTimestamp
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertytimestamp.html
    /// </summary>
    public class AssetPropertyTimestamp
    {

        /// <summary>
        /// OffsetInNanos
        /// The nanosecond offset converted from timeInSeconds. The valid range is between 0-999999999.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OffsetInNanos")]
        public Union<string, IntrinsicFunction> OffsetInNanos { get; set; }

        /// <summary>
        /// TimeInSeconds
        /// The timestamp, in seconds, in the Unix epoch format. The valid range is between 1-31556889864403199.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeInSeconds")]
        public Union<string, IntrinsicFunction> TimeInSeconds { get; set; }

    }
}
