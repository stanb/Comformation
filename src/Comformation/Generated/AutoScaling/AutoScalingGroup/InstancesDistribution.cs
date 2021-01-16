using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup InstancesDistribution
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html
    /// </summary>
    public class InstancesDistribution
    {

        /// <summary>
        /// OnDemandAllocationStrategy
        /// Indicates how to allocate instance types to fulfill On-Demand capacity. The only valid value is
        /// prioritized, which is also the default value. This strategy uses the order of instance type in the
        /// overrides to define the launch priority of each instance type. The first instance type in the array
        /// is prioritized higher than the last. If all your On-Demand capacity cannot be fulfilled using your
        /// highest priority instance, then the Auto Scaling groups launches the remaining capacity using the
        /// second priority instance type, and so on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnDemandAllocationStrategy")]
        public Union<string, IntrinsicFunction> OnDemandAllocationStrategy { get; set; }

        /// <summary>
        /// OnDemandBaseCapacity
        /// The minimum amount of the Auto Scaling group&#39;s capacity that must be fulfilled by On-Demand
        /// Instances. This base portion is provisioned first as your group scales. Defaults to 0 if not
        /// specified. If you specify weights for the instance types in the overrides, set the value of
        /// OnDemandBaseCapacity in terms of the number of capacity units, and not the number of instances.
        /// Note An update to this setting means a gradual replacement of instances to adjust the current
        /// On-Demand Instance levels. When replacing instances, Amazon EC2 Auto Scaling launches new instances
        /// before terminating the old ones.
        /// Required: No
        /// Type: Integer
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("OnDemandBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// OnDemandPercentageAboveBaseCapacity
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional capacity
        /// beyond OnDemandBaseCapacity. Expressed as a number (for example, 20 specifies 20% On-Demand
        /// Instances, 80% Spot Instances). Defaults to 100 if not specified. If set to 100, only On-Demand
        /// Instances are provisioned.
        /// Note An update to this setting means a gradual replacement of instances to adjust the current
        /// On-Demand and Spot Instance levels for your additional capacity above the base capacity. When
        /// replacing instances, Amazon EC2 Auto Scaling launches new instances before terminating the old ones.
        /// Required: No
        /// Type: Integer
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("OnDemandPercentageAboveBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandPercentageAboveBaseCapacity { get; set; }

        /// <summary>
        /// SpotAllocationStrategy
        /// Indicates how to allocate Spot capacity across Spot Instances pools. If the allocation strategy is
        /// capacity-optimized (recommended), the Auto Scaling group launches instances using Spot pools that
        /// are optimally chosen based on the available Spot capacity. If the allocation strategy is
        /// lowest-price, the Auto Scaling group launches instances using the Spot pools with the lowest price,
        /// and evenly allocates your instances across the number of Spot pools that you specify. Defaults to
        /// lowest-price if not specified.
        /// Valid values: lowest-price | capacity-optimized
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotAllocationStrategy")]
        public Union<string, IntrinsicFunction> SpotAllocationStrategy { get; set; }

        /// <summary>
        /// SpotInstancePools
        /// The number of Spot Instance pools to use to allocate your Spot capacity. The Spot pools are
        /// determined from the different instance types in the overrides. Valid only when the Spot allocation
        /// strategy is lowest-price. Value must be in the range of 1 to 20. Defaults to 2 if not specified.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotInstancePools")]
        public Union<int, IntrinsicFunction> SpotInstancePools { get; set; }

        /// <summary>
        /// SpotMaxPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. If you leave the
        /// value at its default (empty), Amazon EC2 Auto Scaling uses the On-Demand price as the maximum Spot
        /// price. To remove a value that you previously set, include the property but specify an empty string
        /// (&quot;&quot;) for the value.
        /// Important If your maximum price is lower than the Spot price for the instance types that you
        /// selected, your Spot Instances are not launched.
        /// Valid Range: Minimum value of 0. 001
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotMaxPrice")]
        public Union<string, IntrinsicFunction> SpotMaxPrice { get; set; }

    }
}
