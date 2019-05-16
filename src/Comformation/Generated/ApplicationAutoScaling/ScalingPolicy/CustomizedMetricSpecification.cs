using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy CustomizedMetricSpecification
    /// CustomizedMetricSpecification is a subproperty of TargetTrackingScalingPolicyConfiguration that configures a
    /// customized metric for a target tracking scaling policy to use with Application Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html
    /// </summary>
    public class CustomizedMetricSpecification
    {

        /// <summary>
        /// Dimensions
        /// The dimensions of the metric.
        /// Conditional: If you published your metric with dimensions, you must specify the same dimensions in
        /// your scaling policy.
        /// Required: No
        /// Type: List of MetricDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<MetricDimension> Dimensions { get; set; }

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
        /// Namespace
        /// The namespace of the metric.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

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
        /// Unit
        /// The unit of the metric.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
