using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DatabaseConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-databaseconfiguration.html
    /// </summary>
    public class DatabaseConfiguration
    {

        /// <summary>
        /// DatabaseEngineType
        /// The type of database engine that runs the database.
        /// Required: Yes
        /// Type: String
        /// Allowed values: RDS_AURORA_MYSQL | RDS_AURORA_POSTGRESQL | RDS_MYSQL | RDS_POSTGRESQL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseEngineType")]
        public Union<string, IntrinsicFunction> DatabaseEngineType { get; set; }

        /// <summary>
        /// ConnectionConfiguration
        /// The information necessary to connect to a database.
        /// Required: Yes
        /// Type: ConnectionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionConfiguration")]
        public ConnectionConfiguration ConnectionConfiguration { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// Provides information for connecting to an Amazon VPC.
        /// Required: No
        /// Type: DataSourceVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// ColumnConfiguration
        /// Information about where the index should get the document information from the database.
        /// Required: Yes
        /// Type: ColumnConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnConfiguration")]
        public ColumnConfiguration ColumnConfiguration { get; set; }

        /// <summary>
        /// AclConfiguration
        /// Information about the database column that provides information for user context filtering.
        /// Required: No
        /// Type: AclConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AclConfiguration")]
        public AclConfiguration AclConfiguration { get; set; }

        /// <summary>
        /// SqlConfiguration
        /// Provides information about how Amazon Kendra uses quote marks around SQL identifiers when querying a
        /// database data source.
        /// Required: No
        /// Type: SqlConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlConfiguration")]
        public SqlConfiguration SqlConfiguration { get; set; }

    }
}
