using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan MetricDimension
    /// The MetricDimension property type specifies a dimension for a customized metric for an AWS Auto Scaling
    /// scaling plan.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// Value
        /// The value of the dimension.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of the dimension.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
