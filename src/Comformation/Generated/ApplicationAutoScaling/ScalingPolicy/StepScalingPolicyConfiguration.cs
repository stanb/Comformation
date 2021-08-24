using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy StepScalingPolicyConfiguration
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
        /// Allowed values: ChangeInCapacity | ExactCapacity | PercentChangeInCapacity
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

        /// <summary>
        /// Cooldown
        /// The amount of time, in seconds, to wait for a previous scaling activity to take effect.
        /// With scale-out policies, the intention is to continuously (but not excessively) scale out. After
        /// Application Auto Scaling successfully scales out using a step scaling policy, it starts to calculate
        /// the cooldown time. The scaling policy won&#39;t increase the desired capacity again unless either a
        /// larger scale out is triggered or the cooldown period ends. While the cooldown period is in effect,
        /// capacity added by the initiating scale-out activity is calculated as part of the desired capacity
        /// for the next scale-out activity. For example, when an alarm triggers a step scaling policy to
        /// increase the capacity by 2, the scaling activity completes successfully, and a cooldown period
        /// starts. If the alarm triggers again during the cooldown period but at a more aggressive step
        /// adjustment of 3, the previous increase of 2 is considered part of the current capacity. Therefore,
        /// only 1 is added to the capacity.
        /// With scale-in policies, the intention is to scale in conservatively to protect your application’s
        /// availability, so scale-in activities are blocked until the cooldown period has expired. However, if
        /// another alarm triggers a scale-out activity during the cooldown period after a scale-in activity,
        /// Application Auto Scaling scales out the target immediately. In this case, the cooldown period for
        /// the scale-in activity stops and doesn&#39;t complete.
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
        [JsonProperty("Cooldown")]
        public Union<int, IntrinsicFunction> Cooldown { get; set; }

        /// <summary>
        /// MetricAggregationType
        /// The aggregation type for the CloudWatch metrics. Valid values are Minimum, Maximum, and Average. If
        /// the aggregation type is null, the value is treated as Average.
        /// Required: No
        /// Type: String
        /// Allowed values: Average | Maximum | Minimum
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricAggregationType")]
        public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

        /// <summary>
        /// MinAdjustmentMagnitude
        /// The minimum value to scale by when the adjustment type is PercentChangeInCapacity. For example,
        /// suppose that you create a step scaling policy to scale out an Amazon ECS service by 25 percent and
        /// you specify a MinAdjustmentMagnitude of 2. If the service has 4 tasks and the scaling policy is
        /// performed, 25 percent of 4 is 1. However, because you specified a MinAdjustmentMagnitude of 2,
        /// Application Auto Scaling scales out the service by 2 tasks.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinAdjustmentMagnitude")]
        public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// StepAdjustments
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// At least one step adjustment is required if you are adding a new step scaling policy configuration.
        /// Required: No
        /// Type: List of StepAdjustment
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepAdjustments")]
        public List<StepAdjustment> StepAdjustments { get; set; }

    }
}
