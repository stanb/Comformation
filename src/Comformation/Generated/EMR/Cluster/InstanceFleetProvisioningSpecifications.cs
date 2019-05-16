using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster InstanceFleetProvisioningSpecifications
    /// InstanceFleetProvisioningSpecification is a subproperty of InstanceFleetConfig.
    /// InstanceFleetProvisioningSpecification defines the launch specification for Spot instances in an instance
    /// fleet, which determines the defined duration and provisioning timeout behavior for Spot instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html
    /// </summary>
    public class InstanceFleetProvisioningSpecifications
    {

        /// <summary>
        /// SpotSpecification
        /// The launch specification for Spot instances in the fleet, which determines the defined duration and
        /// provisioning timeout behavior.
        /// Required: Yes
        /// Type: SpotProvisioningSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotSpecification")]
        public SpotProvisioningSpecification SpotSpecification { get; set; }

    }
}
