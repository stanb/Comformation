using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster BrokerNodeGroupInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html
    /// </summary>
    public class BrokerNodeGroupInfo
    {

        /// <summary>
        /// SecurityGroups
        /// The security groups to associate with the elastic network interfaces in order to specify who can
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
        /// The list of subnets to connect to in the client virtual private cloud (VPC). Amazon creates elastic
        /// network interfaces inside these subnets. Client applications use elastic network interfaces to
        /// produce and consume data.
        /// Specify exactly two subnets if you are using the US West (N. California) Region. For other Regions
        /// where Amazon MSK is available, you can specify either two or three subnets. The subnets that you
        /// specify must be in distinct Availability Zones. When you create a cluster, Amazon MSK distributes
        /// the broker nodes evenly across the subnets that you specify.
        /// Client subnets can&#39;t be in Availability Zone us-east-1e.
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
        /// This parameter is currently not in use.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BrokerAZDistribution")]
        public Union<string, IntrinsicFunction> BrokerAZDistribution { get; set; }

        /// <summary>
        /// InstanceType
        /// The type of Amazon EC2 instances to use for brokers. The following instance types are allowed:
        /// kafka. m5. large, kafka. m5. xlarge, kafka. m5. 2xlarge, kafka. m5. 4xlarge, kafka. m5. 8xlarge,
        /// kafka. m5. 12xlarge, kafka. m5. 16xlarge, and kafka. m5. 24xlarge.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
