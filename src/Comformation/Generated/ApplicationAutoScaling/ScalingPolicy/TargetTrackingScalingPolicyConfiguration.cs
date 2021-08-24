using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy TargetTrackingScalingPolicyConfiguration
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
        /// target. Otherwise, scale in is enabled and the target tracking scaling policy can remove capacity
        /// from the scalable target. The default value is false.
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
        /// The amount of time, in seconds, after a scale-in activity completes before another scale-in activity
        /// can start.
        /// With the scale-in cooldown period, the intention is to scale in conservatively to protect your
        /// application’s availability, so scale-in activities are blocked until the cooldown period has
        /// expired. However, if another alarm triggers a scale-out activity during the scale-in cooldown
        /// period, Application Auto Scaling scales out the target immediately. In this case, the scale-in
        /// cooldown period stops and doesn&#39;t complete.
        /// Application Auto Scaling provides a default value of 600 for Amazon ElastiCache replication groups
        /// and a default value of 300 for the following scalable targets:
        /// ECS services Spot Fleet requests EMR clusters AppStream 2. 0 fleets Aurora DB clusters Amazon
        /// SageMaker endpoint variants Custom resources
        /// For all other scalable targets, the default value is 0:
        /// DynamoDB tables DynamoDB global secondary indexes Amazon Comprehend document classification and
        /// entity recognizer endpoints Lambda provisioned concurrency Amazon Keyspaces tables Amazon MSK broker
        /// storage
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleInCooldown")]
        public Union<int, IntrinsicFunction> ScaleInCooldown { get; set; }

        /// <summary>
        /// ScaleOutCooldown
        /// The amount of time, in seconds, to wait for a previous scale-out activity to take effect.
        /// With the scale-out cooldown period, the intention is to continuously (but not excessively) scale
        /// out. After Application Auto Scaling successfully scales out using a target tracking scaling policy,
        /// it starts to calculate the cooldown time. The scaling policy won&#39;t increase the desired capacity
        /// again unless either a larger scale out is triggered or the cooldown period ends. While the cooldown
        /// period is in effect, the capacity added by the initiating scale-out activity is calculated as part
        /// of the desired capacity for the next scale-out activity.
        /// Application Auto Scaling provides a default value of 600 for Amazon ElastiCache replication groups
        /// and a default value of 300 for the following scalable targets:
        /// ECS services Spot Fleet requests EMR clusters AppStream 2. 0 fleets Aurora DB clusters Amazon
        /// SageMaker endpoint variants Custom resources
        /// For all other scalable targets, the default value is 0:
        /// DynamoDB tables DynamoDB global secondary indexes Amazon Comprehend document classification and
        /// entity recognizer endpoints Lambda provisioned concurrency Amazon Keyspaces tables Amazon MSK broker
        /// storage
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScaleOutCooldown")]
        public Union<int, IntrinsicFunction> ScaleOutCooldown { get; set; }

        /// <summary>
        /// TargetValue
        /// The target value for the metric. Although this property accepts numbers of type Double, it won&#39;t
        /// accept values that are either too small or too large. Values must be in the range of -2^360 to
        /// 2^360. The value must be a valid number based on the choice of metric. For example, if the metric is
        /// CPU utilization, then the target value is a percent value that represents how much of the CPU can be
        /// used before scaling out.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetValue")]
        public Union<double, IntrinsicFunction> TargetValue { get; set; }

    }
}
