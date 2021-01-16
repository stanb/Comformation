using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster ResourcesVpcConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html
    /// </summary>
    public class ResourcesVpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// Specify one or more security groups for the cross-account elastic network interfaces that Amazon EKS
        /// creates to use to allow communication between your nodes and the Kubernetes control plane. If you
        /// don&#39;t specify any security groups, then familiarize yourself with the difference between Amazon EKS
        /// defaults for clusters deployed with Kubernetes:
        /// 1. 14 Amazon EKS platform version eks. 2 and earlier 1. 14 Amazon EKS platform version eks. 3 and
        /// later
        /// For more information, see Amazon EKS security group considerations in the Amazon EKS User Guide .
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// Specify subnets for your Amazon EKS nodes. Amazon EKS creates cross-account elastic network
        /// interfaces in these subnets to allow communication between your nodes and the Kubernetes control
        /// plane.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
