using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.Secret
{
    /// <summary>
    /// AWS::SecretsManager::Secret
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secret.html
    /// </summary>
    public class SecretResource : ResourceBase
    {
        public class SecretProperties
        {
            /// <summary>
            /// Description
            /// (Optional) Specifies a user-provided description of the secret.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KmsKeyId
            /// (Optional) Specifies the ARN, Key ID, or alias of the AWS KMS customer master key (CMK) used to
            /// encrypt the SecretString or SecretBinary values for versions of this secret. If you don&#39;t specify
            /// this value, then Secrets Manager defaults to the AWS account CMK, aws/secretsmanager. If an AWS KMS
            /// CMK with that name doesn&#39;t exist, Secrets Manager creates the CMK for you automatically the first
            /// time it encrypts a version SecretString or SecretBinary fields.
            /// Important You can use the account default CMK to encrypt and decrypt only if you call this operation
            /// using credentials from the same account that owns the secret. If you use a secret from a different
            /// account, then you must create a custom CMK and specify the ARN in this field.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// SecretString
            /// (Optional) Specifies text data that you want to encrypt and store in this new version of the secret.
            /// Either SecretString or SecretBinary must have a value, but not both. They cannot both be empty.
            /// If you create a secret by using the Secrets Manager console then Secrets Manager puts the protected
            /// secret text in only the SecretString parameter. The Secrets Manager console stores the information
            /// as a JSON structure of key/value pairs that the Lambda rotation function knows how to parse.
            /// For storing multiple values, we recommend that you use a JSON text string argument and specify
            /// key/value pairs. For information on how to format a JSON parameter for the various command line tool
            /// environments, see Using JSON for Parameters in the AWS CLI User Guide. For example:
            /// {&quot;username&quot;:&quot;bob&quot;,&quot;password&quot;:&quot;abc123xyz456&quot;}
            /// If your command-line tool or SDK requires quotation marks around the parameter, you should use
            /// single quotes to avoid confusion with the double quotes required in the JSON text.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 65536
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecretString { get; set; }

            /// <summary>
            /// GenerateSecretString
            /// A structure that specifies generating a random password by using the functionality of the
            /// GetRandomPassword API. You can return that string directly to use as the secret value, or you can
            /// specify both the SecretStringTemplate and the GenerateSecretKey parameters. Secrets Manager uses the
            /// value in GenerateSecretKey parameters. Secrets Manager uses the value in GenerateSecretKey as the
            /// key name and combines it with the randomly generated password to make a JSON key-value pair. Secrets
            /// Manager then inserts the pair into the JSON structure specified in the SecretStringTemplate
            /// parameter. Secrets Manager stores the completed string as the secret value in the initial version of
            /// the secret. For more information about how to use this property, see Secrets Manager Secret
            /// GenerateSecretString and the first example in the following Examples section.
            /// Either SecretString or GenerateSecretString must have a value, but not both. They cannot both be
            /// empty.
            /// Required: No
            /// Type: GenerateSecretString
            /// Minimum: 0
            /// Maximum: 65536
            /// Update requires: No interruption
            /// </summary>
            public GenerateSecretString GenerateSecretString { get; set; }

            /// <summary>
            /// Tags
            /// The list of user-defined tags associated with the secret. Use tags to manage your AWS resources. For
            /// additional information about tags, see TagResource.
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
