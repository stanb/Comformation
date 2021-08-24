using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.ReplicationConfiguration
{
    /// <summary>
    /// AWS::ECR::ReplicationConfiguration ReplicationDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-replicationconfiguration-replicationdestination.html
    /// </summary>
    public class ReplicationDestination
    {

        /// <summary>
        /// Region
        /// A Region to replicate to.
        /// Required: Yes
        /// Type: String
        /// Minimum: 2
        /// Maximum: 25
        /// Pattern: [0-9a-z-]{2,25}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// RegistryId
        /// The account ID of the destination registry to replicate to.
        /// Required: Yes
        /// Type: String
        /// Pattern: [0-9]{12}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegistryId")]
        public Union<string, IntrinsicFunction> RegistryId { get; set; }

    }
}
