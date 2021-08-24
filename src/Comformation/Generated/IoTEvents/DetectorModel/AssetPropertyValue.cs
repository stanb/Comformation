using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel AssetPropertyValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvalue.html
    /// </summary>
    public class AssetPropertyValue
    {

        /// <summary>
        /// Quality
        /// The quality of the asset property value. The value must be &#39;GOOD&#39;, &#39;BAD&#39;, or &#39;UNCERTAIN&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Quality")]
        public Union<string, IntrinsicFunction> Quality { get; set; }

        /// <summary>
        /// Timestamp
        /// The timestamp associated with the asset property value. The default is the current event time.
        /// Required: No
        /// Type: AssetPropertyTimestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timestamp")]
        public AssetPropertyTimestamp Timestamp { get; set; }

        /// <summary>
        /// Value
        /// The value to send to an asset property.
        /// Required: Yes
        /// Type: AssetPropertyVariant
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public AssetPropertyVariant Value { get; set; }

    }
}
