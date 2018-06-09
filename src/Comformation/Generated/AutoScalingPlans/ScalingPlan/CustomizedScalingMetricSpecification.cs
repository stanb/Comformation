using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan CustomizedScalingMetricSpecification
    /// The CustomizedScalingMetricSpecification property type specifies a customized metric for a target tracking
    /// policy for an AWS Auto Scaling scaling plan.
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
        /// Valid Values: Average | Minimum | Maximum | SampleCount | Sum
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

        /// <summary>
        /// Dimensions
        /// The dimensions of the metric.
        /// Required: No
        /// Type: List of AWS Auto Scaling ScalingPlan MetricDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public Union<List<MetricDimension>, IntrinsicFunction> Dimensions { get; set; }

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
