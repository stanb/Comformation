using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile Behavior
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html
    /// </summary>
    public class Behavior
    {

        /// <summary>
        /// Name
        /// The name you&#39;ve given to the behavior.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Metric
        /// What is measured by the behavior.
        /// Required: No
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

        /// <summary>
        /// Criteria
        /// The criteria that determine if a device is behaving normally in regard to the metric.
        /// Required: No
        /// Type: BehaviorCriteria
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Criteria")]
        public BehaviorCriteria Criteria { get; set; }

        /// <summary>
        /// SuppressAlerts
        /// The alert status. If you set the value to true, alerts will be suppressed.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SuppressAlerts")]
        public Union<bool, IntrinsicFunction> SuppressAlerts { get; set; }

    }
}
