using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster BrokerNodeGroupInfo
    /// The setup to be used for brokers in the cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html
    /// </summary>
    public class BrokerNodeGroupInfo
    {

        /// <summary>
        /// SecurityGroups
        /// The AWS security groups to associate with the elastic network interfaces in order to specify who can
        /// connect to and communicate with the Amazon MSK cluster. If you don&#39;t specify a security group,
        /// Amazon MSK uses the default security group associated with the VPC. If you specify security groups
        /// that were shared with you, you must ensure that you have permissions to them. Specifically, you need
        /// the ec2:DescribeSecurityGroups permission.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// ClientSubnets
        /// The list of subnets to connect to in the client virtual private cloud (VPC). AWS creates elastic
        /// network interfaces inside these subnets. Client applications use elastic network interfaces to
        /// produce and consume data. Client subnets can&#39;t be in Availability Zone us-east-1e.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ClientSubnets")]
        public List<Union<string, IntrinsicFunction>> ClientSubnets { get; set; }

        /// <summary>
        /// StorageInfo
        /// Contains information about storage volumes attached to MSK broker nodes.
        /// Required: No
        /// Type: StorageInfo
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StorageInfo")]
        public StorageInfo StorageInfo { get; set; }

        /// <summary>
        /// BrokerAZDistribution
        /// The distribution of broker nodes across Availability Zones. This is an optional parameter. If you
        /// don&#39;t specify it, Amazon MSK gives it the value DEFAULT. You can also explicitly set this parameter
        /// to the value DEFAULT. No other values are currently allowed.
        /// Amazon MSK distributes the broker nodes evenly across the Availability Zones that correspond to the
        /// subnets that you provide when you create the cluster.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BrokerAZDistribution")]
        public Union<string, IntrinsicFunction> BrokerAZDistribution { get; set; }

        /// <summary>
        /// InstanceType
        /// The type of Amazon EC2 instances to use for brokers. The following instance types are allowed:
        /// kafka. m5. large, kafka. m5. xlarge, kafka. m5. 2xlarge, kafka. m5. 4xlarge, kafka. m5. 12xlarge,
        /// and kafka. m5. 24xlarge.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
