using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet CapacityReservationOptionsRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityreservationoptionsrequest.html
    /// </summary>
    public class CapacityReservationOptionsRequest
    {

        /// <summary>
        /// UsageStrategy
        /// Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity.
        /// If you specify use-capacity-reservations-first, the fleet uses unused Capacity Reservations to
        /// fulfill On-Demand capacity up to the target On-Demand capacity. If multiple instance pools have
        /// unused Capacity Reservations, the On-Demand allocation strategy (lowest-price or prioritized) is
        /// applied. If the number of unused Capacity Reservations is less than the On-Demand target capacity,
        /// the remaining On-Demand target capacity is launched according to the On-Demand allocation strategy
        /// (lowest-price or prioritized).
        /// If you do not specify a value, the fleet fulfils the On-Demand capacity according to the chosen
        /// On-Demand allocation strategy.
        /// Required: No
        /// Type: String
        /// Allowed values: use-capacity-reservations-first
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("UsageStrategy")]
        public Union<string, IntrinsicFunction> UsageStrategy { get; set; }

    }
}
