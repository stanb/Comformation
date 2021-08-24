using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.AnomalyDetector
{
    /// <summary>
    /// AWS::CloudWatch::AnomalyDetector Dimension
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-dimension.html
    /// </summary>
    public class Dimension
    {

        /// <summary>
        /// Value
        /// 		
        /// The value of the dimension. Dimension values must contain only ASCII characters and must include
        /// 			at least one non-whitespace character.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// The name of the dimension.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
