using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table Column
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-column.html
    /// </summary>
    public class Column
    {

        /// <summary>
        /// ColumnName
        /// The name of the column. For more information, see Identifiers in the Amazon Keyspaces Developer
        /// Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnName")]
        public Union<string, IntrinsicFunction> ColumnName { get; set; }

        /// <summary>
        /// ColumnType
        /// The data type of the column. For more information, see Data Types in the Amazon Keyspaces Developer
        /// Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnType")]
        public Union<string, IntrinsicFunction> ColumnType { get; set; }

    }
}
