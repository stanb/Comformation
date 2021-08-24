using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.GlobalReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::GlobalReplicationGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html
    /// </summary>
    public class GlobalReplicationGroupResource : ResourceBase
    {
        public class GlobalReplicationGroupProperties
        {
            /// <summary>
            /// GlobalReplicationGroupIdSuffix
            /// The suffix name of a Global Datastore. The suffix guarantees uniqueness of the Global Datastore name
            /// across multiple regions.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalReplicationGroupIdSuffix { get; set; }

            /// <summary>
            /// AutomaticFailoverEnabled
            /// Specifies whether a read-only replica is automatically promoted to read/write primary if the
            /// existing primary fails.
            /// AutomaticFailoverEnabled must be enabled for Redis (cluster mode enabled) replication groups.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutomaticFailoverEnabled { get; set; }

            /// <summary>
            /// CacheNodeType
            /// The cache node type of the Global datastore
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CacheNodeType { get; set; }

            /// <summary>
            /// EngineVersion
            /// The Elasticache Redis engine version.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// CacheParameterGroupName
            /// The name of the cache parameter group to use with the Global datastore. It must be compatible with
            /// the major engine version used by the Global datastore.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CacheParameterGroupName { get; set; }

            /// <summary>
            /// GlobalNodeGroupCount
            /// The number of node groups that comprise the Global Datastore.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> GlobalNodeGroupCount { get; set; }

            /// <summary>
            /// GlobalReplicationGroupDescription
            /// The optional description of the Global datastore
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalReplicationGroupDescription { get; set; }

            /// <summary>
            /// Members
            /// The replication groups that comprise the Global datastore.
            /// Required: Yes
            /// Type: List of GlobalReplicationGroupMember
            /// Update requires: No interruption
            /// </summary>
            public List<GlobalReplicationGroupMember> Members { get; set; }

            /// <summary>
            /// RegionalConfigurations
            /// The Amazon Regions that comprise the Global Datastore.
            /// Required: No
            /// Type: List of RegionalConfiguration
            /// Update requires: No interruption
            /// </summary>
            public List<RegionalConfiguration> RegionalConfigurations { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::GlobalReplicationGroup";

        public GlobalReplicationGroupProperties Properties { get; } = new GlobalReplicationGroupProperties();

    }

    public static class GlobalReplicationGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GlobalReplicationGroupId = new ResourceAttribute<Union<string, IntrinsicFunction>>("GlobalReplicationGroupId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
