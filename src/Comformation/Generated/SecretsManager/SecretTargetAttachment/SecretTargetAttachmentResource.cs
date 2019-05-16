using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.SecretTargetAttachment
{
    /// <summary>
    /// AWS::SecretsManager::SecretTargetAttachment
    /// The AWS::SecretsManager::SecretTargetAttachmentresource completes the final link between a Secrets Manager
    /// secret and its associated database. This is required because each has a dependency on the other. No matter
    /// which one you create first, the other doesn&#39;t exist yet. To resolve this, you must create the resources in the
    /// following order:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secrettargetattachment.html
    /// </summary>
    public class SecretTargetAttachmentResource : ResourceBase
    {
        public class SecretTargetAttachmentProperties
        {
            /// <summary>
            /// SecretId
            /// The Amazon Resource Name (ARN) or the friendly name of the secret that contains the credentials that
            /// you want to use with the specified service or database. To reference a secret that&#39;s also created in
            /// this template, use the see Ref function with the secret&#39;s logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// TargetType
            /// A string used by the Secrets Manager console to determine how to parse the structure of the secret
            /// text and place the values in the proper fields of the console user interface. If you created this
            /// secret using the Secrets Manager console then we recommend that you do not modify this value. If
            /// this is a custom secret, then this field is available for your use. As a best practice, do not store
            /// any sensitive information in this field. Instead, store sensitive information in the SecretString or
            /// SecretBinary fields to ensure that it is encrypted.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// TargetId
            /// The ARN of the service or database whose credentials are stored in the specified secret.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetId { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::SecretTargetAttachment";

        public SecretTargetAttachmentProperties Properties { get; } = new SecretTargetAttachmentProperties();

    }
}
