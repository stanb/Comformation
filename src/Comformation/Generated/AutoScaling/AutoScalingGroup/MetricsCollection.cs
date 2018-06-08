using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup MetricsCollection
    /// The MetricsCollection is a property of the AWS::AutoScaling::AutoScalingGroup resource that describes the
    /// group metrics that an Auto Scaling group sends to CloudWatch. These metrics describe the group rather than any
    /// of its instances. For more information, see EnableMetricsCollection in the Amazon EC2 Auto Scaling API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-metricscollection.html
    /// </summary>
    public class MetricsCollection
    {

        /// <summary>
        /// Granularity
        /// The frequency at which Auto Scaling sends aggregated data to CloudWatch. For example, you can
        /// specify 1Minute to send aggregated data to CloudWatch every minute.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Granularity")]
        public Union<string, IntrinsicFunction> Granularity { get; set; }

        /// <summary>
        /// Metrics
        /// The list of metrics to collect. If you don't specify any metrics, all metrics are enabled.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Metrics")]
        public Union<List<string>, IntrinsicFunction> Metrics { get; set; }

    }
}
