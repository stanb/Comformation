using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster
    /// The AWS::EKS::Cluster resource creates an Amazon EKS cluster control plane. The Amazon EKS cluster control
    /// plane consists of control plane instances that run the Kubernetes software, like etcd and the Kubernetes API
    /// server. The control plane runs in an account managed by AWS, and the Kubernetes API is exposed via the Amazon
    /// EKS endpoint associated with your cluster. For more information, see Clusters in the Amazon EKS User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// Version
            /// The Kubernetes server version for the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-version
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control
            /// plane to make calls to AWS API operations on your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ResourcesVpcConfig
            /// The VPC subnets and security groups used by the cluster control plane. Amazon EKS VPC resources have
            /// specific requirements to work properly with Kubernetes. For more information, see Cluster VPC
            /// Considerations and Cluster Security Group Considerations in the Amazon EKS User Guide.
            /// Required: Yes
            /// Type: EKS Cluster ResourcesVpcConfig
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-resourcesvpcconfig
            /// </summary>
			public Union<ResourcesVpcConfig, IntrinsicFunction> ResourcesVpcConfig { get; set; }

            /// <summary>
            /// Name
            /// The name of the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::EKS::Cluster";
        
        public ClusterProperties Properties { get; } = new ClusterProperties();
    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<string> Endpoint = new ResourceAttribute<string>("Endpoint");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> CertificateAuthorityData = new ResourceAttribute<string>("CertificateAuthorityData");
	}
}
