using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cloud9.EnvironmentEC2
{
    /// <summary>
    /// AWS::Cloud9::EnvironmentEC2 Repository
    /// The Repository property type specifies an AWS CodeCommit source code repository to be cloned into an AWS
    /// Cloud9 development environment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloud9-environmentec2-repository.html
    /// </summary>
    public class Repository
    {

        /// <summary>
        /// PathComponent
        /// The path within the development environment&#39;s default file system location to clone the AWS
        /// CodeCommit repository into. For example, /REPOSITORY_NAME would clone the repository into the
        /// /home/USER_NAME/environment/REPOSITORY_NAME directory in the environment.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PathComponent")]
        public Union<string, IntrinsicFunction> PathComponent { get; set; }

        /// <summary>
        /// RepositoryUrl
        /// The clone URL of the AWS CodeCommit repository to be cloned. For example, for an AWS CodeCommit
        /// repository this might be https://git-codecommit. us-east-2. amazonaws. com/v1/repos/REPOSITORY_NAME.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepositoryUrl")]
        public Union<string, IntrinsicFunction> RepositoryUrl { get; set; }

    }
}
