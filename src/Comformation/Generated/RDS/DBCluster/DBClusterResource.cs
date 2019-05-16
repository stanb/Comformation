using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster
    /// The AWS::RDS::DBCluster resource creates an Amazon Aurora DB cluster. For more information, see Managing an
    /// Amazon Aurora DB Cluster in the Amazon Aurora User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
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
            /// Note If this argument is omitted, default. aurora5. 6 is used. If default. aurora5. 6 is used,
            /// specifying aurora-mysql or aurora-postgresql for the Engine property might result in an error.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group that you want to associate with this DB cluster.
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
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> EnableCloudwatchLogsExports { get; set; }

            /// <summary>
            /// EnableIAMDatabaseAuthentication
            /// A value that indicates whether to enable mapping of AWS Identity and Access Management (IAM)
            /// accounts to database accounts. By default, mapping is disabled.
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
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineMode
            /// The DB engine mode of the DB cluster, either provisioned, serverless, parallelquery, or global.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineMode { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine to use.
            /// Note To prevent automatic upgrades, be sure to specify the full version number (for example, 5. 6.
            /// 13). If the default version for the database engine changes and you specify only the major version
            /// (for example, 5. 6), your DB instance will be upgraded to use the new default version. Note that the
            /// default version is not necessarily the latest supported version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

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
            /// Note If you specify the SourceDBInstanceIdentifier or DBSnapshotIdentifier property, don&#39;t specify
            /// this property. The value is inherited from the source DB instance or snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The name of the master user for the DB cluster.
            /// Note You must specify MasterUsername, unless you specify SnapshotIdentifier. In that case, don&#39;t
            /// specify MasterUsername.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the instances in the DB cluster accept connections.
            /// Default: 3306 if engine is set as aurora or 5432 if set to aurora-postgresql.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The daily time range during which automated backups are created if automated backups are enabled
            /// using the BackupRetentionPeriod parameter.
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region. To see the time blocks available, see Adjusting the Preferred DB Cluster Maintenance Window
            /// in the Amazon Aurora User Guide.
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
            /// as a Read Replica.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSourceIdentifier { get; set; }

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
            /// Constraints:
            /// Must match the identifier of an existing Snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

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
            /// Indicates whether the DB instance is encrypted.
            /// If you specify the DBClusterIdentifier, DBSnapshotIdentifier, or SourceDBInstanceIdentifier
            /// property, don&#39;t specify this property. The value is inherited from the cluster, snapshot, or source
            /// DB instance.
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
            /// VpcSecurityGroupIds
            /// A list of EC2 VPC security groups to associate with this DB cluster.
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
