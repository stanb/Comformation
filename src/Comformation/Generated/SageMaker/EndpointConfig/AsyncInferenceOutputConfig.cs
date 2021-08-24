using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig AsyncInferenceOutputConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-asyncinferenceoutputconfig.html
    /// </summary>
    public class AsyncInferenceOutputConfig
    {

        /// <summary>
        /// KmsKeyId
        /// 	
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the asynchronous
        /// inference output in Amazon S3.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// NotificationConfig
        /// 	
        /// Specifies the configuration for notifications of inference results for asynchronous inference.
        /// Required: No
        /// Type: AsyncInferenceNotificationConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NotificationConfig")]
        public AsyncInferenceNotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// S3OutputPath
        /// 	
        /// The Amazon S3 location to upload inference responses to.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3OutputPath")]
        public Union<string, IntrinsicFunction> S3OutputPath { get; set; }

    }
}
