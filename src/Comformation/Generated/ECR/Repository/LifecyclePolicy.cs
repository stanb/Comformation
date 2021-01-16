using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// AWS::ECR::Repository LifecyclePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html
    /// </summary>
    public class LifecyclePolicy
    {

        /// <summary>
        /// LifecyclePolicyText
        /// The JSON repository policy text to apply to the repository.
        /// Required: No
        /// Type: String
        /// Minimum: 100
        /// Maximum: 30720
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LifecyclePolicyText")]
        public Union<string, IntrinsicFunction> LifecyclePolicyText { get; set; }

        /// <summary>
        /// RegistryId
        /// The AWS account ID associated with the registry that contains the repository. If you do&amp;#x2028; not
        /// specify a registry, the default registry is assumed.
        /// Required: No
        /// Type: String
        /// Pattern: [0-9]{12}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegistryId")]
        public Union<string, IntrinsicFunction> RegistryId { get; set; }

    }
}
