using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table ClusteringKeyColumn
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-clusteringkeycolumn.html
    /// </summary>
    public class ClusteringKeyColumn
    {

        /// <summary>
        /// Column
        /// The name and data type of this clustering key column.
        /// Required: Yes
        /// Type: Column
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Column")]
        public Column Column { get; set; }

        /// <summary>
        /// OrderBy
        /// The order in which this column&#39;s data will be stored:
        /// ASC (default) - the column&#39;s data will be stored in ascending order. DESC - the column&#39;s data will
        /// be stored in descending order.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OrderBy")]
        public Union<string, IntrinsicFunction> OrderBy { get; set; }

    }
}
