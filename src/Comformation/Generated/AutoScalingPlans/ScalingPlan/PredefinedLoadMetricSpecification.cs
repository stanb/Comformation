using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan PredefinedLoadMetricSpecification
    /// PredefinedLoadMetricSpecification is a subproperty of ScalingInstruction that specifies a predefined load
    /// metric for predictive scaling to use with AWS Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedloadmetricspecification.html
    /// </summary>
    public class PredefinedLoadMetricSpecification
    {

        /// <summary>
        /// PredefinedLoadMetricType
        /// The metric type.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ALBTargetGroupRequestCount | ASGTotalCPUUtilization | ASGTotalNetworkIn |
        /// ASGTotalNetworkOut
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedLoadMetricType")]
        public Union<string, IntrinsicFunction> PredefinedLoadMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBTargetGroupRequestCount and there is a target group for an Application Load
        /// Balancer attached to the Auto Scaling group.
        /// The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN. targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the
        /// target group ARN.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1023
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
