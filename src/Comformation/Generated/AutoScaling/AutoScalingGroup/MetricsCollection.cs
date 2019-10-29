using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup MetricsCollection
    /// MetricsCollection is a property of AutoScalingGroup that describes the group metrics that an Amazon EC2 Auto
    /// Scaling group sends to Amazon CloudWatch. These metrics describe the group rather than any of its instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-metricscollection.html
    /// </summary>
    public class MetricsCollection
    {

        /// <summary>
        /// Granularity
        /// The frequency at which Amazon EC2 Auto Scaling sends aggregated data to CloudWatch.
        /// Allowed Values: 1Minute
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Granularity")]
        public Union<string, IntrinsicFunction> Granularity { get; set; }

        /// <summary>
        /// Metrics
        /// The list of Auto Scaling group metrics to collect. If you specify Granularity and don&#39;t specify any
        /// metrics, all metrics are enabled.
        /// Allowed Values:
        /// GroupMinSize GroupMaxSize GroupDesiredCapacity GroupInServiceInstances GroupPendingInstances
        /// GroupStandbyInstances GroupTerminatingInstances GroupTotalInstances
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metrics")]
        public List<Union<string, IntrinsicFunction>> Metrics { get; set; }

    }
}
