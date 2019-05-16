using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan CustomizedScalingMetricSpecification
    /// CustomizedScalingMetricSpecification is a subproperty of TargetTrackingConfiguration that specifies a
    /// customized scaling metric for a target tracking configuration to use with AWS Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html
    /// </summary>
    public class CustomizedScalingMetricSpecification
    {

        /// <summary>
        /// MetricName
        /// The name of the metric.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        /// Statistic
        /// The statistic of the metric.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Average | Maximum | Minimum | SampleCount | Sum
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

        /// <summary>
        /// Dimensions
        /// The dimensions of the metric.
        /// Conditional: If you published your metric with dimensions, you must specify the same dimensions in
        /// your customized scaling metric specification.
        /// Required: No
        /// Type: List of MetricDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// Unit
        /// The unit of the metric.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

        /// <summary>
        /// Namespace
        /// The namespace of the metric.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

    }
}
