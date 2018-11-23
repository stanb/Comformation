using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.SecretTargetAttachment
{
    /// <summary>
    /// AWS::SecretsManager::SecretTargetAttachment
    /// The AWS::SecretsManager::SecretTargetAttachment resource completes the final link between a Secrets Manager
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
            /// this template, use the Ref function with the secret&#39;s logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// TargetType
            /// A string that defines the type of service or database that&#39;s being associated with the secret. This
            /// value instructs Secrets Manager how to update the secret with the details of the service or
            /// database. This value must be one of the following:
            /// AWS::RDS::DBInstance – Specifies that the database is a single RDS DB instance. AWS::RDS::DBCluster
            /// – Specifies that the database is a multi-instance RDS cluster.
            /// Secrets Manager looks up the details of the specified service or database, and adds the following to
            /// the SecretString field: the appropriate connection details, database engine type, and any other
            /// information that&#39;s required by the standard rotation function template for the specified type.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// TargetId
            /// The ARN of the service or database whose credentials are stored in the specified secret. To
            /// reference a service or database that&#39;s also created in this template, use the Ref function with the
            /// service or database&#39;s logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetId { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::SecretTargetAttachment";

        public SecretTargetAttachmentProperties Properties { get; } = new SecretTargetAttachmentProperties();

    }
}
