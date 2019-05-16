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
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KmsKeyId
            /// Specifies the ARN, Key ID, or alias of the AWS KMS customer master key (CMK) that&#39;s used to encrypt
            /// the SecretString or SecretBinary values for versions of this secret. If you don&#39;t specify this
            /// value, then Secrets Manager defaults to the AWS account&#39;s CMK (the one named aws/secretsmanager). If
            /// an AWS KMS CMK with that name doesn&#39;t yet exist, Secrets Manager creates it for you automatically
            /// the first time it needs to encrypt a version&#39;s SecretString or SecretBinary fields.
            /// Important You can use the account&#39;s default CMK to encrypt and decrypt only if you call this
            /// operation using credentials from the same account that owns the secret. If the secret is in a
            /// different account, then you must create a custom CMK and specify the ARN in this field.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// SecretString
            /// Specifies a literal string to use as the secret value for the secret. You can use any text you like,
            /// but remember that Lambda rotation functions require a specific JSON structure to be present in this
            /// field.
            /// Alternatively, instead of hardcoding the password in this string parameter, we recommend that you
            /// use the GenerateSecretString parameter instead.
            /// You must specify either SecretString or GenerateSecretString, but not both.
            /// Note Stack updates that modify a SecretString property, will immediately change the secret&#39;s value.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecretString { get; set; }

            /// <summary>
            /// GenerateSecretString
            /// A structure that specifies how to generate a random password by using the functionality of the
            /// GetRandomPassword API. You can return that string directly to use as the secret value, or you can
            /// specify both the SecretStringTemplate and the GenerateSecretKeyparameters. Secrets Manager uses the
            /// value in GenerateSecretKeyparameters. Secrets Manager uses the value in GenerateSecretKey as the key
            /// name and combines it with the randomly generated password to make a JSON key-value pair. It then
            /// inserts that pair into the JSON structure that&#39;s specified in the SecretStringTemplateparameter.
            /// Secrets Manager stores the completed string as the secret value in the initial version of the
            /// secret. For more information about how to use this property, see Secrets Manager Secret
            /// GenerateSecretString and the first example in the following Examples section.
            /// Either SecretString or SecretBinary must have a value, but not both. They cannot both be empty.
            /// Required: No
            /// Type: GenerateSecretString
            /// Minimum: 0
            /// Maximum: 7168
            /// Update requires: No interruption
            /// </summary>
			public GenerateSecretString GenerateSecretString { get; set; }

            /// <summary>
            /// Tags
            /// The list of user-defined tags that are associated with the secret. Use tags to manage your AWS
            /// resources. For additional information about tags, see TagResource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The friendly name of the secret. You can use forward slashes in the name to represent a path
            /// hierarchy. For example, /prod/databases/dbserver1 could represent the secret for a server named
            /// dbserver1 in the folder databases in the folder prod.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::Secret";

        public SecretProperties Properties { get; } = new SecretProperties();

    }
}
