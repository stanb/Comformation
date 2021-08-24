using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotFleetRequestConfigData
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html
    /// </summary>
    public class SpotFleetRequestConfigData
    {

        /// <summary>
        /// AllocationStrategy
        /// Indicates how to allocate the target Spot Instance capacity across the Spot Instance pools specified
        /// by the Spot Fleet request.
        /// If the allocation strategy is lowestPrice, Spot Fleet launches instances from the Spot Instance
        /// pools with the lowest price. This is the default allocation strategy.
        /// If the allocation strategy is diversified, Spot Fleet launches instances from all the Spot Instance
        /// pools that you specify.
        /// If the allocation strategy is capacityOptimized (recommended), Spot Fleet launches instances from
        /// Spot Instance pools with optimal capacity for the number of instances that are launching. To give
        /// certain instance types a higher chance of launching first, use capacityOptimizedPrioritized. Set a
        /// priority for each instance type by using the Priority parameter for LaunchTemplateOverrides. You can
        /// assign the same priority to different LaunchTemplateOverrides. EC2 implements the priorities on a
        /// best-effort basis, but optimizes for capacity first. capacityOptimizedPrioritized is supported only
        /// if your Spot Fleet uses a launch template. Note that if the OnDemandAllocationStrategy is set to
        /// prioritized, the same priority is applied when fulfilling On-Demand capacity.
        /// Required: No
        /// Type: String
        /// Allowed values: capacityOptimized | capacityOptimizedPrioritized | diversified | lowestPrice
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// ExcessCapacityTerminationPolicy
        /// Indicates whether running Spot Instances should be terminated if you decrease the target capacity of
        /// the Spot Fleet request below the current size of the Spot Fleet.
        /// Required: No
        /// Type: String
        /// Allowed values: default | noTermination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcessCapacityTerminationPolicy")]
        public Union<string, IntrinsicFunction> ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// IamFleetRole
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that grants the
        /// Spot Fleet the permission to request, launch, terminate, and tag instances on your behalf. For more
        /// information, see Spot Fleet Prerequisites in the Amazon EC2 User Guide for Linux Instances. Spot
        /// Fleet can terminate Spot Instances on your behalf when you cancel its Spot Fleet request or when the
        /// Spot Fleet request expires, if you set TerminateInstancesWithExpiration.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IamFleetRole")]
        public Union<string, IntrinsicFunction> IamFleetRole { get; set; }

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
        /// AllocationStrategy is set to lowest-price. Spot Fleet selects the cheapest Spot pools and evenly
        /// allocates your target Spot capacity across the number of Spot pools that you specify.
        /// Note that Spot Fleet attempts to draw Spot Instances from the number of pools that you specify on a
        /// best effort basis. If a pool runs out of Spot capacity before fulfilling your target capacity, Spot
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

        /// <summary>
        /// LaunchSpecifications
        /// The launch specifications for the Spot Fleet request. If you specify LaunchSpecifications, you can&#39;t
        /// specify LaunchTemplateConfigs.
        /// Required: Conditional
        /// Type: List of SpotFleetLaunchSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchSpecifications")]
        public List<SpotFleetLaunchSpecification> LaunchSpecifications { get; set; }

        /// <summary>
        /// LaunchTemplateConfigs
        /// The launch template and overrides. If you specify LaunchTemplateConfigs, you can&#39;t specify
        /// LaunchSpecifications.
        /// Required: Conditional
        /// Type: List of LaunchTemplateConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateConfigs")]
        public List<LaunchTemplateConfig> LaunchTemplateConfigs { get; set; }

        /// <summary>
        /// LoadBalancersConfig
        /// One or more Classic Load Balancers and target groups to attach to the Spot Fleet request. Spot Fleet
        /// registers the running Spot Instances with the specified Classic Load Balancers and target groups.
        /// With Network Load Balancers, Spot Fleet cannot register instances that have the following instance
        /// types: C1, CC1, CC2, CG1, CG2, CR1, CS1, G1, G2, HI1, HS1, M1, M2, M3, and T1.
        /// Required: No
        /// Type: LoadBalancersConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LoadBalancersConfig")]
        public LoadBalancersConfig LoadBalancersConfig { get; set; }

        /// <summary>
        /// OnDemandAllocationStrategy
        /// The order of the launch template overrides to use in fulfilling On-Demand capacity. If you specify
        /// lowestPrice, Spot Fleet uses price to determine the order, launching the lowest price first. If you
        /// specify prioritized, Spot Fleet uses the priority that you assign to each Spot Fleet launch template
        /// override, launching the highest priority first. If you do not specify a value, Spot Fleet defaults
        /// to lowestPrice.
        /// Required: No
        /// Type: String
        /// Allowed values: lowestPrice | prioritized
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OnDemandAllocationStrategy")]
        public Union<string, IntrinsicFunction> OnDemandAllocationStrategy { get; set; }

        /// <summary>
        /// OnDemandMaxTotalPrice
        /// The maximum amount per hour for On-Demand Instances that you&#39;re willing to pay. You can use the
        /// onDemandMaxTotalPrice parameter, the spotMaxTotalPrice parameter, or both parameters to ensure that
        /// your fleet cost does not exceed your budget. If you set a maximum price per hour for the On-Demand
        /// Instances and Spot Instances in your request, Spot Fleet will launch instances until it reaches the
        /// maximum amount you&#39;re willing to pay. When the maximum amount you&#39;re willing to pay is reached, the
        /// fleet stops launching instances even if it hasn’t met the target capacity.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OnDemandMaxTotalPrice")]
        public Union<string, IntrinsicFunction> OnDemandMaxTotalPrice { get; set; }

        /// <summary>
        /// OnDemandTargetCapacity
        /// The number of On-Demand units to request. You can choose to set the target capacity in terms of
        /// instances or a performance characteristic that is important to your application workload, such as
        /// vCPUs, memory, or I/O. If the request type is maintain, you can specify a target capacity of 0 and
        /// add capacity later.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OnDemandTargetCapacity")]
        public Union<int, IntrinsicFunction> OnDemandTargetCapacity { get; set; }

        /// <summary>
        /// ReplaceUnhealthyInstances
        /// Indicates whether Spot Fleet should replace unhealthy instances.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReplaceUnhealthyInstances")]
        public Union<bool, IntrinsicFunction> ReplaceUnhealthyInstances { get; set; }

        /// <summary>
        /// SpotMaintenanceStrategies
        /// The strategies for managing your Spot Instances that are at an elevated risk of being interrupted.
        /// Required: No
        /// Type: SpotMaintenanceStrategies
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotMaintenanceStrategies")]
        public SpotMaintenanceStrategies SpotMaintenanceStrategies { get; set; }

        /// <summary>
        /// SpotMaxTotalPrice
        /// The maximum amount per hour for Spot Instances that you&#39;re willing to pay. You can use the
        /// spotdMaxTotalPrice parameter, the onDemandMaxTotalPrice parameter, or both parameters to ensure that
        /// your fleet cost does not exceed your budget. If you set a maximum price per hour for the On-Demand
        /// Instances and Spot Instances in your request, Spot Fleet will launch instances until it reaches the
        /// maximum amount you&#39;re willing to pay. When the maximum amount you&#39;re willing to pay is reached, the
        /// fleet stops launching instances even if it hasn’t met the target capacity.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotMaxTotalPrice")]
        public Union<string, IntrinsicFunction> SpotMaxTotalPrice { get; set; }

        /// <summary>
        /// SpotPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. The default is the
        /// On-Demand price.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SpotPrice")]
        public Union<string, IntrinsicFunction> SpotPrice { get; set; }

        /// <summary>
        /// TargetCapacity
        /// The number of units to request for the Spot Fleet. You can choose to set the target capacity in
        /// terms of instances or a performance characteristic that is important to your application workload,
        /// such as vCPUs, memory, or I/O. If the request type is maintain, you can specify a target capacity of
        /// 0 and add capacity later.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetCapacity")]
        public Union<int, IntrinsicFunction> TargetCapacity { get; set; }

        /// <summary>
        /// TerminateInstancesWithExpiration
        /// Indicates whether running Spot Instances are terminated when the Spot Fleet request expires.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TerminateInstancesWithExpiration")]
        public Union<bool, IntrinsicFunction> TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// Type
        /// The type of request. Indicates whether the Spot Fleet only requests the target capacity or also
        /// attempts to maintain it. When this value is request, the Spot Fleet only places the required
        /// requests. It does not attempt to replenish Spot Instances if capacity is diminished, nor does it
        /// submit requests in alternative Spot pools if capacity is not available. When this value is maintain,
        /// the Spot Fleet maintains the target capacity. The Spot Fleet places the required requests to meet
        /// capacity and automatically replenishes any interrupted instances. Default: maintain. instant is
        /// listed but is not used by Spot Fleet.
        /// Required: No
        /// Type: String
        /// Allowed values: instant | maintain | request
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ValidFrom
        /// The start date and time of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). By default, Amazon EC2
        /// starts fulfilling the request immediately.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ValidFrom")]
        public Union<string, IntrinsicFunction> ValidFrom { get; set; }

        /// <summary>
        /// ValidUntil
        /// The end date and time of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). After the end date and
        /// time, no new Spot Instance requests are placed or able to fulfill the request. If no value is
        /// specified, the Spot Fleet request remains until you cancel it.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ValidUntil")]
        public Union<string, IntrinsicFunction> ValidUntil { get; set; }

        /// <summary>
        /// Context
        /// Reserved.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Context")]
        public Union<string, IntrinsicFunction> Context { get; set; }

    }
}
