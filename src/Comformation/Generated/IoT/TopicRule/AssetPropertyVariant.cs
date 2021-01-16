using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule AssetPropertyVariant
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvariant.html
    /// </summary>
    public class AssetPropertyVariant
    {

        /// <summary>
        /// BooleanValue
        /// Optional. A string that contains the boolean value (true or false) of the value entry. Accepts
        /// substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BooleanValue")]
        public Union<string, IntrinsicFunction> BooleanValue { get; set; }

        /// <summary>
        /// DoubleValue
        /// Optional. A string that contains the double value of the value entry. Accepts substitution
        /// templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DoubleValue")]
        public Union<string, IntrinsicFunction> DoubleValue { get; set; }

        /// <summary>
        /// IntegerValue
        /// Optional. A string that contains the integer value of the value entry. Accepts substitution
        /// templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntegerValue")]
        public Union<string, IntrinsicFunction> IntegerValue { get; set; }

        /// <summary>
        /// StringValue
        /// Optional. The string value of the value entry. Accepts substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
