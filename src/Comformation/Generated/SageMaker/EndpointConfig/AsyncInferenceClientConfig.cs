using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig AsyncInferenceClientConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceclientconfig.html
    /// </summary>
    public class AsyncInferenceClientConfig
    {

        /// <summary>
        /// MaxConcurrentInvocationsPerInstance
        /// 	
        /// The maximum number of concurrent requests sent by the SageMaker client to the model container. If no
        /// value is provided, SageMaker will choose an optimal value for you.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxConcurrentInvocationsPerInstance")]
        public Union<int, IntrinsicFunction> MaxConcurrentInvocationsPerInstance { get; set; }

    }
}
