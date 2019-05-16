using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster
    /// Creates an Amazon EKS control plane.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// Version
            /// The desired Kubernetes version for your cluster. If you don&#39;t specify a value here, the latest
            /// version available in Amazon EKS is used.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for Amazon EKS to make
            /// calls to other AWS API operations on your behalf. For more information, see Amazon EKS Service IAM
            /// Role in the Amazon EKS User Guide .
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ResourcesVpcConfig
            /// The VPC configuration used by the cluster control plane. Amazon EKS VPC resources have specific
            /// requirements to work properly with Kubernetes. For more information, see Cluster VPC Considerations
            /// and Cluster Security Group Considerations in the Amazon EKS User Guide. You must specify at least
            /// two subnets. You can specify up to five security groups, but we recommend that you use a dedicated
            /// security group for your cluster control plane.
            /// Required: Yes
            /// Type: ResourcesVpcConfig
            /// Update requires: Replacement
            /// </summary>
			public ResourcesVpcConfig ResourcesVpcConfig { get; set; }

            /// <summary>
            /// Name
            /// The unique name to give to your cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::EKS::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateAuthorityData = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateAuthorityData");
	}
}
