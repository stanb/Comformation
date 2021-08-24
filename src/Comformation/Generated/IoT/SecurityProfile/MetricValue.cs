using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile MetricValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html
    /// </summary>
    public class MetricValue
    {

        /// <summary>
        /// Count
        /// If the comparisonOperator calls for a numeric value, use this to specify that numeric value to be
        /// compared with the metric.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<string, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// Cidrs
        /// If the comparisonOperator calls for a set of CIDRs, use this to specify that set to be compared with
        /// the metric.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidrs")]
        public List<Union<string, IntrinsicFunction>> Cidrs { get; set; }

        /// <summary>
        /// Ports
        /// If the comparisonOperator calls for a set of ports, use this to specify that set to be compared with
        /// the metric.
        /// Required: No
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ports")]
        public List<Union<int, IntrinsicFunction>> Ports { get; set; }

        /// <summary>
        /// Number
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Number")]
        public Union<double, IntrinsicFunction> Number { get; set; }

        /// <summary>
        /// Numbers
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Numbers")]
        public List<Union<double, IntrinsicFunction>> Numbers { get; set; }

        /// <summary>
        /// Strings
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Strings")]
        public List<Union<string, IntrinsicFunction>> Strings { get; set; }

    }
}
