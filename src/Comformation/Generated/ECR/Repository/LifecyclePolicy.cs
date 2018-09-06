using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// Amazon Elastic Container Registry Repository LifecyclePolicy
    /// The LifecyclePolicy property type specifies a lifecycle policy for an Amazon Elastic Container Registry
    /// (Amazon ECR) repository.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html
    /// </summary>
    public class LifecyclePolicy
    {

        /// <summary>
        /// LifecyclePolicyText
        /// The JSON repository policy text to apply to the repository. The length must be between 100 and
        /// 10,240 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecyclePolicyText")]
        public Union<string, IntrinsicFunction> LifecyclePolicyText { get; set; }

        /// <summary>
        /// RegistryId
        /// The AWS account ID that&#39;s associated with the registry that contains the repository. If you don&#39;t
        /// specify a registry, the default registry is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegistryId")]
        public Union<string, IntrinsicFunction> RegistryId { get; set; }

    }
}
