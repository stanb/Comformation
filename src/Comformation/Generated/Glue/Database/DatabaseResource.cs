using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html
    /// </summary>
    public class DatabaseResource : ResourceBase
    {
        public class DatabaseProperties
        {
            /// <summary>
            /// DatabaseInput
            /// The metadata for the database.
            /// Required: Yes
            /// Type: DatabaseInput
            /// Update requires: No interruption
            /// </summary>
            public DatabaseInput DatabaseInput { get; set; }

            /// <summary>
            /// CatalogId
            /// The AWS account ID for the account in which to create the catalog object.
            /// Note To specify the account ID, you can use the Ref intrinsic function with the AWS::AccountId
            /// pseudo parameter. For example: !Ref AWS::AccountId
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Database";

        public DatabaseProperties Properties { get; } = new DatabaseProperties();

    }
}
