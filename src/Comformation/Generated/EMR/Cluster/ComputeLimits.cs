using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ComputeLimits
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html
    /// </summary>
    public class ComputeLimits
    {

        /// <summary>
        /// MaximumCapacityUnits
        /// The upper boundary of EC2 units. It is measured through vCPU cores or instances for instance groups
        /// and measured through units for instance fleets. Managed scaling activities are not allowed beyond
        /// this boundary. The limit only applies to the core and task nodes. The master node cannot be scaled
        /// after initial configuration.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumCapacityUnits")]
        public Union<int, IntrinsicFunction> MaximumCapacityUnits { get; set; }

        /// <summary>
        /// MaximumCoreCapacityUnits
        /// The upper boundary of EC2 units for core node type in a cluster. It is measured through vCPU cores
        /// or instances for instance groups and measured through units for instance fleets. The core units are
        /// not allowed to scale beyond this boundary. The parameter is used to split capacity allocation
        /// between core and task nodes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumCoreCapacityUnits")]
        public Union<int, IntrinsicFunction> MaximumCoreCapacityUnits { get; set; }

        /// <summary>
        /// MaximumOnDemandCapacityUnits
        /// The upper boundary of On-Demand EC2 units. It is measured through vCPU cores or instances for
        /// instance groups and measured through units for instance fleets. The On-Demand units are not allowed
        /// to scale beyond this boundary. The parameter is used to split capacity allocation between On-Demand
        /// and Spot Instances.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumOnDemandCapacityUnits")]
        public Union<int, IntrinsicFunction> MaximumOnDemandCapacityUnits { get; set; }

        /// <summary>
        /// MinimumCapacityUnits
        /// The lower boundary of EC2 units. It is measured through vCPU cores or instances for instance groups
        /// and measured through units for instance fleets. Managed scaling activities are not allowed beyond
        /// this boundary. The limit only applies to the core and task nodes. The master node cannot be scaled
        /// after initial configuration.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumCapacityUnits")]
        public Union<int, IntrinsicFunction> MinimumCapacityUnits { get; set; }

        /// <summary>
        /// UnitType
        /// The unit type used for specifying a managed scaling policy.
        /// Required: Yes
        /// Type: String
        /// Allowed values: InstanceFleetUnits | Instances | VCPU
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnitType")]
        public Union<string, IntrinsicFunction> UnitType { get; set; }

    }
}
