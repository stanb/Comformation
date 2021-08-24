using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet CustomSql
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-customsql.html
    /// </summary>
    public class CustomSql
    {

        /// <summary>
        /// DataSourceArn
        /// The Amazon Resource Name (ARN) of the data source.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSourceArn")]
        public Union<string, IntrinsicFunction> DataSourceArn { get; set; }

        /// <summary>
        /// SqlQuery
        /// The SQL query.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 65536
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlQuery")]
        public Union<string, IntrinsicFunction> SqlQuery { get; set; }

        /// <summary>
        /// Columns
        /// The column schema from the SQL query result set.
        /// Required: Yes
        /// Type: List of InputColumn
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Columns")]
        public List<InputColumn> Columns { get; set; }

        /// <summary>
        /// Name
        /// A display name for the SQL query result.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
