using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet SpotOptionsRequest
    /// Specifies the configuration of Spot Instances for an EC2 Fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html
    /// </summary>
    public class SpotOptionsRequest
    {

        /// <summary>
        /// AllocationStrategy
        /// Indicates how to allocate the target capacity across the Spot pools specified by the Spot Fleet
        /// request. The default is lowestPrice.
        /// Required: No
        /// Type: String
        /// Allowed Values: diversified | lowest-price
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// InstanceInterruptionBehavior
        /// The behavior when a Spot Instance is interrupted. The default is terminate.
        /// Required: No
        /// Type: String
        /// Allowed Values: hibernate | stop | terminate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceInterruptionBehavior")]
        public Union<string, IntrinsicFunction> InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// InstancePoolsToUseCount
        /// The number of Spot pools across which to allocate your target Spot capacity. Valid only when Spot
        /// AllocationStrategy is set to lowest-price. EC2 Fleet selects the cheapest Spot pools and evenly
        /// allocates your target Spot capacity across the number of Spot pools that you specify.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancePoolsToUseCount")]
        public Union<int, IntrinsicFunction> InstancePoolsToUseCount { get; set; }

    }
}
