using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
            /// <summary>
            /// AssociatedRoles
            /// Provides a list of the AWS Identity and Access Management (IAM) roles that are associated with the
            /// DB cluster. IAM roles that are associated with a DB cluster grant permission for the DB cluster to
            /// access other Amazon Web Services on your behalf.
            /// Required: No
            /// Type: List of DBClusterRole
            /// Update requires: No interruption
            /// </summary>
            public List<DBClusterRole> AssociatedRoles { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// A list of Availability Zones (AZs) where instances in the DB cluster can be created. For information
            /// on AWS Regions and Availability Zones, see Choosing the Regions and Availability Zones in the Amazon
            /// Aurora User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// BacktrackWindow
            /// The target backtrack window, in seconds. To disable backtracking, set this value to 0.
            /// Note Currently, Backtrack is only supported for Aurora MySQL DB clusters.
            /// Default: 0
            /// Constraints:
            /// If specified, this value must be set to a number from 0 to 259,200 (72 hours).
            /// Required: No
            /// Type: Long
            /// Update requires: No interruption
            /// </summary>
            public Union<long, IntrinsicFunction> BacktrackWindow { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automated backups are retained.
            /// Default: 1
            /// Constraints:
            /// Must be a value from 1 to 35
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// CopyTagsToSnapshot
            /// A value that indicates whether to copy all tags from the DB cluster to snapshots of the DB cluster.
            /// The default is not to copy them.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> CopyTagsToSnapshot { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. First character must be a letter. Can&#39;t end
            /// with a hyphen or contain two consecutive hyphens.
            /// Example: my-cluster1
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// The name of the DB cluster parameter group to associate with this DB cluster.
            /// Important If you apply a parameter group to an existing DB cluster, then its DB instances might need
            /// to reboot. This can result in an outage while the DB instances are rebooting. If you apply a change
            /// to parameter group associated with a stopped DB cluster, then the update stack waits until the DB
            /// cluster is started.
            /// To list all of the available DB cluster parameter group names, use the following command:
            /// aws rds describe-db-cluster-parameter-groups --query &quot;DBClusterParameterGroups[].
            /// DBClusterParameterGroupName&quot; --output text
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group that you want to associate with this DB cluster.
            /// If you are restoring a DB cluster to a point in time with RestoreType set to copy-on-write, and
            /// don&#39;t specify a DB subnet group name, then the DB cluster is restored with a default DB subnet
            /// group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of your database. If you don&#39;t provide a name, then Amazon RDS won&#39;t create a database in
            /// this DB cluster. For naming constraints, see Naming Constraints in the Amazon RDS User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// DeletionProtection
            /// A value that indicates whether the DB cluster has deletion protection enabled. The database can&#39;t be
            /// deleted when deletion protection is enabled. By default, deletion protection is disabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// EnableCloudwatchLogsExports
            /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The values in the
            /// list depend on the DB engine being used. For more information, see Publishing Database Logs to
            /// Amazon CloudWatch Logs in the Amazon Aurora User Guide.
            /// Aurora MySQL
            /// Possible values are audit, error, general, and slowquery.
            /// Aurora PostgreSQL
            /// Possible values are postgresql and upgrade.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EnableCloudwatchLogsExports { get; set; }

            /// <summary>
            /// EnableHttpEndpoint
            /// A value that indicates whether to enable the HTTP endpoint for an Aurora Serverless DB cluster. By
            /// default, the HTTP endpoint is disabled.
            /// When enabled, the HTTP endpoint provides a connectionless web service API for running SQL queries on
            /// the Aurora Serverless DB cluster. You can also query your database from inside the RDS console with
            /// the query editor.
            /// For more information, see Using the Data API for Aurora Serverless in the Amazon Aurora User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableHttpEndpoint { get; set; }

            /// <summary>
            /// EnableIAMDatabaseAuthentication
            /// A value that indicates whether to enable mapping of AWS Identity and Access Management (IAM)
            /// accounts to database accounts. By default, mapping is disabled.
            /// For more information, see IAM Database Authentication in the Amazon Aurora User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableIAMDatabaseAuthentication { get; set; }

            /// <summary>
            /// Engine
            /// The name of the database engine to be used for this DB cluster.
            /// Valid Values: aurora (for MySQL 5. 6-compatible Aurora), aurora-mysql (for MySQL 5. 7-compatible
            /// Aurora), and aurora-postgresql
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineMode
            /// The DB engine mode of the DB cluster, either provisioned, serverless, parallelquery, global, or
            /// multimaster.
            /// The parallelquery engine mode isn&#39;t required for Aurora MySQL version 1. 23 and higher 1. x
            /// versions, and version 2. 09 and higher 2. x versions.
            /// The global engine mode isn&#39;t required for Aurora MySQL version 1. 22 and higher 1. x versions, and
            /// global engine mode isn&#39;t required for any 2. x versions.
            /// The multimaster engine mode only applies for DB clusters created with Aurora MySQL version 5. 6.
            /// 10a.
            /// For Aurora PostgreSQL, the global engine mode isn&#39;t required, and both the parallelquery and the
            /// multimaster engine modes currently aren&#39;t supported.
            /// Limitations and requirements apply to some DB engine modes. For more information, see the following
            /// sections in the Amazon Aurora User Guide:
            /// Limitations of Aurora Serverless Limitations of Parallel Query Limitations of Aurora Global
            /// Databases Limitations of Multi-Master Clusters
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineMode { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine to use.
            /// To list all of the available engine versions for aurora (for MySQL 5. 6-compatible Aurora), use the
            /// following command:
            /// aws rds describe-db-engine-versions --engine aurora --query &quot;DBEngineVersions[]. EngineVersion&quot;
            /// To list all of the available engine versions for aurora-mysql (for MySQL 5. 7-compatible Aurora),
            /// use the following command:
            /// aws rds describe-db-engine-versions --engine aurora-mysql --query &quot;DBEngineVersions[].
            /// EngineVersion&quot;
            /// To list all of the available engine versions for aurora-postgresql, use the following command:
            /// aws rds describe-db-engine-versions --engine aurora-postgresql --query &quot;DBEngineVersions[].
            /// EngineVersion&quot;
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// GlobalClusterIdentifier
            /// If you are configuring an Aurora global database cluster and want your Aurora DB cluster to be a
            /// secondary member in the global database cluster, specify the global cluster ID of the global
            /// database cluster. To define the primary database cluster of the global cluster, use the
            /// AWS::RDS::GlobalCluster resource.
            /// If you aren&#39;t configuring a global database cluster, don&#39;t specify this property.
            /// Note To remove the DB cluster from a global database cluster, specify an empty value for the
            /// GlobalClusterIdentifier property.
            /// For information about Aurora global databases, see Working with Amazon Aurora Global Databases in
            /// the Amazon Aurora User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalClusterIdentifier { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service master key that is used to encrypt
            /// the database instances in the DB cluster, such as
            /// arn:aws:kms:us-east-1:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If you enable the
            /// StorageEncrypted property but don&#39;t specify this property, the default master key is used. If you
            /// specify this property, you must set the StorageEncrypted property to true.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The master password for the DB instance.
            /// Note If you specify the SourceDBClusterIdentifier or SnapshotIdentifier property, don&#39;t specify this
            /// property. The value is inherited from the source DB instance or snapshot.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The name of the master user for the DB cluster.
            /// Note If you specify the SourceDBClusterIdentifier or SnapshotIdentifier property, don&#39;t specify this
            /// property. The value is inherited from the source DB instance or snapshot.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the DB instances in the DB cluster accept connections.
            /// Default:
            /// When EngineMode is provisioned, 3306 (for both Aurora MySQL and Aurora PostgreSQL) When EngineMode
            /// is serverless: 3306 when Engine is aurora or aurora-mysql 5432 when Engine is aurora-postgresql
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The daily time range during which automated backups are created. For more information, see Backup
            /// Window in the Amazon Aurora User Guide.
            /// Constraints:
            /// Must be in the format hh24:mi-hh24:mi. Must be in Universal Coordinated Time (UTC). Must not
            /// conflict with the preferred maintenance window. Must be at least 30 minutes.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region, occurring on a random day of the week. To see the time blocks available, see Adjusting the
            /// Preferred DB Cluster Maintenance Window in the Amazon Aurora User Guide.
            /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// ReplicationSourceIdentifier
            /// The Amazon Resource Name (ARN) of the source DB instance or DB cluster if this DB cluster is created
            /// as a read replica.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ReplicationSourceIdentifier { get; set; }

            /// <summary>
            /// RestoreType
            /// The type of restore to be performed. You can specify one of the following values:
            /// full-copy - The new DB cluster is restored as a full copy of the source DB cluster. copy-on-write -
            /// The new DB cluster is restored as a clone of the source DB cluster.
            /// Constraints: You can&#39;t specify copy-on-write if the engine version of the source DB cluster is
            /// earlier than 1. 11.
            /// If you don&#39;t specify a RestoreType value, then the new DB cluster is restored as a full copy of the
            /// source DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestoreType { get; set; }

            /// <summary>
            /// ScalingConfiguration
            /// The ScalingConfiguration property type specifies the scaling configuration of an Aurora Serverless
            /// DB cluster.
            /// Required: No
            /// Type: ScalingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ScalingConfiguration ScalingConfiguration { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB snapshot or DB cluster snapshot to restore from.
            /// You can use either the name or the Amazon Resource Name (ARN) to specify a DB cluster snapshot.
            /// However, you can use only the ARN to specify a DB snapshot.
            /// After you restore a DB cluster with a SnapshotIdentifier property, you must specify the same
            /// SnapshotIdentifier property for any future updates to the DB cluster. When you specify this property
            /// for an update, the DB cluster is not restored from the snapshot again, and the data in the database
            /// is not changed. However, if you don&#39;t specify the SnapshotIdentifier property, an empty DB cluster
            /// is created, and the original DB cluster is deleted. If you specify a property that is different from
            /// the previous snapshot restore property, a new DB cluster is restored from the specified
            /// SnapshotIdentifier property, and the original DB cluster is deleted.
            /// If you specify the SnapshotIdentifier property to restore a DB cluster (as opposed to specifying it
            /// for DB cluster updates), then don&#39;t specify the following properties:
            /// GlobalClusterIdentifier MasterUsername ReplicationSourceIdentifier RestoreType
            /// SourceDBClusterIdentifier SourceRegion StorageEncrypted UseLatestRestorableTime
            /// Constraints:
            /// Must match the identifier of an existing Snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// SourceDBClusterIdentifier
            /// When restoring a DB cluster to a point in time, the identifier of the source DB cluster from which
            /// to restore.
            /// Constraints:
            /// Must match the identifier of an existing DBCluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceDBClusterIdentifier { get; set; }

            /// <summary>
            /// SourceRegion
            /// The AWS Region which contains the source DB cluster when replicating a DB cluster. For example,
            /// us-east-1.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceRegion { get; set; }

            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB cluster is encrypted.
            /// If you specify the SnapshotIdentifier or SourceDBClusterIdentifier property, don&#39;t specify this
            /// property. The value is inherited from the snapshot or source DB instance.
            /// Important If you specify the KmsKeyId property, then you must enable encryption.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the DB cluster.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// UseLatestRestorableTime
            /// A value that indicates whether to restore the DB cluster to the latest restorable backup time. By
            /// default, the DB cluster is not restored to the latest restorable backup time.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> UseLatestRestorableTime { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of EC2 VPC security groups to associate with this DB cluster.
            /// If you plan to update the resource, don&#39;t specify VPC security groups in a shared VPC.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBCluster";

        public DBClusterProperties Properties { get; } = new DBClusterProperties();

    }

    public static class DBClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Port");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ReadEndpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("ReadEndpoint", "Address");
    }
}
