using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy PredictiveScalingPredefinedMetricPair
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedmetricpair.html
    /// </summary>
    public class PredictiveScalingPredefinedMetricPair
    {

        /// <summary>
        /// PredefinedMetricType
        /// Indicates which metrics to use. There are two different types of metrics for each metric type: one
        /// is a load metric and one is a scaling metric. For example, if the metric type is ASGCPUUtilization,
        /// the Auto Scaling group&#39;s total CPU metric is used as the load metric, and the average CPU metric is
        /// used for the scaling metric.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALBRequestCount | ASGCPUUtilization | ASGNetworkIn | ASGNetworkOut
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public Union<string, IntrinsicFunction> PredefinedMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// A label that uniquely identifies a specific Application Load Balancer target group from which to
        /// determine the total and average request count served by your Auto Scaling group. You can&#39;t specify a
        /// resource label unless the target group is attached to the Auto Scaling group.
        /// You create the resource label by appending the final portion of the load balancer ARN and the final
        /// portion of the target group ARN into a single value, separated by a forward slash (/). The format of
        /// the resource label is:
        /// app/my-alb/778d41231b141a0f/targetgroup/my-alb-target-group/943f017f100becff.
        /// Where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the target
        /// group ARN.
        /// To find the ARN for an Application Load Balancer, use the DescribeLoadBalancers API operation. To
        /// find the ARN for the target group, use the DescribeTargetGroups API operation.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
