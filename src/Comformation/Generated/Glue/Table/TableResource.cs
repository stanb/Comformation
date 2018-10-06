using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS::Glue::Table
    /// The AWS::Glue::Table resource specifies tabular data in the AWS Glue data catalog. For more information, see
    /// Defining Tables in the AWS Glue Data Catalog and Table Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// TableInput
            /// The metadata of the table.
            /// Required: Yes
            /// Type: AWS Glue Table TableInput
            /// Update requires: Some interruptions
            /// </summary>
			public TableInput TableInput { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the catalog database for the table. It must match the single-line string pattern:
            /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

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
    
        public string Type { get; } = "AWS::Glue::Table";
        
        public TableProperties Properties { get; } = new TableProperties();

    }
}
