using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig InstanceFleetProvisioningSpecifications
    /// Note The instance fleet configuration is available only in Amazon EMR versions 4. 8. 0 and later, excluding 5.
    /// 0. x versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html
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
