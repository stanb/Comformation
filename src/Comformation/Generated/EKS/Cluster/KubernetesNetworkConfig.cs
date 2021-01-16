using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster KubernetesNetworkConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html
    /// </summary>
    public class KubernetesNetworkConfig
    {

        /// <summary>
        /// ServiceIpv4Cidr
        /// The CIDR block to assign Kubernetes service IP addresses from. If you don&#39;t specify a block,
        /// Kubernetes assigns addresses from either the 10. 100. 0. 0/16 or 172. 20. 0. 0/16 CIDR blocks. We
        /// recommend that you specify a block that does not overlap with resources in other networks that are
        /// peered or connected to your VPC. The block must meet the following requirements:
        /// Within one of the following private IP address blocks: 10. 0. 0. 0/8, 172. 16. 0. 0. 0/12, or 192.
        /// 168. 0. 0/16. Doesn&#39;t overlap with any CIDR block assigned to the VPC that you selected for VPC.
        /// Between /24 and /12.
        /// Important You can only specify a custom CIDR block when you create a cluster and can&#39;t change this
        /// value once the cluster is created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceIpv4Cidr")]
        public Union<string, IntrinsicFunction> ServiceIpv4Cidr { get; set; }

    }
}
