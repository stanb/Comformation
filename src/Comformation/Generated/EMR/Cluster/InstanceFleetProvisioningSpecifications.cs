using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster InstanceFleetProvisioningSpecifications
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html
    /// </summary>
    public class InstanceFleetProvisioningSpecifications
    {

        /// <summary>
        /// OnDemandSpecification
        /// The launch specification for On-Demand Instances in the instance fleet, which determines the
        /// allocation strategy.
        /// Note The instance fleet configuration is available only in Amazon EMR versions 4. 8. 0 and later,
        /// excluding 5. 0. x versions. On-Demand Instances allocation strategy is available in Amazon EMR
        /// version 5. 12. 1 and later.
        /// Required: No
        /// Type: OnDemandProvisioningSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnDemandSpecification")]
        public OnDemandProvisioningSpecification OnDemandSpecification { get; set; }

        /// <summary>
        /// SpotSpecification
        /// The launch specification for Spot Instances in the fleet, which determines the defined duration,
        /// provisioning timeout behavior, and allocation strategy.
        /// Required: No
        /// Type: SpotProvisioningSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotSpecification")]
        public SpotProvisioningSpecification SpotSpecification { get; set; }

    }
}
