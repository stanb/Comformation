using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster SpotProvisioningSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html
    /// </summary>
    public class SpotProvisioningSpecification
    {

        /// <summary>
        /// AllocationStrategy
        /// Specifies the strategy to use in launching Spot Instance fleets. Currently, the only option is
        /// capacity-optimized (the default), which launches instances from Spot Instance pools with optimal
        /// capacity for the number of instances that are launching.
        /// Required: No
        /// Type: String
        /// Allowed values: capacity-optimized
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

        /// <summary>
        /// BlockDurationMinutes
        /// The defined duration for Spot Instances (also known as Spot blocks) in minutes. When specified, the
        /// Spot Instance does not terminate before the defined duration expires, and defined duration pricing
        /// for Spot instances applies. Valid values are 60, 120, 180, 240, 300, or 360. The duration period
        /// starts as soon as a Spot Instance receives its instance ID. At the end of the duration, Amazon EC2
        /// marks the Spot Instance for termination and provides a Spot Instance termination notice, which gives
        /// the instance a two-minute warning before it terminates.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDurationMinutes")]
        public Union<int, IntrinsicFunction> BlockDurationMinutes { get; set; }

        /// <summary>
        /// TimeoutAction
        /// The action to take when TargetSpotCapacity has not been fulfilled when the TimeoutDurationMinutes
        /// has expired; that is, when all Spot Instances could not be provisioned within the Spot provisioning
        /// timeout. Valid values are TERMINATE_CLUSTER and SWITCH_TO_ON_DEMAND. SWITCH_TO_ON_DEMAND specifies
        /// that if no Spot Instances are available, On-Demand Instances should be provisioned to fulfill any
        /// remaining Spot capacity.
        /// Required: Yes
        /// Type: String
        /// Allowed values: SWITCH_TO_ON_DEMAND | TERMINATE_CLUSTER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutAction")]
        public Union<string, IntrinsicFunction> TimeoutAction { get; set; }

        /// <summary>
        /// TimeoutDurationMinutes
        /// The spot provisioning timeout period in minutes. If Spot Instances are not provisioned within this
        /// time period, the TimeOutAction is taken. Minimum value is 5 and maximum value is 1440. The timeout
        /// applies only during initial provisioning, when the cluster is first created.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutDurationMinutes")]
        public Union<int, IntrinsicFunction> TimeoutDurationMinutes { get; set; }

    }
}
