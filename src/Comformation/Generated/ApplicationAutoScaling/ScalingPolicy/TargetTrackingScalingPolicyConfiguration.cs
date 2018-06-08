using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// Application Auto Scaling ScalingPolicy TargetTrackingScalingPolicyConfiguration
    /// Use the TargetTrackingScalingPolicyConfiguration property to configure a target tracking scaling policy. Use
    /// it to adjust upward or downward in response to actual workloads, so that capacity utilization remains at or
    /// near your target utilization. TargetTrackingScalingPolicyConfiguration is a property of the
    /// AWS::ApplicationAutoScaling::ScalingPolicy resource. For more information, see PutScalingPolicy in the
    /// Application Auto Scaling API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html
    /// </summary>
    public class TargetTrackingScalingPolicyConfiguration
    {

        /// <summary>
        /// CustomizedMetricSpecification
        /// This property is reserved for future use.
        /// Required: No
        /// Type: Application Auto Scaling ScalingPolicy CustomizedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedMetricSpecification")]
        public Union<CustomizedMetricSpecification, IntrinsicFunction> CustomizedMetricSpecification { get; set; }

        /// <summary>
        /// DisableScaleIn
        /// Indicates whether scale in by the target tracking policy is disabled. If the value is true, scale in
        /// is disabled and the target tracking policy won't remove capacity from the scalable resource.
        /// Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable
        /// resource. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public Union<bool, IntrinsicFunction> DisableScaleIn { get; set; }

        /// <summary>
        /// PredefinedMetricSpecification
        /// A predefined metric.
        /// Required: No
        /// Type: Application Auto Scaling ScalingPolicy PredefinedMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricSpecification")]
        public Union<PredefinedMetricSpecification, IntrinsicFunction> PredefinedMetricSpecification { get; set; }

        /// <summary>
        /// ScaleInCooldown
        /// The amount of time, in seconds, after a scale in activity completes before another scale in activity
        /// can start.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleInCooldown")]
        public Union<int, IntrinsicFunction> ScaleInCooldown { get; set; }

        /// <summary>
        /// ScaleOutCooldown
        /// The amount of time, in seconds, after a scale out activity completes before another scale out
        /// activity can start.
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
