using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.GlobalCluster
{
    /// <summary>
    /// AWS::RDS::GlobalCluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-globalcluster.html
    /// </summary>
    public class GlobalClusterResource : ResourceBase
    {
        public class GlobalClusterProperties
        {
            /// <summary>
            /// Engine
            /// The name of the database engine to be used for this DB cluster.
            /// If this property isn&#39;t specified, the database engine is derived from the source DB cluster
            /// specified by the SourceDBClusterIdentifier property.
            /// Note If the SourceDBClusterIdentifier property isn&#39;t specified, this property is required. If the
            /// SourceDBClusterIdentifier property is specified, make sure this property isn&#39;t specified.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The engine version of the Aurora global database.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// DeletionProtection
            /// The deletion protection setting for the new global database. The global database can&#39;t be deleted
            /// when deletion protection is enabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// GlobalClusterIdentifier
            /// The cluster identifier of the global database cluster.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalClusterIdentifier { get; set; }

            /// <summary>
            /// SourceDBClusterIdentifier
            /// The DB cluster identifier or Amazon Resource Name (ARN) to use as the primary cluster of the global
            /// database.
            /// Note If the Engine property isn&#39;t specified, this property is required. If the Engine property is
            /// specified, make sure this property isn&#39;t specified.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceDBClusterIdentifier { get; set; }

            /// <summary>
            /// StorageEncrypted
            /// The storage encryption setting for the global database cluster.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

        }

        public string Type { get; } = "AWS::RDS::GlobalCluster";

        public GlobalClusterProperties Properties { get; } = new GlobalClusterProperties();

    }
}
