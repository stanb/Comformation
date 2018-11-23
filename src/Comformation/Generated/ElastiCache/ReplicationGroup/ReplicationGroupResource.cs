using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::ReplicationGroup
    /// The AWS::ElastiCache::ReplicationGroup resource creates an Amazon ElastiCache Redis replication group. A
    /// replication group is a collection of cache clusters, where one of the clusters is a primary read-write cluster
    /// and the others are read-only replicas.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html
    /// </summary>
    public class ReplicationGroupResource : ResourceBase
    {
        public class ReplicationGroupProperties
        {
            /// <summary>
            /// AtRestEncryptionEnabled
            /// Indicates whether to enable encryption at rest. The default value is false. For more information
            /// about how you can use this property, see CreateReplicationGroup in the Amazon ElastiCache API
            /// Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AtRestEncryptionEnabled { get; set; }

            /// <summary>
            /// AuthToken
            /// The password that&#39;s used to access a password-protected server. For constraints, see
            /// CreateReplicationGroup in the Amazon ElastiCache API Reference.
            /// AuthToken can be specified only on replication groups where TransitEncryptionEnabled is true.
            /// Important For HIPAA compliance, you must specify TransitEncryptionEnabled as true, an AuthToken, and
            /// a CacheSubnetGroupName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AuthToken { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Currently, this property isn&#39;t used by ElastiCache.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// AutomaticFailoverEnabled
            /// Indicates whether Multi-AZ is enabled. When Multi-AZ is enabled, a read-only replica is
            /// automatically promoted to a read-write primary cluster if the existing primary cluster fails. If you
            /// specify true, you must specify a value greater than 1 for the NumCacheClusters property. By default,
            /// AWS CloudFormation sets the value to true.
            /// For Redis (clustered mode enabled) replication groups, you must enable automatic failover.
            /// For information about Multi-AZ constraints, see Replication with Multi-AZ and Automatic Failover
            /// (Redis) in the Amazon ElastiCache User Guide.
            /// Note You cannot enable automatic failover for Redis versions earlier than 2. 8. 6 or for T1 cache
            /// node types. Automatic failover is supported on T2 node types only if you are running Redis version
            /// 3. 2. 4 or later with cluster mode enabled.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutomaticFailoverEnabled { get; set; }

            /// <summary>
            /// CacheNodeType
            /// The compute and memory capacity of nodes in the node group. For valid values, see
            /// CreateReplicationGroup in the Amazon ElastiCache API Reference Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            /// CacheParameterGroupName
            /// The name of the parameter group to associate with this replication group. For valid and default
            /// values, see CreateReplicationGroup in the Amazon ElastiCache API Reference Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            /// CacheSecurityGroupNames
            /// A list of cache security group names to associate with this replication group.
            /// Important If you specify the CacheSecurityGroupNames property, don&#39;t also specify the
            /// SecurityGroupIds property. The SecurityGroupIds property is only for Amazon Virtual Private Cloud
            /// (Amazon VPC) security groups. If you specify an Amazon VPC security group, the deployment fails.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CacheSecurityGroupNames { get; set; }

            /// <summary>
            /// CacheSubnetGroupName
            /// The name of a cache subnet group to use for this replication group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// Engine
            /// The name of the cache engine to use for the cache clusters in this replication group. Currently, you
            /// can specify only redis.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the cache engine to use for the cache clusters in this replication group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// NodeGroupConfiguration
            /// Configuration options for the node group (shard).
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: No
            /// Type: List of Amazon ElastiCache ReplicationGroup NodeGroupConfiguration
            /// Update requires: Some interruptions Update requires no interruption if the resource contains an
            /// UseOnlineResharding update policy set to true. Update requires replacement if the resource does not
            /// contain an UseOnlineResharding update policy, or the policy is set to false. For more information,
            /// see UseOnlineResharding Policy.
            /// </summary>
			public List<NodeGroupConfiguration> NodeGroupConfiguration { get; set; }

            /// <summary>
            /// NotificationTopicArn
            /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service topic to which
            /// notifications are sent.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicArn { get; set; }

            /// <summary>
            /// NumCacheClusters
            /// The number of cache clusters for this replication group. If automatic failover is enabled, you must
            /// specify a value greater than 1. For valid values, see CreateReplicationGroup in the Amazon
            /// ElastiCache API Reference Guide.
            /// If you specify more than one node group (shard), this property is ignored. Use the
            /// ReplicasPerNodeGroup property instead.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumCacheClusters { get; set; }

            /// <summary>
            /// NumNodeGroups
            /// The number of node groups (shards) for this Redis (clustered mode enabled) replication group. For
            /// Redis (clustered mode disabled), either omit this property or set it to 1.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: No
            /// Type: Integer
            /// Update requires: Some interruptions Update requires no interruption if the resource contains an
            /// UseOnlineResharding update policy set to true. Update requires replacement if the resource does not
            /// contain an UseOnlineResharding update policy, or the policy is set to false. For more information,
            /// see UseOnlineResharding Policy.
            /// </summary>
			public Union<int, IntrinsicFunction> NumNodeGroups { get; set; }

            /// <summary>
            /// Port
            /// The port number on which each member of the replication group accepts connections.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredCacheClusterAZs
            /// A list of Availability Zones in which the cache clusters in this replication group are created.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PreferredCacheClusterAZs { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur. Use the following format to specify
            /// a time range: ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). For example, you can specify
            /// sun:22:00-sun:23:30 for Sunday from 10 PM to 11:30 PM.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// PrimaryClusterId
            /// The cache cluster that ElastiCache uses as the primary cluster for the replication group. The cache
            /// cluster must have a status of available.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: Conditional. This property is optional if you specify the NumCacheClusters, NumNodeGroups,
            /// or ReplicasPerNodeGroup properties.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PrimaryClusterId { get; set; }

            /// <summary>
            /// ReplicasPerNodeGroup
            /// The number of replica nodes in each node group (shard). For valid values, see CreateReplicationGroup
            /// in the Amazon ElastiCache API Reference Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> ReplicasPerNodeGroup { get; set; }

            /// <summary>
            /// ReplicationGroupDescription
            /// A description of the replication group.
            /// Important If you specify the PrimaryClusterId, you can use only the following additional parameters:
            /// AutomaticFailoverEnabled NodeGroupConfiguration NumCacheClusters NumNodeGroups
            /// PreferredCacheClusterAZs ReplicationGroupDescription
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupDescription { get; set; }

            /// <summary>
            /// ReplicationGroupId
            /// An ID for the replication group. If you don&#39;t specify an ID, AWS CloudFormation generates a unique
            /// physical ID. For more information, see Name Type.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupId { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of Amazon Virtual Private Cloud (Amazon VPC) security groups to associate with this
            /// replication group.
            /// Important If you specify the SecurityGroupIds property, don&#39;t also specify the
            /// CacheSecurityGroupNames property. The CacheSecurityGroupNames property is only for EC2-Classic
            /// security groups. If you specify an EC2-Classic security group, the deployment fails.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SnapshotArns
            /// A single-element string list that specifies an ARN of a Redis . rdb snapshot file that is stored in
            /// Amazon Simple Storage Service (Amazon S3). The snapshot file populates the node group. The Amazon S3
            /// object name in the ARN cannot contain commas. For example, you can specify
            /// arn:aws:s3:::my_bucket/snapshot1. rdb.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SnapshotArns { get; set; }

            /// <summary>
            /// SnapshotName
            /// The name of a snapshot from which to restore data into the replication group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotName { get; set; }

            /// <summary>
            /// SnapshotRetentionLimit
            /// The number of days that ElastiCache retains automatic snapshots before deleting them.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> SnapshotRetentionLimit { get; set; }

            /// <summary>
            /// SnapshotWindow
            /// The time range (in UTC) when ElastiCache takes a daily snapshot of the node group that you specified
            /// in the SnapshottingClusterId property. For example, you can specify 05:00-09:00.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotWindow { get; set; }

            /// <summary>
            /// SnapshottingClusterId
            /// The ID of the cache cluster that ElastiCache uses as the daily snapshot source for the replication
            /// group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshottingClusterId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this replication group.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TransitEncryptionEnabled
            /// Indicates whether to enable in-transit encryption. The default value is false. For more information
            /// about how you can use this property, see CreateReplicationGroup in the Amazon ElastiCache API
            /// Reference.
            /// If you enable TransitEncryptionEnabled, then you must also specify CacheSubnetGroupName.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> TransitEncryptionEnabled { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::ReplicationGroup";

        public ReplicationGroupProperties Properties { get; } = new ReplicationGroupProperties();

    }

	public static class ReplicationGroupAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationEndPoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationEndPoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationEndPoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationEndPoint", "Port");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrimaryEndPoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrimaryEndPoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrimaryEndPoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrimaryEndPoint", "Port");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ReadEndPoint_Addresses = new ResourceAttribute<Union<string, IntrinsicFunction>>("ReadEndPoint", "Addresses");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> ReadEndPoint_Addresses_List = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("ReadEndPoint", "Addresses", "List");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ReadEndPoint_Ports = new ResourceAttribute<Union<string, IntrinsicFunction>>("ReadEndPoint", "Ports");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> ReadEndPoint_Ports_List = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("ReadEndPoint", "Ports", "List");
	}
}
