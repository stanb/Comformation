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
            /// (Optional) Specifies the ARN, Key ID, or alias of the AWS KMS key that Secrets Manager uses to
            /// encrypt the SecretString value for versions of this secret. If you don&#39;t specify this value, then
            /// Secrets Manager uses the AWS managed key aws/secretsmanager. If aws/secretsmanager doesn&#39;t exist,
            /// Secrets Manager creates the key the first time it encrypts the value.
            /// Important You must use credentials from the same account that owns the secret to use the AWS managed
            /// key aws/secretsmanager to encrypt and decrypt. If you use credentials from a different account, then
            /// you must create a customer managed key and specify the ARN of the key in this field.
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
            /// Either GenerateSecretString or SecretString must have a value, but not both. They cannot both be
            /// empty. We recommend that you use the GenerateSecretString property to dynamically generate a random
            /// password.
            /// If you create a secret by using the Secrets Manager console then Secrets Manager puts the protected
            /// secret text in only the SecretString parameter. The Secrets Manager console stores the information
            /// as a JSON structure of key/value pairs that the Lambda rotation function knows how to parse.
            /// For storing multiple values, we recommend that you use a JSON text string argument and specify
            /// key/value pairs. For information on how to format a JSON parameter for the various command line tool
            /// environments, see Using JSON for Parameters. For example:
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
            /// (Optional) Specifies text data that you want to encrypt and store in this new version of the secret.
            /// Either GenerateSecretString or SecretString must have a value, but not both. They cannot both be
            /// empty. We recommend that you use the GenerateSecretString property to dynamically generate a random
            /// password.
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
            /// Type: GenerateSecretString
            /// Minimum: 0
            /// Maximum: 65536
            /// Update requires: No interruption
            /// </summary>
            public GenerateSecretString GenerateSecretString { get; set; }

            /// <summary>
            /// ReplicaRegions
            /// (Optional) Custom type consisting of a Region (required) and the KmsKeyId which can be an ARN, Key
            /// ID, or Alias.
            /// Required: No
            /// Type: List of ReplicaRegion
            /// Update requires: No interruption
            /// </summary>
            public List<ReplicaRegion> ReplicaRegions { get; set; }

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
            /// Do not end your secret name with a hyphen followed by six characters. If you do so, you risk
            /// confusion and unexpected results when searching for a secret by partial ARN. Secrets Manager
            /// automatically adds a hyphen and six random characters at the end of the ARN.
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
