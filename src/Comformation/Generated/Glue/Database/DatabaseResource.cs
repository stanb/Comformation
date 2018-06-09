using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database
    /// The AWS::Glue::Database resource specifies a logical grouping of tables in AWS Glue. For more information, see
    /// Defining a Database in Your Data Catalog and Database Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html
    /// </summary>
    public class DatabaseResource : ResourceBase
    {
        public class DatabaseProperties
        {
            /// <summary>
            /// DatabaseInput
            /// The metadata of the database.
            /// Required: Yes
            /// Type: AWS Glue Database DatabaseInput
            /// Update requires: No interruption
            /// </summary>
			public Union<DatabaseInput, IntrinsicFunction> DatabaseInput { get; set; }

            /// <summary>
            /// CatalogId
            /// The ID of the data catalog to create the catalog object in. Currently, this should be the AWS
            /// account ID.
            /// Note To specify the account ID, you can use the Ref intrinsic function with the AWS::AccountId
            /// pseudo parameter—for example !Ref AWS::AccountId.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Database";
        
        public DatabaseProperties Properties { get; } = new DatabaseProperties();
    }
}
