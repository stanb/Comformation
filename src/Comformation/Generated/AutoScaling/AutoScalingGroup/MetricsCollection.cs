using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// Amazon EC2 Auto Scaling AutoScalingGroup MetricsCollection
    /// The MetricsCollection is a property of the AWS::AutoScaling::AutoScalingGroup resource that describes the
    /// group metrics that an Amazon EC2 Auto Scaling group sends to Amazon CloudWatch. These metrics describe the
    /// group rather than any of its instances. For more information, see EnableMetricsCollection in the Amazon EC2
    /// Auto Scaling API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-metricscollection.html
    /// </summary>
    public class MetricsCollection
    {

        /// <summary>
        /// Granularity
        /// The frequency at which Amazon EC2 Auto Scaling sends aggregated data to CloudWatch. The only valid
        /// value is 1Minute.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Granularity")]
        public Union<string, IntrinsicFunction> Granularity { get; set; }

        /// <summary>
        /// Metrics
        /// The list of metrics to collect. If you don&#39;t specify any metrics, all metrics are enabled.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Metrics")]
        public List<Union<string, IntrinsicFunction>> Metrics { get; set; }

    }
}
