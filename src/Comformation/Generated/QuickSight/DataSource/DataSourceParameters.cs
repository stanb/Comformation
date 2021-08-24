using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource DataSourceParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-datasourceparameters.html
    /// </summary>
    public class DataSourceParameters
    {

        /// <summary>
        /// AuroraPostgreSqlParameters
        /// Aurora PostgreSQL parameters.
        /// Required: No
        /// Type: AuroraPostgreSqlParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuroraPostgreSqlParameters")]
        public AuroraPostgreSqlParameters AuroraPostgreSqlParameters { get; set; }

        /// <summary>
        /// TeradataParameters
        /// Teradata parameters.
        /// Required: No
        /// Type: TeradataParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TeradataParameters")]
        public TeradataParameters TeradataParameters { get; set; }

        /// <summary>
        /// RdsParameters
        /// Amazon RDS parameters.
        /// Required: No
        /// Type: RdsParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RdsParameters")]
        public RdsParameters RdsParameters { get; set; }

        /// <summary>
        /// AthenaParameters
        /// Amazon Athena parameters.
        /// Required: No
        /// Type: AthenaParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AthenaParameters")]
        public AthenaParameters AthenaParameters { get; set; }

        /// <summary>
        /// SparkParameters
        /// Spark parameters.
        /// Required: No
        /// Type: SparkParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SparkParameters")]
        public SparkParameters SparkParameters { get; set; }

        /// <summary>
        /// MariaDbParameters
        /// MariaDB parameters.
        /// Required: No
        /// Type: MariaDbParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MariaDbParameters")]
        public MariaDbParameters MariaDbParameters { get; set; }

        /// <summary>
        /// OracleParameters
        /// Oracle parameters.
        /// Required: No
        /// Type: OracleParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OracleParameters")]
        public OracleParameters OracleParameters { get; set; }

        /// <summary>
        /// PrestoParameters
        /// Presto parameters.
        /// Required: No
        /// Type: PrestoParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrestoParameters")]
        public PrestoParameters PrestoParameters { get; set; }

        /// <summary>
        /// RedshiftParameters
        /// Amazon Redshift parameters.
        /// Required: No
        /// Type: RedshiftParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedshiftParameters")]
        public RedshiftParameters RedshiftParameters { get; set; }

        /// <summary>
        /// MySqlParameters
        /// MySQL parameters.
        /// Required: No
        /// Type: MySqlParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MySqlParameters")]
        public MySqlParameters MySqlParameters { get; set; }

        /// <summary>
        /// SqlServerParameters
        /// SQL Server parameters.
        /// Required: No
        /// Type: SqlServerParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlServerParameters")]
        public SqlServerParameters SqlServerParameters { get; set; }

        /// <summary>
        /// SnowflakeParameters
        /// Snowflake parameters.
        /// Required: No
        /// Type: SnowflakeParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnowflakeParameters")]
        public SnowflakeParameters SnowflakeParameters { get; set; }

        /// <summary>
        /// AmazonElasticsearchParameters
        /// Amazon Elasticsearch Service parameters.
        /// Required: No
        /// Type: AmazonElasticsearchParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AmazonElasticsearchParameters")]
        public AmazonElasticsearchParameters AmazonElasticsearchParameters { get; set; }

        /// <summary>
        /// PostgreSqlParameters
        /// PostgreSQL parameters.
        /// Required: No
        /// Type: PostgreSqlParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PostgreSqlParameters")]
        public PostgreSqlParameters PostgreSqlParameters { get; set; }

        /// <summary>
        /// AuroraParameters
        /// Amazon Aurora MySQL parameters.
        /// Required: No
        /// Type: AuroraParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuroraParameters")]
        public AuroraParameters AuroraParameters { get; set; }

        /// <summary>
        /// S3Parameters
        /// S3 parameters.
        /// Required: No
        /// Type: S3Parameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Parameters")]
        public S3Parameters S3Parameters { get; set; }

    }
}
