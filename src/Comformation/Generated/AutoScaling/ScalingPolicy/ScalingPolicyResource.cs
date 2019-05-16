using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy
    /// Specifies a scaling policy for an Amazon EC2 Auto Scaling group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// AdjustmentType
            /// Specifies whether the ScalingAdjustment property is an absolute number or a percentage of the
            /// current capacity. The valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.
            /// Valid only if the policy type is StepScaling or SimpleScaling. For more information, see Scaling
            /// Adjustment Types in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

            /// <summary>
            /// AutoScalingGroupName
            /// The name or Amazon Resource Name (ARN) of the Auto Scaling group that you want to attach the policy
            /// to.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// Cooldown
            /// The amount of time, in seconds, after a scaling activity completes before any further dynamic
            /// scaling activities can start. If this property is not specified, the default cooldown period for the
            /// group applies.
            /// Valid only if the policy type is SimpleScaling. For more information, see Scaling Cooldowns in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// EstimatedInstanceWarmup
            /// The estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch
            /// metrics. The default is to use the value specified for the default cooldown period for the group.
            /// Valid only if the policy type is StepScaling or TargetTrackingScaling.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// MetricAggregationType
            /// The aggregation type for the CloudWatch metrics. The valid values are Minimum, Maximum, and Average.
            /// By default, AWS CloudFormation specifies Average.
            /// Valid only if the policy type is StepScaling.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

            /// <summary>
            /// MinAdjustmentMagnitude
            /// The minimum number of instances to scale. If the value of AdjustmentType is PercentChangeInCapacity,
            /// the scaling policy changes the DesiredCapacity of the Auto Scaling group by at least this many
            /// instances. This property replaces the MinAdjustmentStep property.
            /// For example, suppose that you create a step scaling policy to scale out an Auto Scaling group by 25
            /// percent and you specify a MinAdjustmentMagnitude of 2. If the group has 4 instances and the scaling
            /// policy is performed, 25 percent of 4 is 1. However, because you specified a MinAdjustmentMagnitude
            /// of 2, Amazon EC2 Auto Scaling scales out the group by 2 instances.
            /// Valid only if the policy type is StepScaling or SimpleScaling.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// PolicyType
            /// The policy type. The valid values are SimpleScaling, StepScaling, and TargetTrackingScaling. By
            /// default, AWS CloudFormation specifies SimpleScaling.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// ScalingAdjustment
            /// The amount by which a simple scaling policy scales the Auto Scaling group in response to an alarm
            /// breach. The adjustment is based on the value that you specified in the AdjustmentType property
            /// (either an absolute number or a percentage). A positive value adds to the current capacity and a
            /// negative value subtracts from the current capacity. For exact capacity, you must specify a positive
            /// value.
            /// If you specify SimpleScaling for the policy type, you must specify this property. (Not used with any
            /// other policy type. )
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

            /// <summary>
            /// StepAdjustments
            /// A set of adjustments that enable you to scale based on the size of the alarm breach.
            /// If you specify StepScaling for the policy type, you must specify this property. (Not used with any
            /// other policy type. )
            /// Required: Conditional
            /// Type: List of StepAdjustment
            /// Update requires: No interruption
            /// </summary>
			public List<StepAdjustment> StepAdjustments { get; set; }

            /// <summary>
            /// TargetTrackingConfiguration
            /// Configures a target tracking scaling policy.
            /// If you specify TargetTrackingScaling for the policy type, you must specify this property. (Not used
            /// with any other policy type. )
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
