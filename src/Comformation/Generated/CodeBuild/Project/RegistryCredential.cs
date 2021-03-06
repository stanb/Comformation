using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project RegistryCredential
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-registrycredential.html
    /// </summary>
    public class RegistryCredential
    {

        /// <summary>
        /// Credential
        /// The Amazon Resource Name (ARN) or name of credentials created using AWS Secrets Manager.
        /// Note The credential can use the name of the credentials only if they exist in your current AWS
        /// Region.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Credential")]
        public Union<string, IntrinsicFunction> Credential { get; set; }

        /// <summary>
        /// CredentialProvider
        /// The service that created the credentials to access a private Docker registry. The valid value,
        /// SECRETS_MANAGER, is for AWS Secrets Manager.
        /// Required: Yes
        /// Type: String
        /// Allowed values: SECRETS_MANAGER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CredentialProvider")]
        public Union<string, IntrinsicFunction> CredentialProvider { get; set; }

    }
}
