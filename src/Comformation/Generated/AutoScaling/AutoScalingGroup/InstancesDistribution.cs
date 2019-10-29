using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup InstancesDistribution
    /// InstancesDistribution is a subproperty of MixedInstancesPolicy that describes an instances distribution for an
    /// Auto Scaling group. The instances distribution specifies the distribution of On-Demand Instances and Spot
    /// Instances, the maximum price to pay for Spot Instances, and how the Auto Scaling group allocates instance
    /// types to fulfill On-Demand and Spot capacity.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html
    /// </summary>
    public class InstancesDistribution
    {

        /// <summary>
        /// OnDemandAllocationStrategy
        /// Indicates how to allocate instance types to fulfill On-Demand capacity.
        /// The only valid value is prioritized, which is also the default value. This strategy uses the order
        /// of instance type overrides for LaunchTemplate to define the launch priority of each instance type.
        /// The first instance type in the array is prioritized higher than the last. If all your On-Demand
        /// capacity cannot be fulfilled using your highest priority instance, then the Auto Scaling groups
        /// launches the remaining capacity using the second priority instance type, and so on.
        /// Required: No
        /// Type: String
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnDemandAllocationStrategy")]
        public Union<string, IntrinsicFunction> OnDemandAllocationStrategy { get; set; }

        /// <summary>
        /// OnDemandBaseCapacity
        /// The minimum amount of the Auto Scaling group&#39;s capacity that must be fulfilled by On-Demand
        /// Instances. This base portion is provisioned first as your group scales.
        /// The default value is 0. If you leave this property set to 0, On-Demand Instances are launched as a
        /// percentage of the Auto Scaling group&#39;s desired capacity, per the OnDemandPercentageAboveBaseCapacity
        /// setting.
        /// Note An update to this property means a gradual replacement of instances to maintain the specified
        /// number of On-Demand Instances for your base capacity. When replacing instances, Amazon EC2 Auto
        /// Scaling launches new instances before terminating the old ones.
        /// Required: No
        /// Type: Integer
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("OnDemandBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// OnDemandPercentageAboveBaseCapacity
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional capacity
        /// beyond OnDemandBaseCapacity.
        /// The range is 0–100. The default value is 100. If you leave this property set to 100, the percentages
        /// are 100% for On-Demand Instances and 0% for Spot Instances.
        /// Note An update to this property means a gradual replacement of instances to maintain the percentage
        /// of On-Demand Instances for your additional capacity above the base capacity. When replacing
        /// instances, Amazon EC2 Auto Scaling launches new instances before terminating the old ones.
        /// Required: No
        /// Type: Integer
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("OnDemandPercentageAboveBaseCapacity")]
        public Union<int, IntrinsicFunction> OnDemandPercentageAboveBaseCapacity { get; set; }

        /// <summary>
        /// SpotAllocationStrategy
        /// Indicates how to allocate Spot capacity across Spot pools.
        /// If the allocation strategy is lowest-price, the Auto Scaling group launches instances using the Spot
        /// pools with the lowest price, and evenly allocates your instances across the number of Spot pools
        /// that you specify. If the allocation strategy is capacity-optimized, the Auto Scaling group launches
        /// instances using Spot pools that are optimally chosen based on the available Spot capacity.
        /// The default is lowest-price.
        /// Valid values: lowest-price | capacity-optimized
        /// Required: No
        /// Type: String
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotAllocationStrategy")]
        public Union<string, IntrinsicFunction> SpotAllocationStrategy { get; set; }

        /// <summary>
        /// SpotInstancePools
        /// The number of Spot pools to use to allocate your Spot capacity. The Spot pools are determined from
        /// the different instance types in the Overrides array of LaunchTemplate. The range is 1–20. The
        /// default value is 2.
        /// Valid only when the Spot allocation strategy is lowest-price.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotInstancePools")]
        public Union<int, IntrinsicFunction> SpotInstancePools { get; set; }

        /// <summary>
        /// SpotMaxPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. If you leave the
        /// value of this property blank (which is the default), the maximum Spot price is set at the On-Demand
        /// price.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotMaxPrice")]
        public Union<string, IntrinsicFunction> SpotMaxPrice { get; set; }

    }
}
