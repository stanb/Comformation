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
