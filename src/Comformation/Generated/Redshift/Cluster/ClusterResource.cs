using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.Cluster
{
    /// <summary>
    /// AWS::Redshift::Cluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// AllowVersionUpgrade
            /// If true, major version upgrades can be applied during the maintenance window to the Amazon Redshift
            /// engine that is running on the cluster.
            /// When a new major version of the Amazon Redshift engine is released, you can request that the service
            /// automatically apply upgrades during the maintenance window to the Amazon Redshift engine that is
            /// running on your cluster.
            /// Default: true
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowVersionUpgrade { get; set; }

            /// <summary>
            /// AutomatedSnapshotRetentionPeriod
            /// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are
            /// disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you
            /// want with CreateClusterSnapshot.
            /// Default: 1
            /// Constraints: Must be a value from 0 to 35.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AutomatedSnapshotRetentionPeriod { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For
            /// example, if you have several EC2 instances running in a specific Availability Zone, then you might
            /// want the cluster to be provisioned in the same zone in order to decrease network latency.
            /// Default: A random, system-chosen Availability Zone in the region that is specified by the endpoint.
            /// Example: us-east-2d
            /// Constraint: The specified Availability Zone must be in the same region as the current endpoint.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// ClusterIdentifier
            /// A unique identifier for the cluster. You use this identifier to refer to the cluster for any
            /// subsequent cluster operations such as deleting or modifying. The identifier also appears in the
            /// Amazon Redshift console.
            /// Constraints:
            /// Must contain from 1 to 63 alphanumeric characters or hyphens. Alphabetic characters must be
            /// lowercase. First character must be a letter. Cannot end with a hyphen or contain two consecutive
            /// hyphens. Must be unique for all clusters within an AWS account.
            /// Example: myexamplecluster
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterIdentifier { get; set; }

            /// <summary>
            /// ClusterParameterGroupName
            /// The name of the parameter group to be associated with this cluster.
            /// Default: The default Amazon Redshift cluster parameter group. For information about the default
            /// parameter group, go to Working with Amazon Redshift Parameter Groups
            /// Constraints:
            /// Must be 1 to 255 alphanumeric characters or hyphens. First character must be a letter. Cannot end
            /// with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterParameterGroupName { get; set; }

            /// <summary>
            /// ClusterSecurityGroups
            /// A list of security groups to be associated with this cluster.
            /// Default: The default cluster security group for Amazon Redshift.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ClusterSecurityGroups { get; set; }

            /// <summary>
            /// ClusterSubnetGroupName
            /// The name of a cluster subnet group to be associated with this cluster.
            /// If this parameter is not provided the resulting cluster will be deployed outside virtual private
            /// cloud (VPC).
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterSubnetGroupName { get; set; }

            /// <summary>
            /// ClusterType
            /// The type of the cluster. When cluster type is specified as
            /// single-node, the NumberOfNodes parameter is not required. multi-node, the NumberOfNodes parameter is
            /// required.
            /// Valid Values: multi-node | single-node
            /// Default: multi-node
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterType { get; set; }

            /// <summary>
            /// ClusterVersion
            /// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
            /// The version selected runs on all the nodes in the cluster.
            /// Constraints: Only version 1. 0 is currently available.
            /// Example: 1. 0
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterVersion { get; set; }

            /// <summary>
            /// DBName
            /// The name of the first database to be created when the cluster is created.
            /// To create additional databases after the cluster is created, connect to the cluster with a SQL
            /// client and use SQL commands to create a database. For more information, go to Create a Database in
            /// the Amazon Redshift Database Developer Guide.
            /// Default: dev
            /// Constraints:
            /// Must contain 1 to 64 alphanumeric characters. Must contain only lowercase letters. Cannot be a word
            /// that is reserved by the service. A list of reserved words can be found in Reserved Words in the
            /// Amazon Redshift Database Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBName { get; set; }

            /// <summary>
            /// ElasticIp
            /// The Elastic IP (EIP) address for the cluster.
            /// Constraints: The cluster must be provisioned in EC2-VPC and publicly-accessible through an Internet
            /// gateway. For more information about provisioning clusters in EC2-VPC, go to Supported Platforms to
            /// Launch Your Cluster in the Amazon Redshift Cluster Management Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ElasticIp { get; set; }

            /// <summary>
            /// Encrypted
            /// If true, the data in the cluster is encrypted at rest.
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// HsmClientCertificateIdentifier
            /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses to retrieve the
            /// data encryption keys stored in an HSM.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HsmClientCertificateIdentifier { get; set; }

            /// <summary>
            /// HsmConfigurationIdentifier
            /// Specifies the name of the HSM configuration that contains the information the Amazon Redshift
            /// cluster can use to retrieve and store keys in an HSM.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HsmConfigurationIdentifier { get; set; }

            /// <summary>
            /// IamRoles
            /// A list of AWS Identity and Access Management (IAM) roles that can be used by the cluster to access
            /// other AWS services. You must supply the IAM roles in their Amazon Resource Name (ARN) format. You
            /// can supply up to 10 IAM roles in a single request.
            /// A cluster can have up to 10 IAM roles associated with it at any time.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> IamRoles { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The AWS Key Management Service (KMS) key ID of the encryption key that you want to use to encrypt
            /// data in the cluster.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// LoggingProperties
            /// Specifies logging information, such as queries and connection attempts, for the specified Amazon
            /// Redshift cluster.
            /// Required: No
            /// Type: LoggingProperties
            /// Update requires: No interruption
            /// </summary>
            public LoggingProperties LoggingProperties { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password associated with the master user account for the cluster that is being created.
            /// Constraints:
            /// Must be between 8 and 64 characters in length. Must contain at least one uppercase letter. Must
            /// contain at least one lowercase letter. Must contain one number. Can be any printable ASCII character
            /// (ASCII code 33 to 126) except &#39; (single quote), &quot; (double quote), \, /, @, or space.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The user name associated with the master user account for the cluster that is being created.
            /// Constraints:
            /// Must be 1 - 128 alphanumeric characters. The user name can&#39;t be PUBLIC. First character must be a
            /// letter. Cannot be a reserved word. A list of reserved words can be found in Reserved Words in the
            /// Amazon Redshift Database Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// NodeType
            /// The node type to be provisioned for the cluster. For information about node types, go to Working
            /// with Clusters in the Amazon Redshift Cluster Management Guide.
            /// Valid Values: ds2. xlarge | ds2. 8xlarge | dc1. large | dc1. 8xlarge | dc2. large | dc2. 8xlarge |
            /// ra3. xlplus | ra3. 4xlarge | ra3. 16xlarge
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NodeType { get; set; }

            /// <summary>
            /// NumberOfNodes
            /// The number of compute nodes in the cluster. This parameter is required when the ClusterType
            /// parameter is specified as multi-node.
            /// For information about determining how many nodes you need, go to Working with Clusters in the Amazon
            /// Redshift Cluster Management Guide.
            /// If you don&#39;t specify this parameter, you get a single-node cluster. When requesting a multi-node
            /// cluster, you must specify the number of nodes that you want in the cluster.
            /// Default: 1
            /// Constraints: Value must be at least 1 and no more than 100.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> NumberOfNodes { get; set; }

            /// <summary>
            /// OwnerAccount
            /// The AWS customer account used to create or copy the snapshot. Required if you are restoring a
            /// snapshot you do not own, optional if you own the snapshot.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OwnerAccount { get; set; }

            /// <summary>
            /// Port
            /// The port number on which the cluster accepts incoming connections.
            /// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection
            /// string requires the port on which the cluster will listen for incoming connections.
            /// Default: 5439
            /// Valid Values: 1150-65535
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which automated cluster maintenance can occur.
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// Default: A 30-minute window selected at random from an 8-hour block of time per region, occurring on
            /// a random day of the week. For more information about the time blocks for each region, see
            /// Maintenance Windows in Amazon Redshift Cluster Management Guide.
            /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// If true, the cluster can be accessed from a public network.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

            /// <summary>
            /// SnapshotClusterIdentifier
            /// The name of the cluster the source snapshot was created from. This parameter is required if your IAM
            /// user has a policy containing a snapshot resource element that specifies anything other than * for
            /// the cluster name.
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SnapshotClusterIdentifier { get; set; }

            /// <summary>
            /// SnapshotIdentifier
            /// The name of the snapshot from which to create the new cluster. This parameter isn&#39;t case sensitive.
            /// Example: my-snapshot-id
            /// Required: No
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SnapshotIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// A list of tag instances.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
            /// Default: The default VPC security group is associated with the cluster.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

    public static class ClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Port");
    }
}
