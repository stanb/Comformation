using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project EnvironmentVariable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html
    /// </summary>
    public class EnvironmentVariable
    {

        /// <summary>
        /// Type
        /// The type of environment variable. Valid values include:
        /// PARAMETER_STORE: An environment variable stored in Amazon EC2 Systems Manager Parameter Store. To
        /// learn how to specify a parameter store environment variable, see env/parameter-store in the AWS
        /// CodeBuild User Guide. PLAINTEXT: An environment variable in plain text format. This is the default
        /// value. SECRETS_MANAGER: An environment variable stored in AWS Secrets Manager. To learn how to
        /// specify a secrets manager environment variable, see env/secrets-manager in the AWS CodeBuild User
        /// Guide.
        /// Required: No
        /// Type: String
        /// Allowed values: PARAMETER_STORE | PLAINTEXT | SECRETS_MANAGER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The value of the environment variable.
        /// Important We strongly discourage the use of PLAINTEXT environment variables to store sensitive
        /// values, especially AWS secret key IDs and secret access keys. PLAINTEXT environment variables can be
        /// displayed in plain text using the AWS CodeBuild console and the AWS Command Line Interface (AWS
        /// CLI). For sensitive values, we recommend you use an environment variable of type PARAMETER_STORE or
        /// SECRETS_MANAGER.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name or key of the environment variable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
