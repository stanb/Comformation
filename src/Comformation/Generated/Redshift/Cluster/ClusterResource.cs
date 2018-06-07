using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.Cluster
{
    /// <summary>
    /// AWS::Redshift::Cluster
    /// Use the AWS::Redshift::Cluster resource to create an Amazon Redshift cluster. A cluster is a fully managed
    /// data warehouse that consists of a set of compute nodes. For more information about default and valid values,
    /// see CreateCluster in the Amazon Redshift API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// AllowVersionUpgrade
            /// When a new version of Amazon Redshift is released, tells whether upgrades can be applied to the
            /// engine that is running on the cluster. The upgrades are applied during the maintenance window. The
            /// default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-allowversionupgrade
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowVersionUpgrade { get; set; }

            /// <summary>
            /// AutomatedSnapshotRetentionPeriod
            /// The number of days that automated snapshots are retained. The default value is 1. To disable
            /// automated snapshots, set the value to 0.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-automatedsnapshotretentionperiod
            /// </summary>
			public Union<int, IntrinsicFunction> AutomatedSnapshotRetentionPeriod { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Amazon Elastic Compute Cloud (Amazon EC2) Availability Zone in which you want to provision your
            /// Amazon Redshift cluster. For example, if you have several EC2 instances running in a specific
            /// Availability Zone, you might want the cluster to be provisioned in the same zone to decrease network
            /// latency.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// ClusterIdentifier
            /// The unique identifier of the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusteridentifier
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterIdentifier { get; set; }

            /// <summary>
            /// ClusterParameterGroupName
            /// The name of the parameter group that you want to associate with this cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusterparametergroupname
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterParameterGroupName { get; set; }

            /// <summary>
            /// ClusterSecurityGroups
            /// A list of security groups that you want to associate with this cluster. Applies to EC2-Classic.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustersecuritygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ClusterSecurityGroups { get; set; }

            /// <summary>
            /// ClusterSubnetGroupName
            /// The name of a cluster subnet group that you want to associate with this cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustersubnetgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterSubnetGroupName { get; set; }

            /// <summary>
            /// ClusterType
            /// The type of cluster. Specify single-node or multi-node (default).
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clustertype
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterType { get; set; }

            /// <summary>
            /// ClusterVersion
            /// The version of the Amazon Redshift engine that you want to deploy on the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-clusterversion
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterVersion { get; set; }

            /// <summary>
            /// DBName
            /// The name of the first database that will be created when the cluster is created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-dbname
            /// </summary>
			public Union<string, IntrinsicFunction> DBName { get; set; }

            /// <summary>
            /// ElasticIp
            /// The Elastic IP (EIP) address for the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-elasticip
            /// </summary>
			public Union<string, IntrinsicFunction> ElasticIp { get; set; }

            /// <summary>
            /// Encrypted
            /// Indicates whether the data in the cluster is encrypted at rest. The default value is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-encrypted
            /// </summary>
			public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// HsmClientCertificateIdentifier
            /// Specifies the name of the hardware security module (HSM) client certificate that the Amazon Redshift
            /// cluster uses to retrieve the data encryption keys stored in an HSM.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-hsmclientcertidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> HsmClientCertificateIdentifier { get; set; }

            /// <summary>
            /// HsmConfigurationIdentifier
            /// The name of the HSM configuration that contains the information that the Amazon Redshift cluster can
            /// use to retrieve and store keys in an HSM.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-hsmconfigidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> HsmConfigurationIdentifier { get; set; }

            /// <summary>
            /// IamRoles
            /// A list of AWS Identity and Access Management (IAM) roles that the cluster can use to access other
            /// AWS services. Supply the IAM roles by their Amazon Resource Name (ARN). You can provide a maximum of
            /// 10 IAM roles in a single request. A cluster can have a maximum of 10 IAM roles associated with it at
            /// a time.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-iamroles
            /// </summary>
			public Union<List<string>, IntrinsicFunction> IamRoles { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ID of the AWS Key Management Service (AWS KMS) key that you want to use to encrypt data in the
            /// cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-kmskeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// LoggingProperties
            /// Configures Amazon Redshift to create audit log files, containing logging information such as queries
            /// and connection attempts, for this cluster.
            /// Required: No
            /// Type: Amazon Redshift LoggingProperties
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-loggingproperties
            /// </summary>
			public Union<LoggingProperties, IntrinsicFunction> LoggingProperties { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password associated with the master user account for this cluster.
            /// You must specify values for MasterUserName and MasterUserPassword. However, if you're restoring from
            /// an Amazon Redshift snapshot, AWS CloudFormation ignores the specified values and uses the values
            /// that are stored in the snapshot.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-masteruserpassword
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The user name that is associated with the master user account for this cluster.
            /// You must specify values for MasterUserName and MasterUserPassword. However, if you're restoring from
            /// an Amazon Redshift snapshot, AWS CloudFormation ignores the specified values and uses the values
            /// that are stored in the snapshot.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-masterusername
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// NodeType
            /// The node type that is provisioned for this cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-nodetype
            /// </summary>
			public Union<string, IntrinsicFunction> NodeType { get; set; }

            /// <summary>
            /// NodeType
            /// The node type that is provisioned for this cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-nodetype
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfNodes { get; set; }

            /// <summary>
            /// OwnerAccount
            /// When you restore from a snapshot from another AWS account, the 12-digit AWS account ID that contains
            /// that snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-owneraccount
            /// </summary>
			public Union<string, IntrinsicFunction> OwnerAccount { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the cluster accepts incoming connections. The default value is 5439.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-port
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which automated cluster maintenance can occur. The format of
            /// the time range is ddd:hh24:mi-ddd:hh24:mi.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-preferredmaintenancewindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// Indicates whether the cluster can be accessed from a public network.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-publiclyaccessible
            /// </summary>
			public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

            /// <summary>
            /// SnapshotClusterIdentifier
            /// The name of the cluster that the source snapshot was created from. For more information about
            /// restoring from a snapshot, see the RestoreFromClusterSnapshot action in the Amazon Redshift API
            /// Reference.
            /// Required: No
            /// Required: Conditional. This property is required if your IAM policy includes a restriction on the
            /// cluster name and the resource element specifies anything other than the wildcard character (*) for
            /// the cluster name.
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-snapshotclusteridentifier
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotClusterIdentifier { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The name of the snapshot from which to create a new cluster.
            /// Required: Conditional. If you specified the SnapshotClusterIdentifier property, you must specify
            /// this property.
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-snapshotidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this cluster. Use tags to
            /// manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security groups that are associated with this cluster.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html#cfn-redshift-cluster-vpcsecuritygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

        }
    
        public string Type { get; } = "AWS::Redshift::Cluster";
        
        public ClusterProperties Properties { get; } = new ClusterProperties();
    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<string> Endpoint_Address = new ResourceAttribute<string>("Endpoint", "Address");
        public static readonly ResourceAttribute<string> Endpoint_Port = new ResourceAttribute<string>("Endpoint", "Port");
	}
}
