using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotMaintenanceStrategies
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotmaintenancestrategies.html
    /// </summary>
    public class SpotMaintenanceStrategies
    {

        /// <summary>
        /// CapacityRebalance
        /// The strategy to use when Amazon EC2 emits a signal that your Spot Instance is at an elevated risk of
        /// being interrupted.
        /// Required: No
        /// Type: SpotCapacityRebalance
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public SpotCapacityRebalance CapacityRebalance { get; set; }

    }
}
