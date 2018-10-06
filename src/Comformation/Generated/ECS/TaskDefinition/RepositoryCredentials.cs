using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon ECS TaskDefinition RepositoryCredentials
    /// The RepositoryCredentials property type specifies the repository credentials for private registry
    /// authentication.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-repositorycredentials.html
    /// </summary>
    public class RepositoryCredentials
    {

        /// <summary>
        /// CredentialsParameter
        /// The Amazon Resource Name (ARN) of the secret containing the private repository credentials.
        /// Note When using the Amazon ECS API, AWS CLI, or AWS SDK, if the secret exists in the same region as
        /// the task you are launching then you can use either the full ARN or name of the secret. When using
        /// the AWS Management Console, the full ARN of the secret must be specified.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CredentialsParameter")]
        public Union<string, IntrinsicFunction> CredentialsParameter { get; set; }

    }
}
