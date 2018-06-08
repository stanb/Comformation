using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// Application Auto Scaling ScalingPolicy MetricDimension
    /// Use the MetricDimension property to specify the dimension of a metric for a target tracking policy in
    /// Application Auto Scaling. The Dimensions subproperty of the Application Auto Scaling ScalingPolicy
    /// CustomizedMetricSpecification property contains a list of MetricDimension property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-metricdimension.html
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
