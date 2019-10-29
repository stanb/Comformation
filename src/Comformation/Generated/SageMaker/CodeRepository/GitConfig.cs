using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.CodeRepository
{
    /// <summary>
    /// AWS::SageMaker::CodeRepository GitConfig
    /// Specifies configuration details for a Git repository in your AWS account.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html
    /// </summary>
    public class GitConfig
    {

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret that contains the credentials used
        /// to access the git repository. The secret must have a staging label of AWSCURRENT and must be in the
        /// following format:
        /// {&quot;username&quot;: UserName, &quot;password&quot;: Password}
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:aws[a-z\-]*:secretsmanager:[a-z0-9\-]*:[0-9]{12}:secret:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// Branch
        /// The default branch for the Git repository.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: [^ ~^:?*\[]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Branch")]
        public Union<string, IntrinsicFunction> Branch { get; set; }

        /// <summary>
        /// RepositoryUrl
        /// The URL where the Git repository is located.
        /// Required: Yes
        /// Type: String
        /// Pattern: ^https://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryUrl")]
        public Union<string, IntrinsicFunction> RepositoryUrl { get; set; }

    }
}
