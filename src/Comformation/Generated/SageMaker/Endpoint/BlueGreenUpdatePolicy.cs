using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint BlueGreenUpdatePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html
    /// </summary>
    public class BlueGreenUpdatePolicy
    {

        /// <summary>
        /// MaximumExecutionTimeoutInSeconds
        /// Required: No
        /// Type: Integer
        /// Minimum: 600
        /// Maximum: 14400
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumExecutionTimeoutInSeconds")]
        public Union<int, IntrinsicFunction> MaximumExecutionTimeoutInSeconds { get; set; }

        /// <summary>
        /// TerminationWaitInSeconds
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 3600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TerminationWaitInSeconds")]
        public Union<int, IntrinsicFunction> TerminationWaitInSeconds { get; set; }

        /// <summary>
        /// TrafficRoutingConfiguration
        /// Required: Yes
        /// Type: TrafficRoutingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TrafficRoutingConfiguration")]
        public TrafficRoutingConfig TrafficRoutingConfiguration { get; set; }

    }
}
