using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel AssetPropertyVariant
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvariant.html
    /// </summary>
    public class AssetPropertyVariant
    {

        /// <summary>
        /// DoubleValue
        /// The asset property value is a double. You must use an expression, and the evaluated result should be
        /// a double.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DoubleValue")]
        public Union<string, IntrinsicFunction> DoubleValue { get; set; }

        /// <summary>
        /// IntegerValue
        /// The asset property value is an integer. You must use an expression, and the evaluated result should
        /// be an integer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntegerValue")]
        public Union<string, IntrinsicFunction> IntegerValue { get; set; }

        /// <summary>
        /// BooleanValue
        /// The asset property value is a Boolean value that must be &#39;TRUE&#39; or &#39;FALSE&#39;. You must use an
        /// expression, and the evaluated result should be a Boolean value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BooleanValue")]
        public Union<string, IntrinsicFunction> BooleanValue { get; set; }

        /// <summary>
        /// StringValue
        /// The asset property value is a string. You must use an expression, and the evaluated result should be
        /// a string.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
