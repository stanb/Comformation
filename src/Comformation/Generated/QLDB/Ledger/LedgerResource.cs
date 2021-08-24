using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QLDB.Ledger
{
    /// <summary>
    /// AWS::QLDB::Ledger
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-ledger.html
    /// </summary>
    public class LedgerResource : ResourceBase
    {
        public class LedgerProperties
        {
            /// <summary>
            /// PermissionsMode
            /// The permissions mode to assign to the ledger that you want to create. This parameter can have one of
            /// the following values:
            /// ALLOW_ALL: A legacy permissions mode that enables access control with API-level granularity for
            /// ledgers. This mode allows users who have the SendCommand API permission for this ledger to run all
            /// PartiQL commands (hence, ALLOW_ALL) on any tables in the specified ledger. This mode disregards any
            /// table-level or command-level IAM permissions policies that you create for the ledger. STANDARD:
            /// (Recommended) A permissions mode that enables access control with finer granularity for ledgers,
            /// tables, and PartiQL commands. By default, this mode denies all user requests to run any PartiQL
            /// commands on any tables in this ledger. To allow PartiQL commands to run, you must create IAM
            /// permissions policies for specific table resources and PartiQL actions, in addition to the
            /// SendCommand API permission for the ledger. For information, see Getting started with the standard
            /// permissions mode in the Amazon QLDB Developer Guide.
            /// Note We strongly recommend using the STANDARD permissions mode to maximize the security of your
            /// ledger data.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ALLOW_ALL | STANDARD
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PermissionsMode { get; set; }

            /// <summary>
            /// DeletionProtection
            /// The flag that prevents a ledger from being deleted by any user. If not provided on ledger creation,
            /// this feature is enabled (true) by default.
            /// If deletion protection is enabled, you must first disable it before you can delete the ledger. You
            /// can disable it by calling the UpdateLedger operation to set the flag to false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// KmsKey
            /// The key in AWS Key Management Service (AWS KMS) to use for encryption of data at rest in the ledger.
            /// For more information, see Encryption at rest in the Amazon QLDB Developer Guide.
            /// Use one of the following options to specify this parameter:
            /// AWS_OWNED_KMS_KEY: Use an AWS KMS key that is owned and managed by AWS on your behalf. Undefined: By
            /// default, use an AWS owned KMS key. A valid symmetric customer managed KMS key: Use the specified KMS
            /// key in your account that you create, own, and manage. Amazon QLDB does not support asymmetric keys.
            /// For more information, see Using symmetric and asymmetric keys in the AWS Key Management Service
            /// Developer Guide.
            /// To specify a customer managed KMS key, you can use its key ID, Amazon Resource Name (ARN), alias
            /// name, or alias ARN. When using an alias name, prefix it with &quot;alias/&quot;. To specify a key in a
            /// different AWS account, you must use the key ARN or alias ARN.
            /// For example:
            /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab Key ARN:
            /// arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab Alias name:
            /// alias/ExampleAlias Alias ARN: arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias
            /// For more information, see Key identifiers (KeyId) in the AWS Key Management Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 1600
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKey { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the ledger that you want to create. The name must be unique among all of the ledgers in
            /// your AWS account in the current Region.
            /// Naming constraints for ledger names are defined in Quotas in Amazon QLDB in the Amazon QLDB
            /// Developer Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: (?!^. *--)(?!^[0-9]+$)(?!^-)(?!. *-$)^[A-Za-z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::QLDB::Ledger";

        public LedgerProperties Properties { get; } = new LedgerProperties();

    }
}
