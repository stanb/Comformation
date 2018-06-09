using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster InstanceFleetProvisioningSpecifications
    /// The InstanceFleetProvisioningSpecifications property specifies the launch specification for Spot instances in
    /// the fleet, which determines the defined duration and provisioning timeout behavior.
    /// InstanceFleetProvisioningSpecifications is the property type for the LaunchSpecifications property of the
    /// Amazon EMR Cluster InstanceFleetConfig property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html
    /// </summary>
    public class InstanceFleetProvisioningSpecifications
    {

        /// <summary>
        /// SpotSpecification
        /// The launch specification for Spot instances in the fleet, which determines the defined duration and
        /// provisioning timeout behavior.
        /// Required: Yes
        /// Type: Amazon EMR Cluster SpotProvisioningSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotSpecification")]
        public Union<SpotProvisioningSpecification, IntrinsicFunction> SpotSpecification { get; set; }

    }
}
