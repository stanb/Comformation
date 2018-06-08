using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig SpotProvisioningSpecification
    /// Use the SpotProvisioningSpecification property to specify the duration and timeout behavior for Spot Instances
    /// in the instance fleet for Amazon EMR. SpotProvisioningSpecification is the property type for the
    /// SpotSpecification subproperty of the Amazon EMR InstanceFleetConfig InstanceFleetProvisioningSpecifications
    /// property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html
    /// </summary>
    public class SpotProvisioningSpecification
    {

        /// <summary>
        /// BlockDurationMinutes
        /// The defined duration for Spot Instances (also known as Spot blocks) in minutes. For more
        /// information, see SpotProvisioningSpecification in the Amazon EMR API Reference.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDurationMinutes")]
        public Union<int, IntrinsicFunction> BlockDurationMinutes { get; set; }

        /// <summary>
        /// TimeoutAction
        /// The action to take when the capacity for the target Spot Instance, as specified in
        /// TargetSpotCapacity, has not been fulfilled before the time specified in TimeoutDurationMinutes has
        /// expired. For more information, see SpotProvisioningSpecification in the Amazon EMR API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutAction")]
        public Union<string, IntrinsicFunction> TimeoutAction { get; set; }

        /// <summary>
        /// TimeoutDurationMinutes
        /// The timeout period for spot provisioning, in minutes. For more information, see
        /// SpotProvisioningSpecification in the Amazon EMR API Reference.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutDurationMinutes")]
        public Union<int, IntrinsicFunction> TimeoutDurationMinutes { get; set; }

    }
}
