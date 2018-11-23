using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// Amazon EC2 EC2Fleet FleetLaunchTemplateOverridesRequest
    /// The FleetLaunchTemplateOverridesRequest property type specifies overrides for a launch template for an EC2
    /// Fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html
    /// </summary>
    public class FleetLaunchTemplateOverridesRequest
    {

        /// <summary>
        /// WeightedCapacity
        /// The number of units provided by the specified instance type.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<double, IntrinsicFunction> WeightedCapacity { get; set; }

        /// <summary>
        /// Priority
        /// The priority for the launch template override. If AllocationStrategy is set to prioritized, EC2
        /// Fleet uses priority to determine which launch template override to use first in fulfilling On-Demand
        /// capacity. The highest priority is launched first. Valid values are whole numbers starting at 0. The
        /// lower the number, the higher the priority. If no number is set, the launch template override has the
        /// lowest priority.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<double, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// AvailabilityZone
        /// The Availability Zone in which to launch the instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet in which to launch the instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// MaxPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxPrice")]
        public Union<string, IntrinsicFunction> MaxPrice { get; set; }

    }
}
