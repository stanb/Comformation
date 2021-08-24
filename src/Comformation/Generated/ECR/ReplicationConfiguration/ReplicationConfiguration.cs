using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.ReplicationConfiguration
{
    /// <summary>
    /// AWS::ECR::ReplicationConfiguration ReplicationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationconfiguration.html
    /// </summary>
    public class ReplicationConfiguration
    {

        /// <summary>
        /// Rules
        /// An array of objects representing the replication rules for a replication configuration. A
        /// replication configuration may contain only one replication rule but the rule may contain one or more
        /// replication destinations.
        /// Required: Yes
        /// Type: List of ReplicationRule
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<ReplicationRule> Rules { get; set; }

    }
}
