using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig InstanceFleetProvisioningSpecifications
    /// Use the InstanceFleetProvisioningSpecifications property type to create or modify the launch specification for
    /// Spot Instances in the fleet. This determines the defined duration and provisioning timeout behavior.
    /// InstanceFleetProvisioningSpecifications is the property type for the LaunchSpecifications property of the
    /// AWS::EMR::InstanceFleetConfig resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html
    /// </summary>
    public class InstanceFleetProvisioningSpecifications
    {

        /// <summary>
        /// SpotSpecification
        /// The launch specification for Spot Instances in the fleet. This determines the defined duration and
        /// provisioning timeout behavior.
        /// Required: Yes
        /// Type: Amazon EMR InstanceFleetConfig SpotProvisioningSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotSpecification")]
        public Union<SpotProvisioningSpecification, IntrinsicFunction> SpotSpecification { get; set; }

    }
}
