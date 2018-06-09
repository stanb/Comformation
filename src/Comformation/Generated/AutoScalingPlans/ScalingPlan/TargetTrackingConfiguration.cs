using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan TargetTrackingConfiguration
    /// The TargetTrackingConfiguration property type specifies a target tracking policy for an AWS Auto Scaling
    /// scaling plan.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html
    /// </summary>
    public class TargetTrackingConfiguration
    {

        /// <summary>
        /// ScaleOutCooldown
        /// The amount of time, in seconds, after a scale out activity completes before another scale out
        /// activity can start. This value is not used if the scalable resource is an Auto Scaling group.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleOutCooldown")]
        public Union<int, IntrinsicFunction> ScaleOutCooldown { get; set; }

        /// <summary>
        /// TargetValue
        /// The target value for the metric. The range is 8. 515920e-109 to 1. 174271e+108 (Base 10) or 2e-360
        /// to 2e360 (Base 2).
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetValue")]
        public Union<double, IntrinsicFunction> TargetValue { get; set; }

        /// <summary>
        /// PredefinedScalingMetricSpecification
        /// A predefined metric.
        /// Required: No
        /// Type: AWS Auto Scaling ScalingPlan PredefinedScalingMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedScalingMetricSpecification")]
        public Union<PredefinedScalingMetricSpecification, IntrinsicFunction> PredefinedScalingMetricSpecification { get; set; }

        /// <summary>
        /// DisableScaleIn
        /// Indicates whether scale in by the target tracking policy is disabled. If the value is true, scale in
        /// is disabled and the target tracking policy won&#39;t remove capacity from the scalable resource.
        /// Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable
        /// resource. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public Union<bool, IntrinsicFunction> DisableScaleIn { get; set; }

        /// <summary>
        /// ScaleInCooldown
        /// The amount of time, in seconds, after a scale in activity completes before another scale in activity
        /// can start. This value is not used if the scalable resource is an Auto Scaling group.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleInCooldown")]
        public Union<int, IntrinsicFunction> ScaleInCooldown { get; set; }

        /// <summary>
        /// EstimatedInstanceWarmup
        /// The estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch
        /// metrics. This value is used only if the resource is an Auto Scaling group.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EstimatedInstanceWarmup")]
        public Union<int, IntrinsicFunction> EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// CustomizedScalingMetricSpecification
        /// A customized metric.
        /// Required: No
        /// Type: AWS Auto Scaling ScalingPlan CustomizedScalingMetricSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomizedScalingMetricSpecification")]
        public Union<CustomizedScalingMetricSpecification, IntrinsicFunction> CustomizedScalingMetricSpecification { get; set; }

    }
}
