using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ReplicationSet
{
    /// <summary>
    /// AWS::SSMIncidents::ReplicationSet RegionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-regionconfiguration.html
    /// </summary>
    public class RegionConfiguration
    {

        /// <summary>
        /// SseKmsKeyId
        /// The KMS key ID to use to encrypt your replication set.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SseKmsKeyId")]
        public Union<string, IntrinsicFunction> SseKmsKeyId { get; set; }

    }
}
