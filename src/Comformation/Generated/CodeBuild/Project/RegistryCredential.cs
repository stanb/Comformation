using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project RegistryCredential
    /// RegistryCredential is a property of the AWS::CodeBuild::Project resource that specify information about
    /// credentials that provide access to a private Docer registry. When this is set:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-registrycredential.html
    /// </summary>
    public class RegistryCredential
    {

        /// <summary>
        /// Credential
        /// The Amazon Resource Name (ARN) or name of credentials created using AWS Secrets Manager.
        /// Note The credential can use the name of the credentials only if they exist in your current region.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Credential")]
        public Union<string, IntrinsicFunction> Credential { get; set; }

        /// <summary>
        /// CredentialProvider
        /// The service that created the credentials to access a private Docker registry. The one valid value,
        /// SECRETS_MANAGER, is for AWS Secrets Manager.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CredentialProvider")]
        public Union<string, IntrinsicFunction> CredentialProvider { get; set; }

    }
}
