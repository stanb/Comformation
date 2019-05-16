using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy TargetTrackingScalingPolicyConfiguration
    /// TargetTrackingScalingPolicyConfiguration is a property of ScalingPolicy that specifies a target tracking
    /// scaling policy to use with Application Auto Scaling. Use a target tracking scaling policy to adjust the
    /// capacity of the specified scalable target in response to actual workloads, so that resource utilization
    /// remains at or near the target utilization value.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html
    /// </summary>
    public class TargetTrackingScalingPolicyConfiguration
    {

        /// <summary>
        /// CustomizedMetricSpecification
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// Required: No
        /// Type: CustomizedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedMetricSpecification")]
        public CustomizedMetricSpecification CustomizedMetricSpecification { get; set; }

        /// <summary>
        /// DisableScaleIn
        /// Indicates whether scale in by the target tracking scaling policy is disabled. If the value is true,
        /// scale in is disabled and the target tracking scaling policy won&#39;t remove capacity from the scalable
        /// resource. Otherwise, scale in is enabled and the target tracking scaling policy can remove capacity
        /// from the scalable resource. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public Union<bool, IntrinsicFunction> DisableScaleIn { get; set; }

        /// <summary>
        /// PredefinedMetricSpecification
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// Required: No
        /// Type: PredefinedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricSpecification")]
        public PredefinedMetricSpecification PredefinedMetricSpecification { get; set; }

        /// <summary>
        /// ScaleInCooldown
        /// The amount of time, in seconds, after a scale-in activity completes before another scale in activity
        /// can start.
        /// The cooldown period is used to block subsequent scale-in requests until it has expired. The
        /// intention is to scale in conservatively to protect your application&#39;s availability. However, if
        /// another alarm triggers a scale-out policy during the cooldown period after a scale-in, Application
        /// Auto Scaling scales out your scalable target immediately.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleInCooldown")]
        public Union<int, IntrinsicFunction> ScaleInCooldown { get; set; }

        /// <summary>
        /// ScaleOutCooldown
        /// The amount of time, in seconds, after a scale-out activity completes before another scale-out
        /// activity can start.
        /// While the cooldown period is in effect, the capacity that has been added by the previous scale-out
        /// event that initiated the cooldown is calculated as part of the desired capacity for the next scale
        /// out. The intention is to continuously (but not excessively) scale out.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleOutCooldown")]
        public Union<int, IntrinsicFunction> ScaleOutCooldown { get; set; }

        /// <summary>
        /// TargetValue
        /// The target value for the metric.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetValue")]
        public Union<double, IntrinsicFunction> TargetValue { get; set; }

    }
}
