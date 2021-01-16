using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxyTargetGroup
{
    /// <summary>
    /// AWS::RDS::DBProxyTargetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxytargetgroup.html
    /// </summary>
    public class DBProxyTargetGroupResource : ResourceBase
    {
        public class DBProxyTargetGroupProperties
        {
            /// <summary>
            /// DBProxyName
            /// The identifier of the DBProxy that is associated with the DBProxyTargetGroup.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBProxyName { get; set; }

            /// <summary>
            /// TargetGroupName
            /// The identifier for the target group.
            /// Note Currently, this property must be set to default.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetGroupName { get; set; }

            /// <summary>
            /// ConnectionPoolConfigurationInfo
            /// Settings that control the size and behavior of the connection pool associated with a
            /// DBProxyTargetGroup.
            /// Required: No
            /// Type: ConnectionPoolConfigurationInfoFormat
            /// Update requires: No interruption
            /// </summary>
            public ConnectionPoolConfigurationInfoFormat ConnectionPoolConfigurationInfo { get; set; }

            /// <summary>
            /// DBInstanceIdentifiers
            /// One or more DB instance identifiers.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> DBInstanceIdentifiers { get; set; }

            /// <summary>
            /// DBClusterIdentifiers
            /// One or more DB cluster identifiers.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> DBClusterIdentifiers { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBProxyTargetGroup";

        public DBProxyTargetGroupProperties Properties { get; } = new DBProxyTargetGroupProperties();

    }

    public static class DBProxyTargetGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TargetGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TargetGroupArn");
    }
}
