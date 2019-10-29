using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy PredefinedMetricSpecification
    /// PredefinedMetricSpecification is a subproperty of TargetTrackingConfiguration that configures a predefined
    /// metric for a target tracking policy to use with Amazon EC2 Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predefinedmetricspecification.html
    /// </summary>
    public class PredefinedMetricSpecification
    {

        /// <summary>
        /// PredefinedMetricType
        /// The metric type. The following predefined metrics are available.
        /// ASGAverageCPUUtilization - Average CPU utilization of the Auto Scaling group. ASGAverageNetworkIn -
        /// Average number of bytes received on all network interfaces by the Auto Scaling group.
        /// ASGAverageNetworkOut - Average number of bytes sent out on all network interfaces by the Auto
        /// Scaling group. ALBRequestCountPerTarget - Number of requests completed per target in an Application
        /// Load Balancer target group.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ALBRequestCountPerTarget | ASGAverageCPUUtilization | ASGAverageNetworkIn |
        /// ASGAverageNetworkOut
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public Union<string, IntrinsicFunction> PredefinedMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group attached to the Auto Scaling
        /// group.
        /// The format is app/load-balancer-name/load-balancer-id/targetgroup/target-group-name/target-group-id
        /// , where
        /// app/load-balancer-name/load-balancer-id is the final portion of the load balancer ARN, and
        /// targetgroup/target-group-name/target-group-id is the final portion of the target group ARN.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1023
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
