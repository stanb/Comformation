using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.GlobalReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::GlobalReplicationGroup ReshardingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-reshardingconfiguration.html
    /// </summary>
    public class ReshardingConfiguration
    {

        /// <summary>
        /// NodeGroupId
        /// Either the ElastiCache for Redis supplied 4-digit id or a user supplied id for the node group these
        /// configuration values apply to.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 4
        /// Pattern: \d+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NodeGroupId")]
        public Union<string, IntrinsicFunction> NodeGroupId { get; set; }

        /// <summary>
        /// PreferredAvailabilityZones
        /// A list of preferred availability zones for the nodes in this cluster.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreferredAvailabilityZones")]
        public List<Union<string, IntrinsicFunction>> PreferredAvailabilityZones { get; set; }

    }
}
