using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions TableWithColumnsResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tablewithcolumnsresource.html
    /// </summary>
    public class TableWithColumnsResource
    {

        /// <summary>
        /// ColumnNames
        /// The list of column names for the table. At least one of ColumnNames or ColumnWildcard is required.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnNames")]
        public List<Union<string, IntrinsicFunction>> ColumnNames { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of the database for the table with columns resource. Unique to the Data Catalog. A database
        /// is a set of associated table definitions organized into a logical group. You can Grant and Revoke
        /// database privileges to a principal.
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
        /// Name
        /// The name of the table resource. A table is a metadata definition that represents your data. You can
        /// Grant and Revoke table privileges to a principal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ColumnWildcard
        /// A wildcard specified by a ColumnWildcard object. At least one of ColumnNames or ColumnWildcard is
        /// required.
        /// Required: No
        /// Type: ColumnWildcard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnWildcard")]
        public ColumnWildcard ColumnWildcard { get; set; }

    }
}
