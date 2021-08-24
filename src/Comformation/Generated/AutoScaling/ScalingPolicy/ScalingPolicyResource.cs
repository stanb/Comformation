using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// AdjustmentType
            /// Specifies how the scaling adjustment is interpreted. The valid values are ChangeInCapacity,
            /// ExactCapacity, and PercentChangeInCapacity.
            /// Required if the policy type is StepScaling or SimpleScaling. For more information, see Scaling
            /// adjustment types in the Amazon EC2 Auto Scaling User Guide.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

            /// <summary>
            /// AutoScalingGroupName
            /// The name of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// Cooldown
            /// The duration of the policy&#39;s cooldown period, in seconds. When a cooldown period is specified here,
            /// it overrides the default cooldown period defined for the Auto Scaling group.
            /// Valid only if the policy type is SimpleScaling. For more information, see Scaling cooldowns for
            /// Amazon EC2 Auto Scaling in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// EstimatedInstanceWarmup
            /// The estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch
            /// metrics. If not provided, the default is to use the value from the default cooldown period for the
            /// Auto Scaling group.
            /// Valid only if the policy type is TargetTrackingScaling or StepScaling.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// MetricAggregationType
            /// The aggregation type for the CloudWatch metrics. The valid values are Minimum, Maximum, and Average.
            /// If the aggregation type is null, the value is treated as Average.
            /// Valid only if the policy type is StepScaling.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

            /// <summary>
            /// MinAdjustmentMagnitude
            /// The minimum value to scale by when the adjustment type is PercentChangeInCapacity. For example,
            /// suppose that you create a step scaling policy to scale out an Auto Scaling group by 25 percent and
            /// you specify a MinAdjustmentMagnitude of 2. If the group has 4 instances and the scaling policy is
            /// performed, 25 percent of 4 is 1. However, because you specified a MinAdjustmentMagnitude of 2,
            /// Amazon EC2 Auto Scaling scales out the group by 2 instances.
            /// Valid only if the policy type is StepScaling or SimpleScaling. For more information, see Scaling
            /// adjustment types in the Amazon EC2 Auto Scaling User Guide.
            /// Note Some Auto Scaling groups use instance weights. In this case, set the MinAdjustmentMagnitude to
            /// a value that is at least as large as your largest instance weight.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// PolicyType
            /// One of the following policy types:
            /// TargetTrackingScaling StepScaling SimpleScaling (default) PredictiveScaling
            /// For more information, see Target tracking scaling policies and Step and simple scaling policies in
            /// the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// PredictiveScalingConfiguration
            /// A predictive scaling policy. Includes support for predefined metrics only.
            /// Required: Conditional
            /// Type: PredictiveScalingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public PredictiveScalingConfiguration PredictiveScalingConfiguration { get; set; }

            /// <summary>
            /// ScalingAdjustment
            /// The amount by which to scale, based on the specified adjustment type. A positive value adds to the
            /// current capacity while a negative number removes from the current capacity. For exact capacity, you
            /// must specify a positive value.
            /// Required if the policy type is SimpleScaling. (Not used with any other policy type. )
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

            /// <summary>
            /// StepAdjustments
            /// A set of adjustments that enable you to scale based on the size of the alarm breach.
            /// Required if the policy type is StepScaling. (Not used with any other policy type. )
            /// Required: Conditional
            /// Type: List of StepAdjustment
            /// Update requires: No interruption
            /// </summary>
            public List<StepAdjustment> StepAdjustments { get; set; }

            /// <summary>
            /// TargetTrackingConfiguration
            /// A target tracking scaling policy. Includes support for predefined or customized metrics.
            /// The following predefined metrics are available:
            /// ASGAverageCPUUtilization ASGAverageNetworkIn ASGAverageNetworkOut ALBRequestCountPerTarget
            /// If you specify ALBRequestCountPerTarget for the metric, you must specify the ResourceLabel property
            /// with the PredefinedMetricSpecification.
            /// Required: Conditional
            /// Type: TargetTrackingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public TargetTrackingConfiguration TargetTrackingConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::ScalingPolicy";

        public ScalingPolicyProperties Properties { get; } = new ScalingPolicyProperties();

    }
}
