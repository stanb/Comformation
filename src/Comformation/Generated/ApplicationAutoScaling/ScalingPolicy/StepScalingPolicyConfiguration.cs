using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy StepScalingPolicyConfiguration
    /// StepScalingPolicyConfiguration is a property of ScalingPolicy that specifies a step scaling policy
    /// configuration to use with Application Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html
    /// </summary>
    public class StepScalingPolicyConfiguration
    {

        /// <summary>
        /// AdjustmentType
        /// Specifies whether the ScalingAdjustment value in the StepAdjustment property is an absolute number
        /// or a percentage of the current capacity.
        /// Required: No
        /// Type: String
        /// Allowed Values: ChangeInCapacity | ExactCapacity | PercentChangeInCapacity
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

        /// <summary>
        /// Cooldown
        /// The amount of time, in seconds, after a scaling activity completes where previous trigger-related
        /// scaling activities can influence future scaling events.
        /// For scale-out policies, while the cooldown period is in effect, the capacity that has been added by
        /// the previous scale-out event that initiated the cooldown is calculated as part of the desired
        /// capacity for the next scale out. The intention is to continuously (but not excessively) scale out.
        /// For example, an alarm triggers a step scaling policy to scale out an Amazon ECS service by 2 tasks,
        /// the scaling activity completes successfully, and a cooldown period of 5 minutes starts. During the
        /// cooldown period, if the alarm triggers the same policy again but at a more aggressive step
        /// adjustment to scale out the service by 3 tasks, the 2 tasks that were added in the previous
        /// scale-out event are considered part of that capacity and only 1 additional task is added to the
        /// desired count.
        /// For scale-in policies, the cooldown period is used to block subsequent scale-in requests until it
        /// has expired. The intention is to scale in conservatively to protect your application&#39;s availability.
        /// However, if another alarm triggers a scale-out policy during the cooldown period after a scale-in,
        /// Application Auto Scaling scales out your scalable target immediately.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cooldown")]
        public Union<int, IntrinsicFunction> Cooldown { get; set; }

        /// <summary>
        /// MetricAggregationType
        /// The aggregation type for the CloudWatch metrics. Valid values are Minimum, Maximum, and Average. If
        /// the aggregation type is null, the value is treated as Average.
        /// Required: No
        /// Type: String
        /// Allowed Values: Average | Maximum | Minimum
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricAggregationType")]
        public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

        /// <summary>
        /// MinAdjustmentMagnitude
        /// The minimum number to adjust your scalable dimension as a result of a scaling activity. If the
        /// adjustment type is PercentChangeInCapacity, the scaling policy changes the scalable dimension of the
        /// scalable target by this amount.
        /// For example, suppose that you create a step scaling policy to scale out an Amazon ECS service by 25
        /// percent and you specify a MinAdjustmentMagnitude of 2. If the service has 4 tasks and the scaling
        /// policy is performed, 25 percent of 4 is 1. However, because you specified a MinAdjustmentMagnitude
        /// of 2, Application Auto Scaling scales out the service by 2 tasks.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinAdjustmentMagnitude")]
        public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// StepAdjustments
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// Required: No
        /// Type: List of StepAdjustment
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepAdjustments")]
        public List<StepAdjustment> StepAdjustments { get; set; }

    }
}
