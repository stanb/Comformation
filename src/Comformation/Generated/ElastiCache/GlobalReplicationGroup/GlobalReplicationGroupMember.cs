using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.GlobalReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::GlobalReplicationGroup GlobalReplicationGroupMember
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html
    /// </summary>
    public class GlobalReplicationGroupMember
    {

        /// <summary>
        /// ReplicationGroupId
        /// The replication group id of the Global datastore member.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicationGroupId")]
        public Union<string, IntrinsicFunction> ReplicationGroupId { get; set; }

        /// <summary>
        /// ReplicationGroupRegion
        /// The Amazon region of the Global datastore member.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicationGroupRegion")]
        public Union<string, IntrinsicFunction> ReplicationGroupRegion { get; set; }

        /// <summary>
        /// Role
        /// Indicates the role of the replication group, primary or secondary.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Role")]
        public Union<string, IntrinsicFunction> Role { get; set; }

    }
}
