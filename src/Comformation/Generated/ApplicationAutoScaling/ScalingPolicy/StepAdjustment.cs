using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy StepAdjustment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-stepadjustment.html
    /// </summary>
    public class StepAdjustment
    {

        /// <summary>
        /// MetricIntervalLowerBound
        /// The lower bound for the difference between the alarm threshold and the CloudWatch metric. If the
        /// metric value is above the breach threshold, the lower bound is inclusive (the metric must be greater
        /// than or equal to the threshold plus the lower bound). Otherwise, it is exclusive (the metric must be
        /// greater than the threshold plus the lower bound). A null value indicates negative infinity.
        /// You must specify at least one upper or lower bound.
        /// Required: Conditional
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricIntervalLowerBound")]
        public Union<double, IntrinsicFunction> MetricIntervalLowerBound { get; set; }

        /// <summary>
        /// MetricIntervalUpperBound
        /// The upper bound for the difference between the alarm threshold and the CloudWatch metric. If the
        /// metric value is above the breach threshold, the upper bound is exclusive (the metric must be less
        /// than the threshold plus the upper bound). Otherwise, it is inclusive (the metric must be less than
        /// or equal to the threshold plus the upper bound). A null value indicates positive infinity.
        /// You must specify at least one upper or lower bound.
        /// Required: Conditional
        /// Type: Double
        /// Update requires: No interruption
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

    }
}
