using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster
    /// The AWS::RDS::DBCluster resource creates a cluster, such as an Aurora for Amazon RDS (Amazon Aurora) DB
    /// cluster. Amazon Aurora is a fully managed, MySQL-compatible, relational database engine. For more information,
    /// see Aurora on Amazon RDS in the Amazon RDS User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
            /// <summary>
            /// AvailabilityZones
            /// A list of Availability Zones (AZs) in which DB instances in the cluster can be created.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// BacktrackWindow
            /// The target backtrack window, in seconds. To disable backtracking, specify 0. If specified, this
            /// property must be set to a number from 0 to 259,200 (72 hours).
            /// Required: No
            /// Type: Long
            /// Update requires: No interruption
            /// </summary>
			public Union<long, IntrinsicFunction> BacktrackWindow { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automatic backups are retained. For more information, see
            /// CreateDBCluster in the Amazon RDS API Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. First character must be a letter. Cannot end
            /// with a hyphen or contain two consecutive hyphens.
            /// For additional information, see the DBClusterIdentifier parameter of the CreateDBCluster action in
            /// the Amazon RDS API Reference.
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
            /// Update requires: Some interruptions
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
            /// The name of your database. If you don&#39;t provide a name, Amazon Relational Database Service (Amazon
            /// RDS) won&#39;t create a database in this DB cluster. For naming constraints, see Naming Constraints in
            /// Amazon RDS in the Amazon RDS User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// DeletionProtection
            /// Indicates whether the DB cluster should have deletion protection enabled. The database can&#39;t be
            /// deleted when this value is set to true. If you want to delete a stack with a protected cluster,
            /// update this value to false before you delete the stack.
            /// For more information, see Deleting a DB Instance.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// EnableCloudwatchLogsExports
            /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The values in the
            /// list depend on the DB engine being used. Log types that are excluded or removed from this list
            /// during updates are disabled. For more information, see Publishing Database Logs to Amazon CloudWatch
            /// Logs in the Amazon Aurora User Guide.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> EnableCloudwatchLogsExports { get; set; }

            /// <summary>
            /// EnableIAMDatabaseAuthentication
            /// If set to true, enables mapping of AWS Identity and Access Management (IAM) accounts to database
            /// accounts.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableIAMDatabaseAuthentication { get; set; }

            /// <summary>
            /// Engine
            /// The name of the database engine that you want to use for this DB cluster.
            /// For valid values, see the Engine parameter of the CreateDBCluster action in the Amazon RDS API
            /// Reference.
            /// Note If you don&#39;t specify a value for the DBClusterParameterGroupName property and default. aurora5.
            /// 6 is used, specifying aurora. mysql or aurora-postgresql for this property might result in an error.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineMode
            /// The DB engine mode of the DB cluster. Valid values include provisioned or serverless.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineMode { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine that you want to use.
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
            /// If you specify the SnapshotIdentifier, do not specify this property. The value is inherited from the
            /// snapshot DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement.
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password for the master database user.
            /// Required: Conditional. You must specify this property unless you specify the SnapshotIdentifier
            /// property. In that case, do not specify this property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The master user name for the DB instance.
            /// Required: Conditional. You must specify this property unless you specify the SnapshotIdentifier
            /// property. In that case, do not specify this property.
            /// Type: String
            /// Update requires: Replacement.
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the DB instances in the cluster can accept connections. If this argument is
            /// omitted, 3306 is used.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// If automated backups are enabled (see the BackupRetentionPeriod property), the daily time range in
            /// UTC during which you want to create automated backups.
            /// For valid values, see the PreferredBackupWindow parameter of the CreateDBInstance action in the
            /// Amazon RDS API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur.
            /// For valid values, see the PreferredMaintenanceWindow parameter of the CreateDBInstance action in the
            /// Amazon RDS API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon RDS API Reference.
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// ReplicationSourceIdentifier
            /// The Amazon Resource Name (ARN) of the source Amazon RDS DB instance or DB cluster, if this DB
            /// cluster is created as a Read Replica.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSourceIdentifier { get; set; }

            /// <summary>
            /// ScalingConfiguration
            /// For DB clusters in serverless DB engine mode, the scaling properties of the DB cluster.
            /// Required: No
            /// Type: ScalingConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ScalingConfiguration ScalingConfiguration { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB cluster snapshot from which you want to restore.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// SourceRegion
            /// </summary>
			public Union<string, IntrinsicFunction> SourceRegion { get; set; }

            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB instances in the cluster are encrypted.
            /// If you specify the SnapshotIdentifier property, do not specify this property. The value is inherited
            /// from the snapshot DB cluster.
            /// Required: Conditional. If you specify the KmsKeyId property, you must enable encryption.
            /// Type: Boolean
            /// Update requires: Replacement.
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to this DB cluster.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security groups to associate with this DB cluster.
            /// Required: No
            /// Type: List of String values
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
