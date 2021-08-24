using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy PredictiveScalingPredefinedLoadMetric
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedloadmetric.html
    /// </summary>
    public class PredictiveScalingPredefinedLoadMetric
    {

        /// <summary>
        /// PredefinedMetricType
        /// The metric type.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALBTargetGroupRequestCount | ASGTotalCPUUtilization | ASGTotalNetworkIn |
        /// ASGTotalNetworkOut
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public Union<string, IntrinsicFunction> PredefinedMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// A label that uniquely identifies a specific Application Load Balancer target group from which to
        /// determine the request count served by your Auto Scaling group. You can&#39;t specify a resource label
        /// unless the target group is attached to the Auto Scaling group.
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
