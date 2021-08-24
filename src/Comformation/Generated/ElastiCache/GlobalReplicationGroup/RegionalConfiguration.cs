using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.GlobalReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::GlobalReplicationGroup RegionalConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html
    /// </summary>
    public class RegionalConfiguration
    {

        /// <summary>
        /// ReplicationGroupId
        /// The name of the secondary cluster
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicationGroupId")]
        public Union<string, IntrinsicFunction> ReplicationGroupId { get; set; }

        /// <summary>
        /// ReplicationGroupRegion
        /// The Amazon region where the cluster is stored
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicationGroupRegion")]
        public Union<string, IntrinsicFunction> ReplicationGroupRegion { get; set; }

        /// <summary>
        /// ReshardingConfigurations
        /// A list of PreferredAvailabilityZones objects that specifies the configuration of a node group in the
        /// resharded cluster.
        /// Required: No
        /// Type: List of ReshardingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReshardingConfigurations")]
        public List<ReshardingConfiguration> ReshardingConfigurations { get; set; }

    }
}
