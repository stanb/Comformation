using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster InstanceGroupConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html
    /// </summary>
    public class InstanceGroupConfig
    {

        /// <summary>
        /// AutoScalingPolicy
        /// AutoScalingPolicy is a subproperty of the InstanceGroupConfig property type that specifies the
        /// constraints and rules of an automatic scaling policy in Amazon EMR. The automatic scaling policy
        /// defines how an instance group dynamically adds and terminates EC2 instances in response to the value
        /// of a CloudWatch metric. Only core and task instance groups can use automatic scaling policies. For
        /// more information, see Using Automatic Scaling in Amazon EMR.
        /// Required: No
        /// Type: AutoScalingPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoScalingPolicy")]
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
        [JsonProperty("BidPrice")]
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
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

        /// <summary>
        /// EbsConfiguration
        /// EBS configurations that will be attached to each EC2 instance in the instance group.
        /// Required: No
        /// Type: EbsConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsConfiguration")]
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// InstanceCount
        /// Target number of instances for the instance group.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

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
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// Market
        /// Market type of the EC2 instances used to create a cluster node.
        /// Required: No
        /// Type: String
        /// Allowed values: ON_DEMAND | SPOT
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Market")]
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
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
