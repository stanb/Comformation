using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model RepositoryAuthConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-imageconfig-repositoryauthconfig.html
    /// </summary>
    public class RepositoryAuthConfig
    {

        /// <summary>
        /// RepositoryCredentialsProviderArn
        /// The Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate
        /// to the private Docker registry where your model image is hosted. For information about how to create
        /// an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer
        /// Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryCredentialsProviderArn")]
        public Union<string, IntrinsicFunction> RepositoryCredentialsProviderArn { get; set; }

    }
}
