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
        /// NodeGroupId
        /// Either the ElastiCache for Redis supplied 4-digit id or a user supplied id for the node group these
        /// configuration values apply to.
        /// Length Constraints: Minimum length of 1. Maximum length of 4.
        /// Pattern: \d+
        /// Required: No
        /// Type: String
        /// Update requires: Some interruptions. Update requires no interruption if the resource contains an
        /// UseOnlineResharding update policy set to true. Update requires replacement if the resource does not
        /// contain an UseOnlineResharding update policy, or the policy is set to false. For more information,
        /// see UseOnlineResharding Policy.
        /// </summary>
        [JsonProperty("NodeGroupId")]
        public Union<string, IntrinsicFunction> NodeGroupId { get; set; }

        /// <summary>
        /// PrimaryAvailabilityZone
        /// The Availability Zone where ElastiCache launches the node group&#39;s primary node.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PrimaryAvailabilityZone")]
        public Union<string, IntrinsicFunction> PrimaryAvailabilityZone { get; set; }

        /// <summary>
        /// ReplicaAvailabilityZones
        /// A list of Availability Zones where ElastiCache launches the read replicas. The number of
        /// Availability Zones must match the value of the ReplicaCount property or, if you don&#39;t specify the
        /// ReplicaCount property, the replication group&#39;s ReplicasPerNodeGroup property.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReplicaAvailabilityZones")]
        public List<Union<string, IntrinsicFunction>> ReplicaAvailabilityZones { get; set; }

        /// <summary>
        /// ReplicaCount
        /// The number of read replica nodes in the node group.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReplicaCount")]
        public Union<int, IntrinsicFunction> ReplicaCount { get; set; }

        /// <summary>
        /// Slots
        /// A string of comma-separated values where the first set of values are the slot numbers (zero based),
        /// and the second set of values are the keyspaces for each slot. The following example specifies three
        /// slots (numbered 0, 1, and 2): 0,1,2,0-4999,5000-9999,10000-16,383.
        /// If you don&#39;t specify a value, ElastiCache allocates keys equally among each slot.
        /// When you use an UseOnlineResharding update policy to update the number of node groups without
        /// interruption, ElastiCache evenly distributes the keyspaces between the specified number of slots.
        /// This cannot be updated later. Therefore, after updating the number of node groups in this way, you
        /// should remove the value specified for the Slots property of each NodeGroupConfiguration from the
        /// stack template, as it no longer reflects the actual values in each node group. For more information,
        /// see UseOnlineResharding Policy.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Slots")]
        public Union<string, IntrinsicFunction> Slots { get; set; }

    }
}
