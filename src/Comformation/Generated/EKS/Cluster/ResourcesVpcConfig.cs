using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// EKS Cluster ResourcesVpcConfig
    /// The ResourcesVpcConfig property type specifies the VPC subnets and security groups used by the Amazon EKS
    /// cluster control plane. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes.
    /// For more information, see Cluster VPC Considerations and Cluster Security Group Considerations in the Amazon
    /// EKS User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html
    /// </summary>
    public class ResourcesVpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// Specify one or more security groups for the cross-account elastic network interfaces that Amazon EKS
        /// creates to use to allow communication between your worker nodes and the Kubernetes control plane.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// Specify at least 2 subnets for your Amazon EKS worker nodes. Amazon EKS creates cross-account
        /// elastic network interfaces in these subnets to allow communication between your worker nodes and the
        /// Kubernetes control plane.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
