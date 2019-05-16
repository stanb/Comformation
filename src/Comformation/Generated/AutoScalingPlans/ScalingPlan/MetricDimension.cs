using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan MetricDimension
    /// MetricDimension is a subproperty of CustomizedScalingMetricSpecification that specifies a dimension for a
    /// customized metric to use with AWS Auto Scaling. Dimensions are arbitrary name/value pairs that can be
    /// associated with a CloudWatch metric. Duplicate dimensions are not allowed.
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
