using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig
    /// The AWS::EMR::InstanceGroupConfig resource configures a task instance group for an Amazon EMR cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html
    /// </summary>
    public class InstanceGroupConfigResource : ResourceBase
    {
        public class InstanceGroupConfigProperties
        {
            /// <summary>
            /// AutoScalingPolicy
            /// An automatic scaling policy for a core instance group or task instance group in an Amazon EMR
            /// cluster. An automatic scaling policy defines how an instance group dynamically adds and terminates
            /// EC2 instances in response to the value of a CloudWatch metric. For more information, see
            /// PutAutoScalingPolicy in the Amazon EMR API Reference.
            /// Required: No
            /// Type: Amazon EMR InstanceGroupConfig AutoScalingPolicy
            /// Update requires: No interruption
            /// </summary>
			public AutoScalingPolicy AutoScalingPolicy { get; set; }

            /// <summary>
            /// BidPrice
            /// The bid price in USD for each Amazon EC2 instance in the instance group when launching instances
            /// (nodes) as Spot Instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BidPrice { get; set; }

            /// <summary>
            /// Configurations
            /// A list of configurations to apply to this instance group. For more information see, Configuring
            /// Applications in the Amazon EMR Release Guide.
            /// Required: No
            /// Type: List of Amazon EMR Cluster Configurations
            /// Update requires: Replacement
            /// </summary>
			public List<Configuration> Configurations { get; set; }

            /// <summary>
            /// EbsConfiguration
            /// Configures Amazon Elastic Block Store (Amazon EBS) storage volumes to attach to your instances.
            /// Required: No
            /// Type: Amazon EMR EbsConfiguration
            /// Update requires: Replacement
            /// </summary>
			public EbsConfiguration EbsConfiguration { get; set; }

            /// <summary>
            /// InstanceCount
            /// The number of instances to launch in the instance group.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> InstanceCount { get; set; }

            /// <summary>
            /// InstanceRole
            /// The role of the servers in the Amazon EMR cluster, such as TASK. For more information, see Instance
            /// Groups in the Amazon EMR Management Guide.
            /// Note Currently, the only valid value is TASK. You configure the master and core instance groups as
            /// part of the AWS::EMR::Cluster resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceRole { get; set; }

            /// <summary>
            /// InstanceType
            /// The EC2 instance type for all instances in the instance group. For more information, see Instance
            /// Configurations in the Amazon EMR Management Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// JobFlowId
            /// The ID of an Amazon EMR cluster that you want to associate this instance group with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobFlowId { get; set; }

            /// <summary>
            /// Market
            /// The type of marketplace from which your instances are provisioned into this group, either ON_DEMAND
            /// or SPOT. For more information, see Amazon EC2 Purchasing Options.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Market { get; set; }

            /// <summary>
            /// Name
            /// A name for the instance group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::EMR::InstanceGroupConfig";

        public InstanceGroupConfigProperties Properties { get; } = new InstanceGroupConfigProperties();

    }
}
