using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// Application Auto Scaling ScalingPolicy StepScalingPolicyConfiguration
    /// StepScalingPolicyConfiguration is a property of the AWS::ApplicationAutoScaling::ScalingPolicy resource that
    /// configures when Application Auto Scaling scales resources up or down, and by how much.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html
    /// </summary>
    public class StepScalingPolicyConfiguration
    {

        /// <summary>
        /// AdjustmentType
        /// Specifies whether the ScalingAdjustment value in the StepAdjustment property is an absolute number
        /// or a percentage of the current capacity. For valid values, see the AdjustmentType content for the
        /// StepScalingPolicyConfiguration data type in the Application Auto Scaling API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

        /// <summary>
        /// Cooldown
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// trigger-related scaling activities can start. For more information, see the Cooldown content for the
        /// StepScalingPolicyConfiguration data type in the Application Auto Scaling API Reference.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Cooldown")]
        public Union<int, IntrinsicFunction> Cooldown { get; set; }

        /// <summary>
        /// MetricAggregationType
        /// The aggregation type for the CloudWatch metrics. You can specify Minimum, Maximum, or Average. By
        /// default, AWS CloudFormation specifies Average. For more information, see Aggregation in the Amazon
        /// CloudWatch User Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MetricAggregationType")]
        public Union<string, IntrinsicFunction> MetricAggregationType { get; set; }

        /// <summary>
        /// MinAdjustmentMagnitude
        /// The minimum number of resources to adjust when a scaling activity is triggered. If you specify
        /// PercentChangeInCapacity for the adjustment type, the scaling policy scales the target by this
        /// amount.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("MinAdjustmentMagnitude")]
        public Union<int, IntrinsicFunction> MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// StepAdjustments
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// Required: No
        /// Type: List of Application Auto Scaling ScalingPolicy StepScalingPolicyConfiguration StepAdjustment
        /// </summary>
        [JsonProperty("StepAdjustments")]
        public Union<List<StepAdjustment>, IntrinsicFunction> StepAdjustments { get; set; }

    }
}
