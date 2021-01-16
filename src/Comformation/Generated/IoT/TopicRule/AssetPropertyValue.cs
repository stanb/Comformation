using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule AssetPropertyValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvalue.html
    /// </summary>
    public class AssetPropertyValue
    {

        /// <summary>
        /// Quality
        /// Optional. A string that describes the quality of the value. Accepts substitution templates. Must be
        /// GOOD, BAD, or UNCERTAIN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Quality")]
        public Union<string, IntrinsicFunction> Quality { get; set; }

        /// <summary>
        /// Timestamp
        /// The asset property value timestamp.
        /// Required: Yes
        /// Type: AssetPropertyTimestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timestamp")]
        public AssetPropertyTimestamp Timestamp { get; set; }

        /// <summary>
        /// Value
        /// The value of the asset property.
        /// Required: Yes
        /// Type: AssetPropertyVariant
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public AssetPropertyVariant Value { get; set; }

    }
}
