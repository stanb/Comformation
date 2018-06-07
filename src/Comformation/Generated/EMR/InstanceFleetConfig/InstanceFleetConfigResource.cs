using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig
    /// Use the AWS::EMR::InstanceFleetConfig resource to configure a Spot Instance fleet for an Amazon EMR cluster.
    /// For more information, see Configure Instance Fleets in the Amazon EMR Management Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html
    /// </summary>
    public class InstanceFleetConfigResource : ResourceBase
    {
        public class InstanceFleetConfigProperties
        {
            /// <summary>
            /// ClusterId
            /// The ID of the target cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterId { get; set; }

            /// <summary>
            /// InstanceFleetType
            /// The node type that the instance fleet hosts. Valid values are MASTER, CORE, and TASK.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceFleetType { get; set; }

            /// <summary>
            /// InstanceTypeConfigs
            /// The instance type configurations that define the EC2 instances in the instance fleet. Duplicates not
            /// allowed.
            /// Required: No
            /// Type: List of Amazon EMR InstanceFleetConfig InstanceTypeConfig
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
            /// </summary>
			public Union<List<InstanceTypeConfig>, IntrinsicFunction> InstanceTypeConfigs { get; set; }

            /// <summary>
            /// LaunchSpecifications
            /// The launch specification for the instance fleet.
            /// Required: No
            /// Type: Amazon EMR InstanceFleetConfig InstanceFleetProvisioningSpecifications
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
            /// </summary>
			public Union<InstanceFleetProvisioningSpecifications, IntrinsicFunction> LaunchSpecifications { get; set; }

            /// <summary>
            /// Name
            /// The friendly name of the instance fleet. For constraints, see InstanceFleetConfig in the Amazon EMR
            /// API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// TargetOnDemandCapacity
            /// The target capacity of On-Demand units for the instance fleet. This determines how many On-Demand
            /// Instances to provision. For more information, see InstanceFleetConfig in the Amazon EMR API
            /// Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
            /// </summary>
			public Union<int, IntrinsicFunction> TargetOnDemandCapacity { get; set; }

            /// <summary>
            /// TargetSpotCapacity
            /// The target capacity of Spot units for the instance fleet. This determines how many Spot Instances to
            /// provision. For more information, see InstanceFleetConfig in the Amazon EMR API Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
            /// </summary>
			public Union<int, IntrinsicFunction> TargetSpotCapacity { get; set; }

        }
    
        public string Type { get; } = "AWS::EMR::InstanceFleetConfig";
        
        public InstanceFleetConfigProperties Properties { get; } = new InstanceFleetConfigProperties();
    }
}
