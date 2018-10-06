using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster InstanceGroupConfig
    /// InstanceGroupConfig is a property of the CoreInstanceGroup and MasterInstanceGroup properties of the job flow
    /// instances configuration. The InstanceGroupConfig property specifies the settings for instances (nodes) in the
    /// core and master instance groups of an Amazon EMR cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html
    /// </summary>
    public class InstanceGroupConfig
    {

        /// <summary>
        /// AutoScalingPolicy
        /// An automatic scaling policy for a core instance group or task instance group in an Amazon EMR
        /// cluster. An automatic scaling policy defines how an instance group dynamically adds and terminates
        /// EC2 instances in response to the value of a CloudWatch metric.
        /// Required: No
        /// Update requires: No interruption
        /// Type: Amazon EMR Cluster AutoScalingPolicy
        /// </summary>
        [JsonProperty("AutoScalingPolicy")]
        public AutoScalingPolicy AutoScalingPolicy { get; set; }

        /// <summary>
        /// BidPrice
        /// When launching instances as Spot Instances, the bid price in USD for each EC2 instance in the
        /// instance group.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPrice")]
        public Union<string, IntrinsicFunction> BidPrice { get; set; }

        /// <summary>
        /// Configurations
        /// A list of configurations to apply to this instance group. For more information see, Configuring
        /// Applications in the Amazon EMR Release Guide.
        /// Required: No
        /// Type: List of Amazon EMR Cluster Configurations
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

        /// <summary>
        /// EbsConfiguration
        /// Configures Amazon Elastic Block Store (Amazon EBS) storage volumes to attach to your instances.
        /// Required: No
        /// Type: Amazon EMR EbsConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsConfiguration")]
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// InstanceCount
        /// The number of instances to launch in the instance group.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("InstanceCount")]
        public Union<int, IntrinsicFunction> InstanceCount { get; set; }

        /// <summary>
        /// InstanceType
        /// The EC2 instance type for all instances in the instance group. For more information, see Instance
        /// Configurations in the Amazon EMR Management Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// Market
        /// The type of marketplace from which your instances are provisioned into this group, either ON_DEMAND
        /// or SPOT. For more information, see Amazon EC2 Purchasing Options.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Market")]
        public Union<string, IntrinsicFunction> Market { get; set; }

        /// <summary>
        /// Name
        /// A name for the instance group.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
