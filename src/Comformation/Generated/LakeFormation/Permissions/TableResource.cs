using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions TableResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html
    /// </summary>
    public class TableResource
    {

        /// <summary>
        /// DatabaseName
        /// The name of the database for the table. Unique to a Data Catalog. A database is a set of associated
        /// table definitions organized into a logical group. You can Grant and Revoke database privileges to a
        /// principal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogId")]
        public Union<string, IntrinsicFunction> CatalogId { get; set; }

        /// <summary>
        /// TableWildcard
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: TableWildcard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableWildcard")]
        public TableWildcard TableWildcard { get; set; }

        /// <summary>
        /// Name
        /// The name of the table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
