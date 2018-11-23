using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.Secret
{
    /// <summary>
    /// AWS::SecretsManager::Secret
    /// The AWS::SecretsManager::Secret resource creates a secret and stores it in Secrets Manager. For more
    /// information, see Secret in the AWS Secrets Manager User Guide, and the CreateSecret API in the AWS Secrets
    /// Manager API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secret.html
    /// </summary>
    public class SecretResource : ResourceBase
    {
        public class SecretProperties
        {
            /// <summary>
            /// Description
            /// Specifies a user-provided description of the secret.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KmsKeyId
            /// Specifies the ARN, Key ID, or alias of the AWS KMS customer master key (CMK) that&#39;s used to encrypt
            /// the secret values for versions of this secret. If you don&#39;t specify this value, then Secrets Manager
            /// defaults to the AWS account&#39;s default CMK (the one named aws/secretsmanager). If an AWS KMS CMK with
            /// that name doesn&#39;t yet exist, Secrets Manager creates it for you automatically the first time it
            /// needs to encrypt a version&#39;s secret value fields.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// SecretString
            /// Specifies a literal string to use as the secret value in the initial version of this secret. You can
            /// specify any text you like, but remember that Lambda rotation functions require a specific JSON
            /// structure to be present in this field.
            /// Alternatively, instead of hardcoding the password in this string parameter, we recommend that you
            /// use the GenerateSecretString parameter instead.
            /// You must specify either SecretString or GenerateSecretString, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecretString { get; set; }

            /// <summary>
            /// GenerateSecretString
            /// A structure that specifies how to generate a random password by using the functionality of the
            /// GetRandomPassword API. You can return that string directly to use as the secret value, or you can
            /// alternatively also specify both the SecretStringTemplate and the GenerateSecretKey parameters.
            /// Secrets Manager uses the value in GenerateSecretKey as the key name and combines it with the
            /// randomly generated password to make a JSON key-value pair. It then inserts that pair into the JSON
            /// structure that&#39;s specified in the SecretStringTemplate parameter. Secrets Manager stores the
            /// completed string as the secret value in the initial version of the secret. For more information
            /// about how to use this property, see Secrets Manager Secret GenerateSecretString and the first
            /// example in the following Examples section.
            /// You must specify either SecretString or GenerateSecretString, but not both.
            /// Required: No
            /// Type: Secrets Manager Secret GenerateSecretString
            /// Update requires: No interruption
            /// </summary>
			public GenerateSecretString GenerateSecretString { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this secret. Use tags to
            /// manage your AWS resources.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// Specifies the friendly name of the new secret. If a Name parameter isn&#39;t specified, then Secrets
            /// Manager generates a name based on the logical resource ID of the secret in the AWS CloudFormation
            /// template.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::Secret";

        public SecretProperties Properties { get; } = new SecretProperties();

    }
}
