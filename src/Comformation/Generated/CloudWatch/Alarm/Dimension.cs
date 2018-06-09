using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// CloudWatch Metric Dimension Property Type
    /// The Metric Dimension is an embedded property of the AWS::CloudWatch::Alarm type. Dimensions are arbitrary
    /// name/value pairs that can be associated with a CloudWatch metric. You can specify a maximum of 10 dimensions
    /// for a given metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-dimension.html
    /// </summary>
    public class Dimension
    {

        /// <summary>
        /// Name
        /// The name of the dimension, from 1–255 characters in length.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value representing the dimension measurement, from 1–255 characters in length.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
