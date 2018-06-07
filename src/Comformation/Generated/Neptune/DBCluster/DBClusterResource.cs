using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBCluster
{
    /// <summary>
    /// AWS::Neptune::DBCluster
    /// The AWS::Neptune::DBCluster resource creates a Amazon Neptune DB Cluster. Neptune is a fully managed graph
    /// database. .
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html
    /// </summary>
    public class DBClusterResource : ResourceBase
    {
        public class DBClusterProperties
        {
            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB instances in the cluster are encrypted.
            /// If you specify the SnapshotIdentifier property, do not specify this property. The value is inherited
            /// from the snapshot DB cluster.
            /// Required: Conditional. If you specify the KmsKeyId property, you must enable encryption.
            /// Type: Boolean
            /// Update requires: Replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-storageencrypted
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service master key that is used to encrypt
            /// the database instances in the DB cluster, such as
            /// arn:aws:kms:us-east-1:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If you enable the
            /// StorageEncrypted property but don't specify this property, the default master key is used. If you
            /// specify this property, you must set the StorageEncrypted property to true.
            /// If you specify the SnapshotIdentifier, do not specify this property. The value is inherited from the
            /// snapshot DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-kmskeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// A list of Availability Zones (AZs) in which DB instances in the cluster can be created.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-availabilityzones
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The identifier for the DB cluster snapshot from which you want to restore.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-snapshotidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the DB instances in the cluster can accept connections.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-port
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The DB cluster identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. First character must be a letter. Cannot end
            /// with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-dbclusteridentifier
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur.
            /// For valid values, see the PreferredMaintenanceWindow parameter of the CreateDBInstance action.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-preferredmaintenancewindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// IamAuthEnabled
            /// Enable IAM authentication and authoriation on this cluster.
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-iamauthenabled
            /// </summary>
			public Union<bool, IntrinsicFunction> IamAuthEnabled { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group that you want to associate with this DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-dbsubnetgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// if automated backups are enabled (see the BackupRetentionPeriod property), the daily time range in
            /// UTC during which you want to create automated backups.
            /// For valid values, see the PreferredBackupWindow parameter of the CreateDBInstance action. .
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-preferredbackupwindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security groups to associate with this DB cluster.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-vpcsecuritygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// DBClusterParameterGroupName
            /// The name of the DB cluster parameter group to associate with this DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-dbclusterparametergroupname
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterParameterGroupName { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automatic backups are retained. For more information, see
            /// CreateDBCluster.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-backuprententionperiod
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to this DB cluster.
            /// Required: No
            /// Type: A list of resource tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbcluster.html#cfn-neptune-dbcluster-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Neptune::DBCluster";
        
        public DBClusterProperties Properties { get; } = new DBClusterProperties();
    }

	public static class DBClusterAttributes
	{
        public static readonly ResourceAttribute<string> ClusterResourceId = new ResourceAttribute<string>("ClusterResourceId");
        public static readonly ResourceAttribute<string> Endpoint = new ResourceAttribute<string>("Endpoint");
        public static readonly ResourceAttribute<string> Port = new ResourceAttribute<string>("Port");
        public static readonly ResourceAttribute<string> ReadEndpoint = new ResourceAttribute<string>("ReadEndpoint");
	}
}
