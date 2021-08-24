using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig AsyncInferenceConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceconfig.html
    /// </summary>
    public class AsyncInferenceConfig
    {

        /// <summary>
        /// OutputConfig
        /// 	
        /// Specifies the configuration for asynchronous inference invocation outputs.
        /// Required: Yes
        /// Type: AsyncInferenceOutputConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AsyncInferenceOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// ClientConfig
        /// 	
        /// Configures the behavior of the client used by SageMaker to interact with the model container during
        /// asynchronous inference.
        /// Required: No
        /// Type: AsyncInferenceClientConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ClientConfig")]
        public AsyncInferenceClientConfig ClientConfig { get; set; }

    }
}
