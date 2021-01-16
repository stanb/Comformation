using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxyTargetGroup
{
    /// <summary>
    /// AWS::RDS::DBProxyTargetGroup ConnectionPoolConfigurationInfoFormat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxytargetgroup-connectionpoolconfigurationinfoformat.html
    /// </summary>
    public class ConnectionPoolConfigurationInfoFormat
    {

        /// <summary>
        /// MaxConnectionsPercent
        /// The maximum size of the connection pool for each target in a target group. For Aurora MySQL, it is
        /// expressed as a percentage of the max_connections setting for the RDS DB instance or Aurora DB
        /// cluster used by the target group.
        /// Default: 100
        /// Constraints: between 1 and 100
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConnectionsPercent")]
        public Union<int, IntrinsicFunction> MaxConnectionsPercent { get; set; }

        /// <summary>
        /// MaxIdleConnectionsPercent
        /// Controls how actively the proxy closes idle database connections in the connection pool. A high
        /// value enables the proxy to leave a high percentage of idle connections open. A low value causes the
        /// proxy to close idle client connections and return the underlying database connections to the
        /// connection pool. For Aurora MySQL, it is expressed as a percentage of the max_connections setting
        /// for the RDS DB instance or Aurora DB cluster used by the target group.
        /// Default: 50
        /// Constraints: between 0 and MaxConnectionsPercent
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxIdleConnectionsPercent")]
        public Union<int, IntrinsicFunction> MaxIdleConnectionsPercent { get; set; }

        /// <summary>
        /// ConnectionBorrowTimeout
        /// The number of seconds for a proxy to wait for a connection to become available in the connection
        /// pool. Only applies when the proxy has opened its maximum number of connections and all connections
        /// are busy with client sessions.
        /// Default: 120
        /// Constraints: between 1 and 3600, or 0 representing unlimited
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionBorrowTimeout")]
        public Union<int, IntrinsicFunction> ConnectionBorrowTimeout { get; set; }

        /// <summary>
        /// SessionPinningFilters
        /// Each item in the list represents a class of SQL operations that normally cause all later statements
        /// in a session using a proxy to be pinned to the same underlying database connection. Including an
        /// item in the list exempts that class of SQL operations from the pinning behavior.
        /// Default: no session pinning filters
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionPinningFilters")]
        public List<Union<string, IntrinsicFunction>> SessionPinningFilters { get; set; }

        /// <summary>
        /// InitQuery
        /// One or more SQL statements for the proxy to run when opening each new database connection. Typically
        /// used with SET statements to make sure that each connection has identical settings such as time zone
        /// and character set. For multiple statements, use semicolons as the separator. You can also include
        /// multiple variables in a single SET statement, such as SET x=1, y=2.
        /// Default: no initialization query
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InitQuery")]
        public Union<string, IntrinsicFunction> InitQuery { get; set; }

    }
}
