using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint TrafficRoutingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html
    /// </summary>
    public class TrafficRoutingConfig
    {

        /// <summary>
        /// Type
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALL_AT_ONCE | CANARY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// CanarySize
        /// Required: No
        /// Type: CapacitySize
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CanarySize")]
        public CapacitySize CanarySize { get; set; }

        /// <summary>
        /// WaitIntervalInSeconds
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 3600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitIntervalInSeconds")]
        public Union<int, IntrinsicFunction> WaitIntervalInSeconds { get; set; }

    }
}
