using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile MetricDimension
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// DimensionName
        /// The name of the dimension.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionName")]
        public Union<string, IntrinsicFunction> DimensionName { get; set; }

        /// <summary>
        /// Operator
        /// Operators are constructs that perform logical operations. Valid values are IN and NOT_IN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Operator")]
        public Union<string, IntrinsicFunction> Operator { get; set; }

    }
}
