using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database DatabaseIdentifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseidentifier.html
    /// </summary>
    public class DatabaseIdentifier
    {

        /// <summary>
        /// DatabaseName
        /// 	
        /// The name of the catalog database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// 	
        /// The ID of the Data Catalog in which the database resides.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

    }
}
