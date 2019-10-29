using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.CacheCluster
{
    /// <summary>
    /// AWS::ElastiCache::CacheCluster
    /// The AWS::ElastiCache::CacheCluster type creates an Amazon ElastiCache cache cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html
    /// </summary>
    public class CacheClusterResource : ResourceBase
    {
        public class CacheClusterProperties
        {
            /// <summary>
            /// AZMode
            /// Specifies whether the nodes in this Memcached cluster are created in a single Availability Zone or
            /// created across multiple Availability Zones in the cluster&#39;s region.
            /// This parameter is only supported for Memcached clusters.
            /// If the AZMode and PreferredAvailabilityZones are not specified, ElastiCache assumes single-az mode.
            /// Required: No
            /// Type: String
            /// Allowed Values: cross-az | single-az
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> AZMode { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// This parameter is currently disabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

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
            /// Additional node type info
            /// All current generation instance types are created in Amazon VPC by default. Redis append-only files
            /// (AOF) are not supported for T1 or T2 instances. Redis Multi-AZ with automatic failover is not
            /// supported on T1 instances. Redis configuration variables appendonly and appendfsync are not
            /// supported on Redis version 2. 8. 22 and later.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            /// CacheParameterGroupName
            /// The name of the parameter group to associate with this cluster. If this argument is omitted, the
            /// default parameter group for the specified engine is used. You cannot use any parameter group which
            /// has cluster-enabled=&#39;yes&#39; when creating a cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            /// CacheSecurityGroupNames
            /// A list of security group names to associate with this cluster.
            /// Use this parameter only when you are creating a cluster outside of an Amazon Virtual Private Cloud
            /// (Amazon VPC).
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CacheSecurityGroupNames { get; set; }

            /// <summary>
            /// CacheSubnetGroupName
            /// The name of the subnet group to be used for the cluster.
            /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private Cloud (Amazon
            /// VPC).
            /// Important If you&#39;re going to launch your cluster in an Amazon VPC, you need to create a subnet group
            /// before you start creating a cluster. For more information, see Subnets and Subnet Groups.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// ClusterName
            /// A name for the cache cluster. If you don&#39;t specify a name, AWSCloudFormation generates a unique
            /// physical ID and uses that ID for the cache cluster. For more information, see Name Type.
            /// The name must contain 1 to 20 alphanumeric characters or hyphens. The name must start with a letter
            /// and cannot end with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// Engine
            /// The name of the cache engine to be used for this cluster.
            /// Valid values for this parameter are: memcached | redis
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the cache engine to be used for this cluster. To view the supported cache
            /// engine versions, use the DescribeCacheEngineVersions operation.
            /// Important: You can upgrade to a newer engine version (see Selecting a Cache Engine and Version), but
            /// you cannot downgrade to an earlier engine version. If you want to use an earlier engine version, you
            /// must delete the existing cluster or replication group and create it anew with the earlier engine
            /// version.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

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
            /// NumCacheNodes
            /// The number of cache nodes that the cache cluster should have.
            /// Note However, if the PreferredAvailabilityZone and PreferredAvailabilityZones properties were not
            /// previously specified and you don&#39;t specify any new values, an update requires replacement.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Some interruptions
            /// </summary>
			public Union<int, IntrinsicFunction> NumCacheNodes { get; set; }

            /// <summary>
            /// Port
            /// The port number on which each of the cache nodes accepts connections.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredAvailabilityZone
            /// The EC2 Availability Zone in which the cluster is created.
            /// All nodes belonging to this Memcached cluster are placed in the preferred Availability Zone. If you
            /// want to create your nodes across multiple Availability Zones, use PreferredAvailabilityZones.
            /// Default: System chosen Availability Zone.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredAvailabilityZone { get; set; }

            /// <summary>
            /// PreferredAvailabilityZones
            /// A list of the Availability Zones in which cache nodes are created. The order of the zones in the
            /// list is not important.
            /// This option is only supported on Memcached.
            /// Note If you are creating your cluster in an Amazon VPC (recommended) you can only locate nodes in
            /// Availability Zones that are associated with the subnets in the selected subnet group. The number of
            /// Availability Zones listed must equal the value of NumCacheNodes.
            /// If you want all the nodes in the same Availability Zone, use PreferredAvailabilityZone instead, or
            /// repeat the Availability Zone multiple times in the list.
            /// Default: System chosen Availability Zones.
            /// Required: No
            /// Type: List of String
            /// Update requires: Some interruptions
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PreferredAvailabilityZones { get; set; }

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
            /// SnapshotArns
            /// A single-element string list containing an Amazon Resource Name (ARN) that uniquely identifies a
            /// Redis RDB snapshot file stored in Amazon S3. The snapshot file is used to populate the node group
            /// (shard). The Amazon S3 object name in the ARN cannot contain any commas.
            /// Note This parameter is only valid if the Engine parameter is redis.
            /// Example of an Amazon S3 ARN: arn:aws:s3:::my_bucket/snapshot1. rdb
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SnapshotArns { get; set; }

            /// <summary>
            /// SnapshotName
            /// The name of a Redis snapshot from which to restore data into the new node group (shard). The
            /// snapshot status changes to restoring while the new node group (shard) is being created.
            /// Note This parameter is only valid if the Engine parameter is redis.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotName { get; set; }

            /// <summary>
            /// SnapshotRetentionLimit
            /// The number of days for which ElastiCache retains automatic snapshots before deleting them. For
            /// example, if you set SnapshotRetentionLimit to 5, a snapshot taken today is retained for 5 days
            /// before being deleted.
            /// Note This parameter is only valid if the Engine parameter is redis.
            /// Default: 0 (i. e. , automatic backups are disabled for this cache cluster).
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
            /// Note This parameter is only valid if the Engine parameter is redis.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotWindow { get; set; }

            /// <summary>
            /// Tags
            /// A list of cost allocation tags to be added to this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// One or more VPC security groups associated with the cluster.
            /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private Cloud (Amazon
            /// VPC).
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::CacheCluster";

        public CacheClusterProperties Properties { get; } = new CacheClusterProperties();

    }

	public static class CacheClusterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationEndpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationEndpoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationEndpoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationEndpoint", "Port");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RedisEndpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("RedisEndpoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RedisEndpoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("RedisEndpoint", "Port");
	}
}
