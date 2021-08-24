using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ReplicationSet
{
    /// <summary>
    /// AWS::SSMIncidents::ReplicationSet ReplicationRegion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-replicationset-replicationregion.html
    /// </summary>
    public class ReplicationRegion
    {

        /// <summary>
        /// RegionName
        /// Specifies the region name to add to the replication set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegionName")]
        public Union<string, IntrinsicFunction> RegionName { get; set; }

        /// <summary>
        /// RegionConfiguration
        /// Specifies the Region configuration.
        /// Required: No
        /// Type: RegionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegionConfiguration")]
        public RegionConfiguration RegionConfiguration { get; set; }

    }
}
