using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.ScalingPolicy
{
    /// <summary>
    /// Amazon EC2 Auto Scaling ScalingPolicy MetricDimension
    /// Use the MetricDimension property to specify the dimension of a metric for a target tracking policy in Amazon
    /// EC2 Auto Scaling. The Dimensions subproperty of the Amazon EC2 Auto Scaling ScalingPolicy
    /// CustomizedMetricSpecification property contains a list of MetricDimension property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdimension.html
    /// </summary>
    public class MetricDimension
    {

        /// <summary>
        /// Name
        /// The name of the dimension.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value of the dimension.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
