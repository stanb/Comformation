using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm Dimension
    /// Dimension is an embedded property of the AWS::CloudWatch::Alarm type. Dimensions are arbitrary name/value
    /// pairs that can be associated with a CloudWatch metric. You can specify a maximum of 10 dimensions for a given
    /// metric.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-dimension.html
    /// </summary>
    public class Dimension
    {

        /// <summary>
        /// Name
        /// The name of the dimension, from 1–255 characters in length.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value for the dimension, from 1–255 characters in length.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
