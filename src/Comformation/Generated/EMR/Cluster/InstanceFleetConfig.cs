using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster InstanceFleetConfig
    /// The InstanceFleetConfig property type specifies a Spot instance fleet configuration for the cluster. For more
    /// information, see Configure Instance Fleets in the Amazon EMR Management Guide. InstanceFleetConfig is the
    /// property type for the CoreInstanceFleet and MasterInstanceFleet subproperties of the Amazon EMR Cluster
    /// JobFlowInstancesConfig property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html
    /// </summary>
    public class InstanceFleetConfig
    {

        /// <summary>
        /// InstanceTypeConfigs
        /// The instance type configurations that define the EC2 instances in the instance fleet. Duplicates not
        /// allowed.
        /// Required: No
        /// Type: List of Amazon EMR Cluster InstanceTypeConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceTypeConfigs")]
        public Union<List<InstanceTypeConfig>, IntrinsicFunction> InstanceTypeConfigs { get; set; }

        /// <summary>
        /// LaunchSpecifications
        /// The launch specification for the instance fleet.
        /// Required: No
        /// Type: Amazon EMR Cluster InstanceFleetProvisioningSpecifications
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchSpecifications")]
        public Union<InstanceFleetProvisioningSpecifications, IntrinsicFunction> LaunchSpecifications { get; set; }

        /// <summary>
        /// Name
        /// The friendly name of the instance fleet. For constraints, see InstanceFleetConfig in the Amazon EMR
        /// API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// TargetOnDemandCapacity
        /// The target capacity of On-Demand units for the instance fleet, which determines how many On-Demand
        /// instances to provision. For more information, see InstanceFleetConfig in the Amazon EMR API
        /// Reference.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetOnDemandCapacity")]
        public Union<int, IntrinsicFunction> TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// TargetSpotCapacity
        /// The target capacity of Spot units for the instance fleet, which determines how many Spot instances
        /// to provision. For more information, see InstanceFleetConfig in the Amazon EMR API Reference.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetSpotCapacity")]
        public Union<int, IntrinsicFunction> TargetSpotCapacity { get; set; }

    }
}
