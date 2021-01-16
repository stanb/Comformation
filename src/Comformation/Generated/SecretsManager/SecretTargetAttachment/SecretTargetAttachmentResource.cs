using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.SecretTargetAttachment
{
    /// <summary>
    /// AWS::SecretsManager::SecretTargetAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secrettargetattachment.html
    /// </summary>
    public class SecretTargetAttachmentResource : ResourceBase
    {
        public class SecretTargetAttachmentProperties
        {
            /// <summary>
            /// SecretId
            /// The Amazon Resource Name (ARN) or the friendly name of the secret that contains the credentials that
            /// you want to use with the specified service or database. To reference a secret also created in this
            /// template, use the see Ref function with the secret&#39;s logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// TargetType
            /// A string that defines the type of service or database associated with the secret. This value
            /// instructs AWS Secrets Manager how to update the secret with the details of the service or database.
            /// This value must be one of the following:
            /// AWS::RDS::DBInstance AWS::RDS::DBCluster AWS::Redshift::Cluster AWS::DocDB::DBInstance
            /// AWS::DocDB::DBCluster
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// TargetId
            /// The ARN of the service or database credentials stored in the specified secret.
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
