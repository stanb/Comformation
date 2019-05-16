using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy MetricDimension
    /// MetricDimension is a subproperty of CustomizedMetricSpecification that specifies the dimensions of a metric
    /// for a target tracking scaling policy. Dimensions are arbitrary name/value pairs that can be associated with a
    /// CloudWatch metric. Duplicate dimensions are not allowed.
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
