using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::AutoScaling::ScalingPolicy PredictiveScalingMetricSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html
    /// </summary>
    public class PredictiveScalingMetricSpecification
    {

        /// <summary>
        /// PredefinedLoadMetricSpecification
        /// The load metric specification.
        /// If you specify PredefinedMetricPairSpecification, don&#39;t specify this property.
        /// Required: No
        /// Type: PredictiveScalingPredefinedLoadMetric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedLoadMetricSpecification")]
        public PredictiveScalingPredefinedLoadMetric PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// PredefinedMetricPairSpecification
        /// The metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling
        /// metric and load metric to use.
        /// Note With predictive scaling, you must specify either a metric pair, or a load metric and a scaling
        /// metric individually. Specifying a metric pair instead of individual metrics provides a simpler way
        /// to configure metrics for a scaling policy. You choose the metric pair, and the policy automatically
        /// knows the correct sum and average statistics to use for the load metric and the scaling metric.
        /// Required: No
        /// Type: PredictiveScalingPredefinedMetricPair
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricPairSpecification")]
        public PredictiveScalingPredefinedMetricPair PredefinedMetricPairSpecification { get; set; }

        /// <summary>
        /// PredefinedScalingMetricSpecification
        /// The scaling metric specification.
        /// If you specify PredefinedMetricPairSpecification, don&#39;t specify this property.
        /// Required: No
        /// Type: PredictiveScalingPredefinedScalingMetric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedScalingMetricSpecification")]
        public PredictiveScalingPredefinedScalingMetric PredefinedScalingMetricSpecification { get; set; }

        /// <summary>
        /// TargetValue
        /// Specifies the target utilization.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetValue")]
        public Union<double, IntrinsicFunction> TargetValue { get; set; }

    }
}
