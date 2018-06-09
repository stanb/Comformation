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
            /// For Memcached cache clusters, indicates whether the nodes are created in a single Availability Zone
            /// or across multiple Availability Zones in the cluster&#39;s region. For valid values, see
            /// CreateCacheCluster in the Amazon ElastiCache API Reference.
            /// Required: Conditional. If you specify multiple Availability Zones in the PreferredAvailabilityZones
            /// property, you must specify cross Availability Zones for this property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AZMode { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor engine upgrades will be applied automatically to the cache cluster during the
            /// maintenance window.
            /// Required: No
            /// Type: Boolean
            /// Default: true
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// CacheNodeType
            /// The compute and memory capacity of nodes in a cache cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            /// CacheParameterGroupName
            /// The name of the cache parameter group that is associated with this cache cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            /// CacheSecurityGroupNames
            /// A list of cache security group names that are associated with this cache cluster. If your cache
            /// cluster is in a VPC, specify the VpcSecurityGroupIds property instead.
            /// Required: Conditional: If your cache cluster isn&#39;t in a VPC, you must specify this property.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> CacheSecurityGroupNames { get; set; }

            /// <summary>
            /// CacheSubnetGroupName
            /// The cache subnet group that you associate with a cache cluster.
            /// Required: Conditional. If you specified the VpcSecurityGroupIds property, you must specify this
            /// property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            /// ClusterName
            /// A name for the cache cluster. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the cache cluster. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// The name must contain 1 to 20 alphanumeric characters or hyphens. The name must start with a letter
            /// and cannot end with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// Engine
            /// The name of the cache engine to be used for this cache cluster, such as memcached or redis.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version of the cache engine to be used for this cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// NotificationTopicArn
            /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic to which
            /// notifications will be sent.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicArn { get; set; }

            /// <summary>
            /// NumCacheNodes
            /// The number of cache nodes that the cache cluster should have.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption. However, if the PreferredAvailabilityZone and
            /// PreferredAvailabilityZones properties were not previously specified and you don&#39;t specify any new
            /// values, an update requires replacement.
            /// </summary>
			public Union<int, IntrinsicFunction> NumCacheNodes { get; set; }

            /// <summary>
            /// Port
            /// The port number on which each of the cache nodes will accept connections.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredAvailabilityZone
            /// The Amazon EC2 Availability Zone in which the cache cluster is created.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredAvailabilityZone { get; set; }

            /// <summary>
            /// PreferredAvailabilityZones
            /// For Memcached cache clusters, the list of Availability Zones in which cache nodes are created. The
            /// number of Availability Zones listed must equal the number of cache nodes. For example, if you want
            /// to create three nodes in two different Availability Zones, you can specify [&quot;us-east-1a&quot;,
            /// &quot;us-east-1a&quot;, &quot;us-east-1b&quot;], which would create two nodes in us-east-1a and one node in us-east-1b.
            /// If you specify a subnet group and you&#39;re creating your cache cluster in a VPC, you must specify
            /// Availability Zones that are associated with the subnets in the subnet group that you&#39;ve chosen.
            /// If you want all the nodes in the same Availability Zone, use the PreferredAvailabilityZone property
            /// or repeat the Availability Zone multiple times in the list.
            /// Required: No
            /// Type: List of String values
            /// If you specify an Availability Zone that was previously specified in the template, such as in the
            /// PreferredAvailabilityZone property, the update requires some interruptions. Also, if the
            /// PreferredAvailabilityZones property was already specified and you&#39;re updating its values (regardless
            /// of whether you specify the same Availability Zones), the update requires some interruptions.
            /// All other updates require replacement.
            /// </summary>
			public Union<List<string>, IntrinsicFunction> PreferredAvailabilityZones { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// SnapshotArns
            /// The ARN of the snapshot file that you want to use to seed a new Redis cache cluster. If you manage a
            /// Redis instance outside of Amazon ElastiCache, you can create a new cache cluster in ElastiCache by
            /// using a snapshot file that is stored in an Amazon S3 bucket.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SnapshotArns { get; set; }

            /// <summary>
            /// SnapshotName
            /// The name of a snapshot from which to restore data into a new Redis cache cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotName { get; set; }

            /// <summary>
            /// SnapshotRetentionLimit
            /// For Redis cache clusters, the number of days for which ElastiCache retains automatic snapshots
            /// before deleting them. For example, if you set the value to 5, a snapshot that was taken today will
            /// be retained for 5 days before being deleted.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> SnapshotRetentionLimit { get; set; }

            /// <summary>
            /// SnapshotWindow
            /// For Redis cache clusters, the daily time range (in UTC) during which ElastiCache will begin taking a
            /// daily snapshot of your node group. For example, you can specify 05:00-09:00.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotWindow { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this cache cluster.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// A list of VPC security group IDs. If your cache cluster isn&#39;t in a VPC, specify the
            /// CacheSecurityGroupNames property instead.
            /// Note You must use the AWS::EC2::SecurityGroup resource instead of the
            /// AWS::ElastiCache::SecurityGroup resource in order to specify an ElastiCache security group that is
            /// in a VPC. In addition, if you use the default VPC for your AWS account, you must use the Fn::GetAtt
            /// function and the GroupId attribute to retrieve security group IDs (instead of the Ref function). To
            /// see a sample template, see the Template Snippet section.
            /// Required: Conditional: If your cache cluster is in a VPC, you must specify this property.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::CacheCluster";
        
        public CacheClusterProperties Properties { get; } = new CacheClusterProperties();
    }

	public static class CacheClusterAttributes
	{
        public static readonly ResourceAttribute<string> ConfigurationEndpoint_Address = new ResourceAttribute<string>("ConfigurationEndpoint", "Address");
        public static readonly ResourceAttribute<string> ConfigurationEndpoint_Port = new ResourceAttribute<string>("ConfigurationEndpoint", "Port");
        public static readonly ResourceAttribute<string> RedisEndpoint_Address = new ResourceAttribute<string>("RedisEndpoint", "Address");
        public static readonly ResourceAttribute<string> RedisEndpoint_Port = new ResourceAttribute<string>("RedisEndpoint", "Port");
	}
}
