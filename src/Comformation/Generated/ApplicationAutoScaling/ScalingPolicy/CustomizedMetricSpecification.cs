using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// Application Auto Scaling ScalingPolicy CustomizedMetricSpecification
    /// The CustomizedMetricSpecification property configures a customized metric for a target tracking policy in
    /// Application Auto Scaling. CustomizedMetricSpecification is a subproperty of the Application Auto Scaling
    /// ScalingPolicy TargetTrackingScalingPolicyConfiguration property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html
    /// </summary>
    public class CustomizedMetricSpecification
    {

        /// <summary>
        /// Dimensions
        /// The dimensions of the metric. Duplicates not allowed.
        /// Required: No
        /// Type: List of Application Auto Scaling ScalingPolicy MetricDimension
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
        /// For valid values, see CustomizedMetricSpecification in the Application Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
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
