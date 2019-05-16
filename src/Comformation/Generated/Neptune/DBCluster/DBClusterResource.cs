using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBCluster
{
    /// <summary>
    /// AWS::Neptune::DBCluster
    /// The AWS::Neptune::DBCluster resource creates an Amazon Neptune DB cluster. Neptune is a fully managed graph
    /// database.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB cluster is encrypted.
            /// If you specify the DBClusterIdentifier, DBSnapshotIdentifier, or SourceDBInstanceIdentifier
            /// property, don&#39;t specify this property. The value is inherited from the cluster, snapshot, or source
            /// DB instance. If you specify the KmsKeyId property, you must enable encryption.
            /// If you specify the KmsKeyId, you must enable encryption by setting StorageEncrypted to true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// KmsKeyId
            /// If StorageEncrypted is true, the AWS KMS key identifier for the encrypted DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// Provides the list of EC2 Availability Zones that instances in the DB cluster can be created in.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// Contains the identifier of the source DB cluster if this DB cluster is a Read Replica.
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
            /// Contains a user-supplied DB cluster identifier. This identifier is the unique key that identifies a
            /// DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// Specifies the weekly time range during which system maintenance can occur, in Universal Coordinated
            /// Time (UTC).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// IamAuthEnabled
            /// True if mapping of AWS Identity and Access Management (IAM) accounts to database accounts is
            /// enabled, and otherwise false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> IamAuthEnabled { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// Specifies information on the subnet group associated with the DB cluster, including the name,
            /// description, and subnets in the subnet group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// Specifies the daily time range during which automated backups are created if automated backups are
            /// enabled, as determined by the BackupRetentionPeriod.
            /// An update may require some interruption.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// Provides a list of VPC security groups that the DB cluster belongs to.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// Provides the name of the DB cluster parameter group.
            /// An update may require some interruption. See ModifyDBInstance in the Amazon Neptune User Guide for
            /// more information.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// Specifies the number of days for which automatic DB snapshots are retained.
            /// An update may require some interruption. See ModifyDBInstance in the Amazon Neptune User Guide for
            /// more information.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// The tags assigned to this cluster.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Neptune::DBCluster";

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
