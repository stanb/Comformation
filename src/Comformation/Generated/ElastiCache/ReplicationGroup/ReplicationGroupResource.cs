using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ReplicationGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html
    /// </summary>
    public class ReplicationGroupResource : ResourceBase
    {
        public class ReplicationGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-atrestencryptionenabled
            /// </summary>
			public Union<bool?, IntrinsicFunction> AtRestEncryptionEnabled { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-authtoken
            /// </summary>
			public Union<string, IntrinsicFunction> AuthToken { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-autominorversionupgrade
            /// </summary>
			public Union<bool?, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-automaticfailoverenabled
            /// </summary>
			public Union<bool?, IntrinsicFunction> AutomaticFailoverEnabled { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachenodetype
            /// </summary>
			public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cacheparametergroupname
            /// </summary>
			public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachesecuritygroupnames
            /// </summary>
			public Union<List<string>, IntrinsicFunction> CacheSecurityGroupNames { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachesubnetgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> CacheSubnetGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engine
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engineversion
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-nodegroupconfiguration
            /// </summary>
			public Union<List<NodeGroupConfiguration>, IntrinsicFunction> NodeGroupConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-notificationtopicarn
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numcacheclusters
            /// </summary>
			public Union<int?, IntrinsicFunction> NumCacheClusters { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numnodegroups
            /// </summary>
			public Union<int?, IntrinsicFunction> NumNodeGroups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-port
            /// </summary>
			public Union<int?, IntrinsicFunction> Port { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredcacheclusterazs
            /// </summary>
			public Union<List<string>, IntrinsicFunction> PreferredCacheClusterAZs { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredmaintenancewindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-primaryclusterid
            /// </summary>
			public Union<string, IntrinsicFunction> PrimaryClusterId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicaspernodegroup
            /// </summary>
			public Union<int?, IntrinsicFunction> ReplicasPerNodeGroup { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupdescription
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupDescription { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupid
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationGroupId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-securitygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotarns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SnapshotArns { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotname
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotretentionlimit
            /// </summary>
			public Union<int?, IntrinsicFunction> SnapshotRetentionLimit { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotwindow
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotWindow { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshottingclusterid
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshottingClusterId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-transitencryptionenabled
            /// </summary>
			public Union<bool?, IntrinsicFunction> TransitEncryptionEnabled { get; set; }

        }
    
        public string Type { get; } = "AWS::ElastiCache::ReplicationGroup";
        
        public ReplicationGroupProperties Properties { get; } = new ReplicationGroupProperties();
    }

	public static class ReplicationGroupAttributes
	{
        public static readonly ResourceAttribute<string> ConfigurationEndPoint_Address = new ResourceAttribute<string>("ConfigurationEndPoint", "Address");
        public static readonly ResourceAttribute<string> ConfigurationEndPoint_Port = new ResourceAttribute<string>("ConfigurationEndPoint", "Port");
        public static readonly ResourceAttribute<string> PrimaryEndPoint_Address = new ResourceAttribute<string>("PrimaryEndPoint", "Address");
        public static readonly ResourceAttribute<string> PrimaryEndPoint_Port = new ResourceAttribute<string>("PrimaryEndPoint", "Port");
        public static readonly ResourceAttribute<string> ReadEndPoint_Addresses = new ResourceAttribute<string>("ReadEndPoint", "Addresses");
        public static readonly ResourceAttribute<List<string>> ReadEndPoint_Addresses_List = new ResourceAttribute<List<string>>("ReadEndPoint", "Addresses", "List");
        public static readonly ResourceAttribute<string> ReadEndPoint_Ports = new ResourceAttribute<string>("ReadEndPoint", "Ports");
        public static readonly ResourceAttribute<List<string>> ReadEndPoint_Ports_List = new ResourceAttribute<List<string>>("ReadEndPoint", "Ports", "List");
	}
}
