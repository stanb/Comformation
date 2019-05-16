using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster ResourcesVpcConfig
    /// An object representing the VPC configuration to use for an Amazon EKS cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html
    /// </summary>
    public class ResourcesVpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// Specify one or more security groups for the cross-account elastic network interfaces that Amazon EKS
        /// creates to use to allow communication between your worker nodes and the Kubernetes control plane. If
        /// you don&#39;t specify a security group, the default security group for your VPC is used.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// Specify subnets for your Amazon EKS worker nodes. Amazon EKS creates cross-account elastic network
        /// interfaces in these subnets to allow communication between your worker nodes and the Kubernetes
        /// control plane.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
