using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet SpotOptionsRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html
    /// </summary>
    public class SpotOptionsRequest
    {

        /// <summary>
        /// SingleAvailabilityZone
        /// Indicates that the fleet launches all Spot Instances into a single Availability Zone. Supported only
        /// for fleets of type instant.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SingleAvailabilityZone")]
        public Union<bool, IntrinsicFunction> SingleAvailabilityZone { get; set; }

        /// <summary>
        /// AllocationStrategy
        /// Indicates how to allocate the target Spot Instance capacity across the Spot Instance pools specified
        /// by the EC2 Fleet.
        /// If the allocation strategy is lowestPrice, EC2 Fleet launches instances from the Spot Instance pools
        /// with the lowest price. This is the default allocation strategy.
        /// If the allocation strategy is diversified, EC2 Fleet launches instances from all the Spot Instance
        /// pools that you specify.
        /// If the allocation strategy is capacityOptimized, EC2 Fleet launches instances from Spot Instance
        /// pools that are optimally chosen based on the available Spot Instance capacity.
        /// Allowed Values: lowestPrice | diversified | capacityOptimized | capacityOptimizedPrioritized
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// SingleInstanceType
        /// Indicates that the fleet uses a single instance type to launch all Spot Instances in the fleet.
        /// Supported only for fleets of type instant.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SingleInstanceType")]
        public Union<bool, IntrinsicFunction> SingleInstanceType { get; set; }

        /// <summary>
        /// MinTargetCapacity
        /// The minimum target capacity for Spot Instances in the fleet. If the minimum target capacity is not
        /// reached, the fleet launches no instances.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MinTargetCapacity")]
        public Union<int, IntrinsicFunction> MinTargetCapacity { get; set; }

        /// <summary>
        /// MaxTotalPrice
        /// The maximum amount per hour for Spot Instances that you&#39;re willing to pay.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxTotalPrice")]
        public Union<string, IntrinsicFunction> MaxTotalPrice { get; set; }

        /// <summary>
        /// InstanceInterruptionBehavior
        /// The behavior when a Spot Instance is interrupted. The default is terminate.
        /// Required: No
        /// Type: String
        /// Allowed values: hibernate | stop | terminate
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceInterruptionBehavior")]
        public Union<string, IntrinsicFunction> InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// InstancePoolsToUseCount
        /// The number of Spot pools across which to allocate your target Spot capacity. Valid only when Spot
        /// AllocationStrategy is set to lowest-price. EC2 Fleet selects the cheapest Spot pools and evenly
        /// allocates your target Spot capacity across the number of Spot pools that you specify.
        /// Note that EC2 Fleet attempts to draw Spot Instances from the number of pools that you specify on a
        /// best effort basis. If a pool runs out of Spot capacity before fulfilling your target capacity, EC2
        /// Fleet will continue to fulfill your request by drawing from the next cheapest pool. To ensure that
        /// your target capacity is met, you might receive Spot Instances from more than the number of pools
        /// that you specified. Similarly, if most of the pools have no Spot capacity, you might receive your
        /// full target capacity from fewer than the number of pools that you specified.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstancePoolsToUseCount")]
        public Union<int, IntrinsicFunction> InstancePoolsToUseCount { get; set; }

    }
}
