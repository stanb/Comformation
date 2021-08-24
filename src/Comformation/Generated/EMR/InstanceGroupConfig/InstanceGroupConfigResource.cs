using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html
    /// </summary>
    public class InstanceGroupConfigResource : ResourceBase
    {
        public class InstanceGroupConfigProperties
        {
            /// <summary>
            /// AutoScalingPolicy
            /// AutoScalingPolicy is a subproperty of InstanceGroupConfig. AutoScalingPolicy defines how an instance
            /// group dynamically adds and terminates EC2 instances in response to the value of a CloudWatch metric.
            /// For more information, see Using Automatic Scaling in Amazon EMR in the Amazon EMR Management Guide.
            /// Required: No
            /// Type: AutoScalingPolicy
            /// Update requires: No interruption
            /// </summary>
            public AutoScalingPolicy AutoScalingPolicy { get; set; }

            /// <summary>
            /// BidPrice
            /// If specified, indicates that the instance group uses Spot Instances. This is the maximum price you
            /// are willing to pay for Spot Instances. Specify OnDemandPrice to set the amount equal to the
            /// On-Demand price, or specify an amount in USD.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BidPrice { get; set; }

            /// <summary>
            /// Configurations
            /// Note Amazon EMR releases 4. x or later.
            /// The list of configurations supplied for an EMR cluster instance group. You can specify a separate
            /// configuration for each instance group (master, core, and task).
            /// Required: No
            /// Type: List of Configuration
            /// Update requires: Replacement
            /// </summary>
            public List<Configuration> Configurations { get; set; }

            /// <summary>
            /// EbsConfiguration
            /// EbsConfiguration determines the EBS volumes to attach to EMR cluster instances.
            /// Required: No
            /// Type: EbsConfiguration
            /// Update requires: Replacement
            /// </summary>
            public EbsConfiguration EbsConfiguration { get; set; }

            /// <summary>
            /// InstanceCount
            /// Target number of instances for the instance group.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> InstanceCount { get; set; }

            /// <summary>
            /// InstanceRole
            /// The role of the instance group in the cluster.
            /// Allowed Values: TASK
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceRole { get; set; }

            /// <summary>
            /// InstanceType
            /// The EC2 instance type for all instances in the instance group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
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
            /// Market type of the EC2 instances used to create a cluster node.
            /// Required: No
            /// Type: String
            /// Allowed values: ON_DEMAND | SPOT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Market { get; set; }

            /// <summary>
            /// Name
            /// Friendly name given to the instance group.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::EMR::InstanceGroupConfig";

        public InstanceGroupConfigProperties Properties { get; } = new InstanceGroupConfigProperties();

    }
}
