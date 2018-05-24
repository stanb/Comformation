using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html
    /// </summary>
    public class DatabaseResource : ResourceBase
    {
        public class DatabaseProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-databaseinput
            /// </summary>
			public Union<DatabaseInput, IntrinsicFunction> DatabaseInput { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-database.html#cfn-glue-database-catalogid
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Database";
        
        public DatabaseProperties Properties { get; } = new DatabaseProperties();
    }
}
