using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile MetricToRetain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metrictoretain.html
    /// </summary>
    public class MetricToRetain
    {

        /// <summary>
        /// Metric
        /// A standard of measurement.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metric")]
        public Union<string, IntrinsicFunction> Metric { get; set; }

        /// <summary>
        /// MetricDimension
        /// The dimension of the metric.
        /// Required: No
        /// Type: MetricDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricDimension")]
        public MetricDimension MetricDimension { get; set; }

    }
}
