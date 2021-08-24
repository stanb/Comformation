using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model ImageConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-imageconfig.html
    /// </summary>
    public class ImageConfig
    {

        /// <summary>
        /// RepositoryAuthConfig
        /// (Optional) Specifies an authentication configuration for the private docker registry where your
        /// model image is hosted. Specify a value for this property only if you specified Vpc as the value for
        /// the RepositoryAccessMode field, and the private Docker registry where the model image is hosted
        /// requires authentication.
        /// Required: No
        /// Type: RepositoryAuthConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryAuthConfig")]
        public RepositoryAuthConfig RepositoryAuthConfig { get; set; }

        /// <summary>
        /// RepositoryAccessMode
        /// Set this to one of the following values:
        /// Platform - The model image is hosted in Amazon ECR. Vpc - The model image is hosted in a private
        /// Docker registry in your VPC.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Platform | Vpc
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryAccessMode")]
        public Union<string, IntrinsicFunction> RepositoryAccessMode { get; set; }

    }
}
