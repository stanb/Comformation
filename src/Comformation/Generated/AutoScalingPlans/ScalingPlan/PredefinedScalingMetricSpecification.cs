using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan PredefinedScalingMetricSpecification
    /// The PredefinedScalingMetricSpecification property type specifies a predefined metric for a target tracking
    /// policy to use with AWS Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedscalingmetricspecification.html
    /// </summary>
    public class PredefinedScalingMetricSpecification
    {

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

        /// <summary>
        /// PredefinedScalingMetricType
        /// The metric type. For more information, see PredefinedScalingMetricSpecification in the AWS Auto
        /// Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedScalingMetricType")]
        public Union<string, IntrinsicFunction> PredefinedScalingMetricType { get; set; }

    }
}
