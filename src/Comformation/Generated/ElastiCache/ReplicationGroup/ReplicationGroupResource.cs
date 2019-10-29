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
            /// A flag that enables encryption at rest when set to true.
            /// You cannot modify the value of AtRestEncryptionEnabled after the replication group is created. To
            /// enable encryption at rest on a replication group you must set AtRestEncryptionEnabled to true when
            /// you create the replication group.
            /// Required: Only available when creating a replication group in an Amazon VPC using redis version 3.
            /// 2. 6 or 4. x onward.
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AtRestEncryptionEnabled { get; set; }

            /// <summary>
            /// AuthToken
            /// Reserved parameter. The password used to access a password protected server.
            /// AuthToken can be specified only on replication groups where TransitEncryptionEnabled is true.
            /// Important For HIPAA compliance, you must specify TransitEncryptionEnabled as true, an AuthToken, and
            /// a CacheSubnetGroup.
            /// Password constraints:
            /// Must be only printable ASCII characters. Must be at least 16 characters and no more than 128
            /// characters in length. Cannot contain any of the following characters: &#39;/&#39;, &#39;&quot;&#39;, or &#39;@&#39;.
            /// For more information, see AUTH password at http://redis. io/commands/AUTH.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AuthToken { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// This parameter is currently disabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// AutomaticFailoverEnabled
            /// Specifies whether a read-only replica is automatically promoted to read/write primary if the
            /// existing primary fails.
            /// If true, Multi-AZ is enabled for this replication group. If false, Multi-AZ is disabled for this
            /// replication group.
            /// AutomaticFailoverEnabled must be enabled for Redis (cluster mode enabled) replication groups.
            /// Default: false
            /// Amazon ElastiCache for Redis does not support Multi-AZ with automatic failover on:
            /// Redis versions earlier than 2. 8. 6. Redis (cluster mode disabled): T1 node types. Redis (cluster
            /// mode enabled): T1 node types.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutomaticFailoverEnabled { get; set; }

            /// <summary>
            /// CacheNodeType
            /// The compute and memory capacity of the nodes in the node group (shard).
            /// The following node types are supported by ElastiCache. 			Generally speaking, the current generation
            /// types provide more memory and computational power 			at lower cost when compared to their equivalent
            /// previous generation counterparts.
            /// General purpose: Current generation: M5 node types: cache. m5. large, cache. m5. xlarge, cache. m5.
            /// 2xlarge, cache. m5. 4xlarge, cache. m5. 12xlarge, cache. m5. 24xlarge 	 M4 node types: cache. m4.
            /// large, cache. m4. xlarge, cache. m4. 2xlarge, cache. m4. 4xlarge, cache. m4. 10xlarge T2 node types:
            /// cache. t2. micro, cache. t2. small, cache. t2. medium Previous generation: (not recommended) T1 node
            /// types: cache. t1. micro M1 node types: cache. m1. small, cache. m1. medium, cache. m1. large, cache.
            /// m1. xlarge M3 node types: cache. m3. medium, cache. m3. large, cache. m3. xlarge, cache. m3. 2xlarge
            /// Compute optimized: Previous generation: (not recommended) C1 node types: cache. c1. xlarge Memory
            /// optimized: Current generation: R5 node types: cache. r5. large, cache. r5. xlarge, cache. r5.
            /// 2xlarge, cache. r5. 4xlarge, cache. r5. 12xlarge, cache. r5. 24xlarge R4 node types: cache. r4.
            /// large, cache. r4. xlarge, cache. r4. 2xlarge, cache. r4. 4xlarge, cache. r4. 8xlarge, cache. r4.
            /// 16xlarge Previous generation: (not recommended) M2 node types:						 cache. m2. xlarge, cache. m2.
            /// 2xlarge, cache. m2. 4xlarge R3 node types: cache. r3. large, cache. r3. xlarge, cache. r3. 2xlarge,
            /// cache. r3. 4xlarge, cache. r3. 8xlarge
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            /// CacheParameterGroupName
            /// The name of the parameter group to associate with this replication group. If this argument is
            /// omitted, the default cache parameter group for the specified engine is used.
            /// Note If you are restoring to an engine version that is different than the original, you must specify
            /// the default version of that version. For example, CacheParameterGroupName=default. redis4. 0.
            /// If you are running Redis version 3. 2. 4 or later, only one node group (shard), and want to use a
            /// default parameter group, we recommend that you specify the parameter group by name.
            /// To create a Redis (cluster mode disabled) replication group, use CacheParameterGroupName=default.
            /// redis3. 2. To create a Redis (cluster mode enabled) replication group, use
            /// CacheParameterGroupName=default. redis3. 2. cluster. on.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            /// CacheSecurityGroupNames
            /// A list of cache security group names to associate with this replication group.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CacheSecurityGroupNames { get; set; }

            /// <summary>
            /// CacheSubnetGroupName
            /// The name of the cache subnet group to be used for the replication group.
            /// Important If you&#39;re going to launch your cluster in an Amazon VPC, you need to create a subnet group
            /// before you start creating a cluster. For more information, see Subnets and Subnet Groups.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// Engine
            /// The name of the cache engine to be used for the clusters in this replication group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the cache engine to be used for the clusters in this replication group. To
            /// view the supported cache engine versions, use the DescribeCacheEngineVersions operation.
            /// Important: You can upgrade to a newer engine version (see Selecting a Cache Engine and Version) in
            /// the ElastiCache User Guide, but you cannot downgrade to an earlier engine version. If you want to
            /// use an earlier engine version, you must delete the existing cluster or replication group and create
            /// it anew with the earlier engine version.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ID of the KMS key used to encrypt the disk on the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// NodeGroupConfiguration
            /// NodeGroupConfiguration is a property of the AWS::ElastiCache::ReplicationGroup resource that
            /// configures an Amazon ElastiCache (ElastiCache) Redis cluster node group.
            /// If you set UseOnlineResharding to true, you can update NodeGroupConfiguration without interruption.
            /// When UseOnlineResharding is set to false, or is not specified, updating NodeGroupConfiguration
            /// results in replacement.
            /// Required: No
            /// Type: List of NodeGroupConfiguration
            /// Update requires: Some interruptions
            /// </summary>
			public List<NodeGroupConfiguration> NodeGroupConfiguration { get; set; }

            /// <summary>
            /// NotificationTopicArn
            /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic to which
            /// notifications are sent.
            /// Note The Amazon SNS topic owner must be the same as the cluster owner.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicArn { get; set; }

            /// <summary>
            /// NumCacheClusters
            /// The number of clusters this replication group initially has.
            /// This parameter is not used if there is more than one node group (shard). You should use
            /// ReplicasPerNodeGroup instead.
            /// If AutomaticFailoverEnabled is true, the value of this parameter must be at least 2. If
            /// AutomaticFailoverEnabled is false you can omit this parameter (it will default to 1), or you can
            /// explicitly set it to a value between 2 and 6.
            /// The maximum permitted value for NumCacheClusters is 6 (1 primary plus 5 replicas).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumCacheClusters { get; set; }

            /// <summary>
            /// NumNodeGroups
            /// An optional parameter that specifies the number of node groups (shards) for this Redis (cluster mode
            /// enabled) replication group. For Redis (cluster mode disabled) either omit this parameter or set it
            /// to 1.
            /// If you set UseOnlineResharding to true, you can update NumNodeGroups without interruption. When
            /// UseOnlineResharding is set to false, or is not specified, updating NumNodeGroups results in
            /// replacement.
            /// Default: 1
            /// Required: No
            /// Type: Integer
            /// Update requires: Some interruptions
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
            /// A list of EC2 Availability Zones in which the replication group&#39;s clusters are created. The order of
            /// the Availability Zones in the list is the order in which clusters are allocated. The primary cluster
            /// is created in the first AZ in the list.
            /// This parameter is not used if there is more than one node group (shard). You should use
            /// NodeGroupConfiguration instead.
            /// Note If you are creating your replication group in an Amazon VPC (recommended), you can only locate
            /// clusters in Availability Zones associated with the subnets in the selected subnet group. The number
            /// of Availability Zones listed must equal the value of NumCacheClusters.
            /// Default: system chosen Availability Zones.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PreferredCacheClusterAZs { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// Specifies the weekly time range during which maintenance on the cluster is performed. It is
            /// specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance
            /// window is a 60 minute period. Valid values for ddd are:
            /// Specifies the weekly time range during which maintenance on the cluster is performed. It is
            /// specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance
            /// window is a 60 minute period.
            /// Valid values for ddd are:
            /// sun mon tue wed thu fri sat
            /// Example: sun:23:00-mon:01:30
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// PrimaryClusterId
            /// The identifier of the cluster that serves as the primary for this replication group. This cluster
            /// must already exist and have a status of available.
            /// This parameter is not required if NumCacheClusters, NumNodeGroups, or ReplicasPerNodeGroup is
            /// specified.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PrimaryClusterId { get; set; }

            /// <summary>
            /// ReplicasPerNodeGroup
            /// An optional parameter that specifies the number of replica nodes in each node group (shard). Valid
            /// values are 0 to 5.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> ReplicasPerNodeGroup { get; set; }

            /// <summary>
            /// ReplicationGroupDescription
            /// A user-created description for the replication group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupDescription { get; set; }

            /// <summary>
            /// ReplicationGroupId
            /// The replication group identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// A name must contain from 1 to 40 alphanumeric characters or hyphens. The first character must be a
            /// letter. A name cannot end with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupId { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// One or more Amazon VPC security groups associated with this replication group.
            /// Use this parameter only when you are creating a replication group in an Amazon Virtual Private Cloud
            /// (Amazon VPC).
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SnapshotArns
            /// A list of Amazon Resource Names (ARN) that uniquely identify the Redis RDB snapshot files stored in
            /// Amazon S3. The snapshot files are used to populate the new replication group. The Amazon S3 object
            /// name in the ARN cannot contain any commas. The new replication group will have the number of node
            /// groups (console: shards) specified by the parameter NumNodeGroups or the number of node groups
            /// configured by NodeGroupConfiguration regardless of the number of ARNs specified here.
            /// Example of an Amazon S3 ARN: arn:aws:s3:::my_bucket/snapshot1. rdb
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SnapshotArns { get; set; }

            /// <summary>
            /// SnapshotName
            /// The name of a snapshot from which to restore data into the new replication group. The snapshot
            /// status changes to restoring while the new replication group is being created.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotName { get; set; }

            /// <summary>
            /// SnapshotRetentionLimit
            /// The number of days for which ElastiCache retains automatic snapshots before deleting them. For
            /// example, if you set SnapshotRetentionLimit to 5, a snapshot that was taken today is retained for 5
            /// days before being deleted.
            /// Default: 0 (i. e. , automatic backups are disabled for this cluster).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> SnapshotRetentionLimit { get; set; }

            /// <summary>
            /// SnapshotWindow
            /// The daily time range (in UTC) during which ElastiCache begins taking a daily snapshot of your node
            /// group (shard).
            /// Example: 05:00-09:00
            /// If you do not specify this parameter, ElastiCache automatically chooses an appropriate time range.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotWindow { get; set; }

            /// <summary>
            /// SnapshottingClusterId
            /// The cluster ID that is used as the daily snapshot source for the replication group. This parameter
            /// cannot be set for Redis (cluster mode enabled) replication groups.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshottingClusterId { get; set; }

            /// <summary>
            /// Tags
            /// A list of cost allocation tags to be added to this resource. Tags are comma-separated key,value
            /// pairs (e. g. Key=myKey, Value=myKeyValue. You can include multiple tags as shown following:
            /// Key=myKey, Value=myKeyValue Key=mySecondKey, Value=mySecondKeyValue.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TransitEncryptionEnabled
            /// A flag that enables in-transit encryption when set to true.
            /// You cannot modify the value of TransitEncryptionEnabled after the cluster is created. To enable
            /// in-transit encryption on a cluster you must set TransitEncryptionEnabled to true when you create a
            /// cluster.
            /// This parameter is valid only if the Engine parameter is redis, the EngineVersion parameter is 3. 2.
            /// 6 or 4. x or 5. x, and the cluster is being created in an Amazon VPC.
            /// If you enable in-transit encryption, you must also specify a value for CacheSubnetGroup.
            /// Required: Only available when creating a replication group in an Amazon VPC using redis version 3.
            /// 2. 6 or 4. x onward.
            /// Default: false
            /// Important For HIPAA compliance, you must specify TransitEncryptionEnabled as true, an AuthToken, and
            /// a CacheSubnetGroup.
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
