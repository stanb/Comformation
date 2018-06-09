using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster
    /// The AWS::RDS::DBCluster resource creates a cluster, such as an Aurora for Amazon RDS (Amazon Aurora) DB
    /// cluster. Amazon Aurora is a fully managed, MySQL-compatible, relational database engine. For more information,
    /// see Aurora on Amazon RDS in the Amazon Relational Database Service User Guide.
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
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automatic backups are retained. For more information, see
            /// CreateDBCluster in the Amazon Relational Database Service API Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon Relational Database Service API Reference.
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. First character must be a letter. Cannot end
            /// with a hyphen or contain two consecutive hyphens.
            /// For additional information, see the DBClusterIdentifier parameter of the CreateDBCluster action in
            /// the Amazon Relational Database Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// The name of the DB cluster parameter group to associate with this DB cluster. For the default value,
            /// see the DBClusterParameterGroupName parameter of the CreateDBCluster action in the Amazon Relational
            /// Database Service API Reference.
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
            /// Amazon RDS in the Amazon Relational Database Service User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// Engine
            /// The name of the database engine that you want to use for this DB cluster.
            /// For valid values, see the Engine parameter of the CreateDBCluster action in the Amazon Relational
            /// Database Service API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

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
            /// The port number on which the DB instances in the cluster can accept connections.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// if automated backups are enabled (see the BackupRetentionPeriod property), the daily time range in
            /// UTC during which you want to create automated backups.
            /// For valid values, see the PreferredBackupWindow parameter of the CreateDBInstance action in the
            /// Amazon Relational Database Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur.
            /// For valid values, see the PreferredMaintenanceWindow parameter of the CreateDBInstance action in the
            /// Amazon Relational Database Service API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon Relational Database Service API Reference.
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// ReplicationSourceIdentifier
            /// The Amazon Resource Name (ARN) of the source Amazon RDS MySQL DB instance or DB cluster, if this DB
            /// cluster is created as a Read Replica.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSourceIdentifier { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB cluster snapshot from which you want to restore.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

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
            /// Type: A list of resource tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security groups to associate with this DB cluster.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::DBCluster";
        
        public DBClusterProperties Properties { get; } = new DBClusterProperties();
    }

	public static class DBClusterAttributes
	{
        public static readonly ResourceAttribute<string> Endpoint_Address = new ResourceAttribute<string>("Endpoint", "Address");
        public static readonly ResourceAttribute<string> Endpoint_Port = new ResourceAttribute<string>("Endpoint", "Port");
        public static readonly ResourceAttribute<string> ReadEndpoint_Address = new ResourceAttribute<string>("ReadEndpoint", "Address");
	}
}
