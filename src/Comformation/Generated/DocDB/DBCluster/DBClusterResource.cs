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
            /// Specifies whether the DB cluster is encrypted.
            /// Required: Conditional
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine to use.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The AWS KMS key identifier for an encrypted DB cluster.
            /// The AWS KMS key identifier is the Amazon Resource Name (ARN) for the AWS KMS encryption key. If you
            /// are creating a DB cluster using the same AWS account that owns the AWS KMS encryption key that is
            /// used to encrypt the new DB cluster, you can use the AWS KMS key alias instead of the ARN for the AWS
            /// KMS encryption key.
            /// If an encryption key is not specified in KmsKeyId:
            /// If ReplicationSourceIdentifier identifies an encrypted source, then Amazon DocumentDB uses the
            /// encryption key that is used to encrypt the source. Otherwise, Amazon DocumentDB uses your default
            /// encryption key. If the StorageEncrypted parameter is true and ReplicationSourceIdentifier is not
            /// specified, Amazon DocumentDB uses your default encryption key.
            /// AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different
            /// default encryption key for each AWS Region.
            /// If you create a replica of an encrypted DB cluster in another AWS Region, you must set KmsKeyId to a
            /// KMS key ID that is valid in the destination AWS Region. This key is used to encrypt the replica in
            /// that AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// A list of Amazon EC2 Availability Zones that instances in the DB cluster can be created in.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB snapshot or DB cluster snapshot to restore from.
            /// You can use either the name or the Amazon Resource Name (ARN) to specify a DB cluster snapshot.
            /// However, you can use only the ARN to specify a DB snapshot.
            /// Constraints:
            /// Must match the identifier of an existing snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// Port
            /// Specifies the port that the database engine is listening on.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. The first character must be a letter. Cannot
            /// end with a hyphen or contain two consecutive hyphens.
            /// Example: my-cluster
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region, occurring on a random day of the week.
            /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group to associate with this DB cluster.
            /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be default.
            /// Example: mySubnetgroup
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The daily time range during which automated backups are created if automated backups are enabled
            /// using the BackupRetentionPeriod parameter.
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region.
            /// Constraints:
            /// Must be in the format hh24:mi-hh24:mi. Must be in Universal Coordinated Time (UTC). Must not
            /// conflict with the preferred maintenance window. Must be at least 30 minutes.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password for the master database user. This password can contain any printable ASCII character
            /// except forward slash (/), double quote (&quot;), or the &quot;at&quot; symbol (@).
            /// Constraints: Must contain from 8 to 41 characters.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of EC2 VPC security groups to associate with this DB cluster.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// MasterUsername
            /// The name of the master user for the DB cluster.
            /// Constraints:
            /// Must be from 1 to 16 letters or numbers. The first character must be a letter. Cannot be a reserved
            /// word for the chosen database engine.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// The name of the DB cluster parameter group to associate with this DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automated backups are retained. You must specify a minimum value of 1.
            /// Default: 1
            /// Constraints:
            /// Must be a value from 1 to 35.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// The tags to be assigned to the DB cluster.
            /// Required: No
            /// Type: List of Tag
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
