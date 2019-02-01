using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// Application Auto Scaling ScalingPolicy PredefinedMetricSpecification
    /// Use the PredefinedMetricSpecification property to configure a predefined metric for a target tracking policy
    /// to use with Application Auto Scaling. PredefinedMetricSpecification is a subproperty of the Application Auto
    /// Scaling ScalingPolicy TargetTrackingScalingPolicyConfiguration property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predefinedmetricspecification.html
    /// </summary>
    public class PredefinedMetricSpecification
    {

        /// <summary>
        /// PredefinedMetricType
        /// The metric type.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public Union<string, IntrinsicFunction> PredefinedMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group attached to the Spot fleet
        /// request or ECS service.
        /// The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the target
        /// group ARN.
        /// Required: No
        /// Type: String
        /// Length constraints: Minimum length of 1. Maximum length of 1023.
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
