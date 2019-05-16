using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig
    /// Use InstanceFleetConfig to define instance fleets for an EMR cluster. A cluster can not use both instance
    /// fleets and instance groups. For more information, see Configure Instance Fleets in the Amazon EMR Management
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html
    /// </summary>
    public class InstanceFleetConfigResource : ResourceBase
    {
        public class InstanceFleetConfigProperties
        {
            /// <summary>
            /// ClusterId
            /// The unique identifier of the EMR cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterId { get; set; }

            /// <summary>
            /// InstanceFleetType
            /// The node type that the instance fleet hosts. Valid values are MASTER,CORE,and TASK.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: CORE | MASTER | TASK
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceFleetType { get; set; }

            /// <summary>
            /// InstanceTypeConfigs
            /// InstanceTypeConfigs determine the EC2 instances that Amazon EMR attempts to provision to fulfill
            /// On-Demand and Spot target capacities. There can be a maximum of 5 instance type configurations in a
            /// fleet, each one specified using an InstanceTypeConfig.
            /// Note The instance fleet configuration is available only in Amazon EMR versions 4. 8. 0 and later,
            /// excluding 5. 0. x versions.
            /// Required: No
            /// Type: List of InstanceTypeConfig
            /// Update requires: Replacement
            /// </summary>
			public List<InstanceTypeConfig> InstanceTypeConfigs { get; set; }

            /// <summary>
            /// LaunchSpecifications
            /// The launch specification for the instance fleet.
            /// Required: No
            /// Type: InstanceFleetProvisioningSpecifications
            /// Update requires: Replacement
            /// </summary>
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
			public Union<int, IntrinsicFunction> TargetSpotCapacity { get; set; }

        }

        public string Type { get; } = "AWS::EMR::InstanceFleetConfig";

        public InstanceFleetConfigProperties Properties { get; } = new InstanceFleetConfigProperties();

    }
}
