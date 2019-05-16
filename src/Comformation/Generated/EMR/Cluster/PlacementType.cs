using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster PlacementType
    /// PlacementType is a property of the AWS::EMR::Cluster resource. PlacementType determines the Amazon EC2
    /// Availability Zone configuration of the cluster (job flow).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-placementtype.html
    /// </summary>
    public class PlacementType
    {

        /// <summary>
        /// AvailabilityZone
        /// The Amazon EC2 Availability Zone for the cluster. AvailabilityZone is used for uniform instance
        /// groups, while AvailabilityZones (plural) is used for instance fleets.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

    }
}
