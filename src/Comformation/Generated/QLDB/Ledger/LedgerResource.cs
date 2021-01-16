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
            /// The permissions mode to assign to the ledger that you want to create.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ALLOW_ALL
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PermissionsMode { get; set; }

            /// <summary>
            /// DeletionProtection
            /// The flag that prevents a ledger from being deleted by any user. If not provided on ledger creation,
            /// this feature is enabled (true) by default.
            /// If deletion protection is enabled, you must first disable it before you can delete the ledger using
            /// the QLDB API or the AWS Command Line Interface (AWS CLI). You can disable it by calling the
            /// UpdateLedger operation to set the flag to false. The QLDB console disables deletion protection for
            /// you when you use it to delete a ledger.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

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
            /// The name of the ledger that you want to create. The name must be unique among all of your ledgers in
            /// the current AWS Region.
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
