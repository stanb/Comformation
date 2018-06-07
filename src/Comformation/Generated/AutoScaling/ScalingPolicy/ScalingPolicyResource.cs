using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy
    /// Adds a scaling policy to an Auto Scaling group. A scaling policy specifies whether to scale the Auto Scaling
    /// group up or down, and by how much. For more information, see Dynamic Scaling in the Amazon EC2 Auto Scaling
    /// User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// AdjustmentType
            /// Specifies whether the ScalingAdjustment is an absolute number or a percentage of the current
            /// capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-adjustmenttype
            /// </summary>
			public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

            /// <summary>
            /// AutoScalingGroupName
            /// The name or Amazon Resource Name (ARN) of the Auto Scaling Group that you want to attach the policy
            /// to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-autoscalinggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// Cooldown
            /// The amount of time, in seconds, after a scaling activity completes before any further
            /// trigger-related scaling activities can start.
            /// Do not specify this property if you are using the StepScaling policy type.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-cooldown
            /// </summary>
			public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// EstimatedInstanceWarmup
            /// The estimated time, in seconds, until a newly launched instance can send metrics to CloudWatch. By
            /// default, Auto Scaling uses the cooldown period, as specified in the Cooldown property.
            /// Do not specify this property if you are using the SimpleScaling policy type.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-estimatedinstancewarmup
            /// </summary>
			public Union<int, IntrinsicFunction> EstimatedInstanceWarmup { get; set; }

            /// <summary>
            /// MetricAggregationType
            /// The aggregation type for the CloudWatch metrics. You can specify Minimum, Maximum, or Average. By
            /// default, AWS CloudFormation specifies Average.
            /// Do not specify this property if you are using the SimpleScaling policy type.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-metricaggregationtype
            /// </summary>
			public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

            /// <summary>
            /// MinAdjustmentMagnitude
            /// For the PercentChangeInCapacity adjustment type, the minimum number of instances to scale. The
            /// scaling policy changes the desired capacity of the Auto Scaling group by a minimum of this many
            /// instances. This property replaces the MinAdjustmentStep property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-minadjustmentmagnitude
            /// </summary>
			public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

            /// <summary>
            /// PolicyType
            /// An Auto Scaling policy type. You can specify SimpleScaling, StepScaling, or TargetTrackingScaling.
            /// By default, AWS CloudFormation specifies SimpleScaling. For more information, see Dynamic Scaling in
            /// the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-policytype
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// ScalingAdjustment
            /// The number of instances by which to scale. The AdjustmentType property determines if AWS
            /// CloudFormation interprets this number as an absolute number (when the ExactCapacity value is
            /// specified), increase or decrease capacity by a specified number (when the ChangeInCapacity value is
            /// specified), or increase or decrease capacity as a percentage of the existing Auto Scaling group size
            /// (when the PercentChangeInCapacity value is specified). A positive value adds to the current capacity
            /// and a negative value subtracts from the current capacity. For exact capacity, you must specify a
            /// positive value.
            /// Required: Conditional. This property is required if the policy type is SimpleScaling. This property
            /// is not supported with any other policy type.
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-scalingadjustment
            /// </summary>
			public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

            /// <summary>
            /// StepAdjustments
            /// A set of adjustments that enable you to scale based on the size of the alarm breach.
            /// Required: Conditional. This property is required if the policy type is StepScaling. This property is
            /// not supported with any other policy type.
            /// Type: List of Amazon EC2 Auto Scaling ScalingPolicy StepAdjustments
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-stepadjustments
            /// </summary>
			public Union<List<StepAdjustment>, IntrinsicFunction> StepAdjustments { get; set; }

            /// <summary>
            /// TargetTrackingConfiguration
            /// Configures a target tracking scaling policy.
            /// Required: Conditional. This property is required if the policy type is TargetTrackingScaling. This
            /// property is not supported with any other policy type.
            /// Type: Amazon EC2 Auto Scaling ScalingPolicy TargetTrackingConfiguration
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration
            /// </summary>
			public Union<TargetTrackingConfiguration, IntrinsicFunction> TargetTrackingConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::AutoScaling::ScalingPolicy";
        
        public ScalingPolicyProperties Properties { get; } = new ScalingPolicyProperties();
    }
}
