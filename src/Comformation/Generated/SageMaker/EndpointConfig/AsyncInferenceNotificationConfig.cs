using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig AsyncInferenceNotificationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferencenotificationconfig.html
    /// </summary>
    public class AsyncInferenceNotificationConfig
    {

        /// <summary>
        /// SuccessTopic
        /// 	
        /// Amazon SNS topic to post a notification to when an inference completes successfully. If no topic is
        /// provided, no notification is sent on success.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SuccessTopic")]
        public Union<string, IntrinsicFunction> SuccessTopic { get; set; }

        /// <summary>
        /// ErrorTopic
        /// 	
        /// Amazon SNS topic to post a notification to when an inference fails. If no topic is provided, no
        /// notification is sent on failure.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ErrorTopic")]
        public Union<string, IntrinsicFunction> ErrorTopic { get; set; }

    }
}
