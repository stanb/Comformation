using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet OnDemandOptionsRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html
    /// </summary>
    public class OnDemandOptionsRequest
    {

        /// <summary>
        /// SingleAvailabilityZone
        /// Indicates that the fleet launches all On-Demand Instances into a single Availability Zone. Supported
        /// only for fleets of type instant.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SingleAvailabilityZone")]
        public Union<bool, IntrinsicFunction> SingleAvailabilityZone { get; set; }

        /// <summary>
        /// AllocationStrategy
        /// The order of the launch template overrides to use in fulfilling On-Demand capacity. If you specify
        /// lowest-price, EC2 Fleet uses price to determine the order, launching the lowest price first. If you
        /// specify prioritized, EC2 Fleet uses the priority that you assigned to each launch template override,
        /// launching the highest priority first. If you do not specify a value, EC2 Fleet defaults to
        /// lowest-price.
        /// Required: No
        /// Type: String
        /// Allowed values: lowest-price | prioritized
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// SingleInstanceType
        /// Indicates that the fleet uses a single instance type to launch all On-Demand Instances in the fleet.
        /// Supported only for fleets of type instant.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SingleInstanceType")]
        public Union<bool, IntrinsicFunction> SingleInstanceType { get; set; }

        /// <summary>
        /// MinTargetCapacity
        /// The minimum target capacity for On-Demand Instances in the fleet. If the minimum target capacity is
        /// not reached, the fleet launches no instances.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MinTargetCapacity")]
        public Union<int, IntrinsicFunction> MinTargetCapacity { get; set; }

        /// <summary>
        /// MaxTotalPrice
        /// The maximum amount per hour for On-Demand Instances that you&#39;re willing to pay.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxTotalPrice")]
        public Union<string, IntrinsicFunction> MaxTotalPrice { get; set; }

        /// <summary>
        /// CapacityReservationOptions
        /// The strategy for using unused Capacity Reservations for fulfilling On-Demand capacity. Supported
        /// only for fleets of type instant.
        /// Required: No
        /// Type: CapacityReservationOptionsRequest
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CapacityReservationOptions")]
        public CapacityReservationOptionsRequest CapacityReservationOptions { get; set; }

    }
}
