using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster InstanceFleetConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html
    /// </summary>
    public class InstanceFleetConfig
    {

        /// <summary>
        /// InstanceTypeConfigs
        /// The instance type configurations that define the EC2 instances in the instance fleet.
        /// Required: No
        /// Type: List of InstanceTypeConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceTypeConfigs")]
        public List<InstanceTypeConfig> InstanceTypeConfigs { get; set; }

        /// <summary>
        /// LaunchSpecifications
        /// The launch specification for the instance fleet.
        /// Required: No
        /// Type: InstanceFleetProvisioningSpecifications
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchSpecifications")]
        public InstanceFleetProvisioningSpecifications LaunchSpecifications { get; set; }

        /// <summary>
        /// Name
        /// The friendly name of the instance fleet.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// TargetOnDemandCapacity
        /// The target capacity of On-Demand units for the instance fleet, which determines how many On-Demand
        /// instances to provision. When the instance fleet launches, Amazon EMR tries to provision On-Demand
        /// instances as specified by InstanceTypeConfig. Each instance configuration has a specified
        /// WeightedCapacity. When an On-Demand instance is provisioned, the WeightedCapacity units count toward
        /// the target capacity. Amazon EMR provisions instances until the target capacity is totally fulfilled,
        /// even if this results in an overage. For example, if there are 2 units remaining to fulfill capacity,
        /// and Amazon EMR can only provision an instance with a WeightedCapacity of 5 units, the instance is
        /// provisioned, and the target capacity is exceeded by 3 units.
        /// Note If not specified or set to 0, only Spot instances are provisioned for the instance fleet using
        /// TargetSpotCapacity. At least one of TargetSpotCapacity and TargetOnDemandCapacity should be greater
        /// than 0. For a master instance fleet, only one of TargetSpotCapacity and TargetOnDemandCapacity can
        /// be specified, and its value must be 1.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetOnDemandCapacity")]
        public Union<int, IntrinsicFunction> TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// TargetSpotCapacity
        /// The target capacity of Spot units for the instance fleet, which determines how many Spot instances
        /// to provision. When the instance fleet launches, Amazon EMR tries to provision Spot instances as
        /// specified by InstanceTypeConfig. Each instance configuration has a specified WeightedCapacity. When
        /// a Spot instance is provisioned, the WeightedCapacity units count toward the target capacity. Amazon
        /// EMR provisions instances until the target capacity is totally fulfilled, even if this results in an
        /// overage. For example, if there are 2 units remaining to fulfill capacity, and Amazon EMR can only
        /// provision an instance with a WeightedCapacity of 5 units, the instance is provisioned, and the
        /// target capacity is exceeded by 3 units.
        /// Note If not specified or set to 0, only On-Demand instances are provisioned for the instance fleet.
        /// At least one of TargetSpotCapacity and TargetOnDemandCapacity should be greater than 0. For a master
        /// instance fleet, only one of TargetSpotCapacity and TargetOnDemandCapacity can be specified, and its
        /// value must be 1.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetSpotCapacity")]
        public Union<int, IntrinsicFunction> TargetSpotCapacity { get; set; }

    }
}
