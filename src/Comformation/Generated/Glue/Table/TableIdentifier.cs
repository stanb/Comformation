using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    /// AWS::Glue::Table TableIdentifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableidentifier.html
    /// </summary>
    public class TableIdentifier
    {

        /// <summary>
        /// DatabaseName
        /// 	
        /// The name of the catalog database that contains the target table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// 	
        /// The ID of the Data Catalog in which the table resides.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

        /// <summary>
        /// Name
        /// 	
        /// The name of the target table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
