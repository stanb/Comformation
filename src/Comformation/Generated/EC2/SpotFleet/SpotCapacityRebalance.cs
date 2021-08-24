using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotCapacityRebalance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotcapacityrebalance.html
    /// </summary>
    public class SpotCapacityRebalance
    {

        /// <summary>
        /// ReplacementStrategy
        /// The replacement strategy to use. Only available for fleets of type maintain. You must specify a
        /// value, otherwise you get an error.
        /// To allow Spot Fleet to launch a replacement Spot Instance when an instance rebalance notification is
        /// emitted for a Spot Instance in the fleet, specify launch.
        /// Note When a replacement instance is launched, the instance marked for rebalance is not automatically
        /// terminated. You can terminate it, or you can leave it running. You are charged for all instances
        /// while they are running.
        /// Required: No
        /// Type: String
        /// Allowed values: launch
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReplacementStrategy")]
        public Union<string, IntrinsicFunction> ReplacementStrategy { get; set; }

    }
}
