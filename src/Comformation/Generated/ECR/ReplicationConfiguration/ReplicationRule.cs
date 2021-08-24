using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.ReplicationConfiguration
{
    /// <summary>
    /// AWS::ECR::ReplicationConfiguration ReplicationRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationrule.html
    /// </summary>
    public class ReplicationRule
    {

        /// <summary>
        /// Destinations
        /// An array of objects representing the details of a replication destination.
        /// Required: Yes
        /// Type: List of ReplicationDestination
        /// Maximum: 25
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destinations")]
        public List<ReplicationDestination> Destinations { get; set; }

    }
}
