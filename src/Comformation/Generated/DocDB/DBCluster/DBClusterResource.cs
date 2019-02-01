using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DocDB.DBCluster
{
    /// <summary>
    /// AWS::DocDB::DBCluster
    /// The AWS::DocDB::DBCluster Amazon DocumentDB (with MongoDB compatibility) resource describes a DBCluster.
    /// Amazon DocumentDB is a fully managed, MongoDB-compatible document database engine. For more information, see
    /// DBCluster in the Amazon DocumentDB Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB instances in the cluster are encrypted.
            /// Required: Conditional. If you specify the KmsKeyId property, you must enable encryption.
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

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
            /// the DB instances in the DB cluster, such as
            /// arn:aws:kms:us-east-1:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If you enable the
            /// StorageEncrypted property but don&#39;t specify this property, the default master key is used. If you
            /// specify this property, you must set the StorageEncrypted property to true.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// A list of Availability Zones (AZs) in which DB instances in the cluster can be created.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB cluster snapshot from which you want to restore.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the DB instances in the cluster can accept connections. If this argument is
            /// omitted, 27017 is used.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints: Length is between [1-63] letters, numbers, or hyphens First character must be a letter
            /// Cannot end with a hyphen or contain two consecutive hyphens Must be unique for all clusters (across
            /// Amazon RDS, Neptune and Amazon DocumentDB) per AWS account, per region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur.
            /// For valid values, see the PreferredMaintenanceWindow parameter of the CreateDBCluster action in the
            /// Amazon DocumentDB Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group that you want to associate with this DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// If automated backups are enabled (see the BackupRetentionPeriod property), the daily time range in
            /// UTC during which automated backups are created.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password for the master database user.
            /// Required: Conditional. You must specify this property unless you specify the SnapshotIdentifier
            /// property. In that case, do not specify this property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security groups to associate with this DB cluster.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// MasterUsername
            /// The master user name for the DB instance.
            /// Required: Conditional. You must specify this property unless you specify the SnapshotIdentifier
            /// property. In that case, do not specify this property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// The name of the DB cluster parameter group to associate with this DB cluster.
            /// Note If this argument is omitted, default. docdb3. 6 is used.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automatic backups are retained. For more information, see Comparing
            /// Automatic and Manual Snapshots in the Amazon DocumentDB Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// A list of up to 50 tags. A tag is metadata assigned to an Amazon DocumentDB resource consisting of a
            /// key-value pair.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DocDB::DBCluster";

        public DBClusterProperties Properties { get; } = new DBClusterProperties();

    }

	public static class DBClusterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClusterResourceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClusterResourceId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Port");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ReadEndpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("ReadEndpoint");
	}
}
