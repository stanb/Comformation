using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint CapacitySize
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-capacitysize.html
    /// </summary>
    public class CapacitySize
    {

        /// <summary>
        /// Type
        /// This API is not supported.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CAPACITY_PERCENT | INSTANCE_COUNT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<int, IntrinsicFunction> Value { get; set; }

    }
}
