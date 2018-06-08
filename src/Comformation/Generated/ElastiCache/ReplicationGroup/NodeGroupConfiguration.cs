using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ReplicationGroup
{
    /// <summary>
    /// Amazon ElastiCache ReplicationGroup NodeGroupConfiguration
    /// NodeGroupConfiguration is a property of the AWS::ElastiCache::ReplicationGroup resource that configures an
    /// Amazon ElastiCache (ElastiCache) Redis cluster node group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html
    /// </summary>
    public class NodeGroupConfiguration
    {

        /// <summary>
        /// PrimaryAvailabilityZone
        /// The Availability Zone where ElastiCache launches the node group's primary node.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PrimaryAvailabilityZone")]
        public Union<string, IntrinsicFunction> PrimaryAvailabilityZone { get; set; }

        /// <summary>
        /// ReplicaAvailabilityZones
        /// A list of Availability Zones where ElastiCache launches the read replicas. The number of
        /// Availability Zones must match the value of the ReplicaCount property or, if you don't specify the
        /// ReplicaCount property, the replication group's ReplicasPerNodeGroup property.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("ReplicaAvailabilityZones")]
        public Union<List<string>, IntrinsicFunction> ReplicaAvailabilityZones { get; set; }

        /// <summary>
        /// ReplicaCount
        /// The number of read replica nodes in the node group.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ReplicaCount")]
        public Union<int, IntrinsicFunction> ReplicaCount { get; set; }

        /// <summary>
        /// Slots
        /// A string of comma-separated values where the first set of values are the slot numbers (zero based),
        /// and the second set of values are the keyspaces for each slot. The following example specifies three
        /// slots (numbered 0, 1, and 2): 0,1,2,0-4999,5000-9999,10000-16,383.
        /// If you don't specify a value, ElastiCache allocates keys equally among each slot.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Slots")]
        public Union<string, IntrinsicFunction> Slots { get; set; }

    }
}
