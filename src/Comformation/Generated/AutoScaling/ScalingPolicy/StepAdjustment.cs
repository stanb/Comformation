using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// Amazon EC2 Auto Scaling ScalingPolicy StepAdjustments
    /// StepAdjustments is a property of the AWS::AutoScaling::ScalingPolicy resource that describes a scaling
    /// adjustment based on the difference between the value of the aggregated CloudWatch metric and the breach
    /// threshold that you've defined for the alarm. For more information, see StepAdjustment in the Amazon EC2 Auto
    /// Scaling API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustments.html
    /// </summary>
    public class StepAdjustment
    {

        /// <summary>
        /// MetricIntervalLowerBound
        /// The lower bound of the breach size. The lower bound is the difference between the breach threshold
        /// and the aggregated CloudWatch metric value. If the metric value is within the lower and upper
        /// bounds, Auto Scaling triggers this step adjustment.
        /// If the metric value is above the breach threshold, the metric must be greater than or equal to the
        /// threshold plus the lower bound to trigger this step adjustment (the metric value is inclusive). If
        /// the metric value is below the breach threshold, the metric must be greater than the threshold plus
        /// the lower bound to trigger this step adjustment (the metric value is exclusive). A null value
        /// indicates negative infinity.
        /// Required: Conditional. You must specify at least one upper or lower bound.
        /// Type: Number
        /// </summary>
        [JsonProperty("MetricIntervalLowerBound")]
        public Union<double, IntrinsicFunction> MetricIntervalLowerBound { get; set; }

        /// <summary>
        /// MetricIntervalUpperBound
        /// The upper bound of the breach size. The upper bound is the difference between the breach threshold
        /// and the CloudWatch metric value. If the metric value is within the lower and upper bounds, Auto
        /// Scaling triggers this step adjustment.
        /// If the metric value is above the breach threshold, the metric must be less than the threshold plus
        /// the upper bound to trigger this step adjustment (the metric value is exclusive). If the metric value
        /// is below the breach threshold, the metric must be less than or equal to the threshold plus the upper
        /// bound to trigger this step adjustment (the metric value is inclusive). A null value indicates
        /// positive infinity.
        /// Required: Conditional. You must specify at least one upper or lower bound.
        /// Type: Number
        /// </summary>
        [JsonProperty("MetricIntervalUpperBound")]
        public Union<double, IntrinsicFunction> MetricIntervalUpperBound { get; set; }

        /// <summary>
        /// ScalingAdjustment
        /// The amount by which to scale. The adjustment is based on the value that you specified in the
        /// AdjustmentType property (either an absolute number or a percentage). A positive value adds to the
        /// current capacity and a negative number subtracts from the current capacity.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

    }
}
