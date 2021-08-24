using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Nodegroup
{
    /// <summary>
    /// AWS::EKS::Nodegroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html
    /// </summary>
    public class NodegroupResource : ResourceBase
    {
        public class NodegroupProperties
        {
            /// <summary>
            /// UpdateConfig
            /// The node group update configuration.
            /// Required: No
            /// Type: UpdateConfig
            /// Update requires: No interruption
            /// </summary>
            public UpdateConfig UpdateConfig { get; set; }

            /// <summary>
            /// ScalingConfig
            /// The scaling configuration details for the Auto Scaling group that is created for your node group.
            /// Required: No
            /// Type: ScalingConfig
            /// Update requires: No interruption
            /// </summary>
            public ScalingConfig ScalingConfig { get; set; }

            /// <summary>
            /// Labels
            /// The Kubernetes labels to be applied to the nodes in the node group when they are created.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Labels { get; set; }

            /// <summary>
            /// Taints
            /// The Kubernetes taints to be applied to the nodes in the node group when they are created. Effect is
            /// one of No_Schedule, Prefer_No_Schedule, or No_Execute. Kubernetes taints can be used together with
            /// tolerations to control how workloads are scheduled to your nodes.
            /// Required: No
            /// Type: List of Taint
            /// Update requires: No interruption
            /// </summary>
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// ReleaseVersion
            /// The AMI version of the Amazon EKS optimized AMI to use with your node group (for example, 1. 14.
            /// 7-YYYYMMDD). By default, the latest available AMI version for the node group&#39;s current Kubernetes
            /// version is used. For more information, see Amazon EKS optimized Linux AMI Versions in the Amazon EKS
            /// User Guide.
            /// Note Changing this value triggers an update of the node group if one is available. However, only the
            /// latest available AMI release version is valid as an input. You cannot roll back to a previous AMI
            /// release version.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ReleaseVersion { get; set; }

            /// <summary>
            /// CapacityType
            /// The capacity type of your managed node group.
            /// Required: No
            /// Type: String
            /// Allowed values: ON_DEMAND | SPOT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CapacityType { get; set; }

            /// <summary>
            /// NodegroupName
            /// The unique name to give your node group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NodegroupName { get; set; }

            /// <summary>
            /// Subnets
            /// The subnets to use for the Auto Scaling group that is created for your node group. If you specify
            /// launchTemplate, then don&#39;t specify SubnetId in your launch template, or the node group deployment
            /// will fail. For more information about using launch templates with Amazon EKS, see Launch template
            /// support in the Amazon EKS User Guide.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

            /// <summary>
            /// NodeRole
            /// The Amazon Resource Name (ARN) of the IAM role to associate with your node group. The Amazon EKS
            /// worker node kubelet daemon makes calls to AWS APIs on your behalf. Nodes receive permissions for
            /// these API calls through an IAM instance profile and associated policies. Before you can launch nodes
            /// and register them into a cluster, you must create an IAM role for those nodes to use when they are
            /// launched. For more information, see Amazon EKS node IAM role in the Amazon EKS User Guide . If you
            /// specify launchTemplate, then don&#39;t specify IamInstanceProfile in your launch template, or the node
            /// group deployment will fail. For more information about using launch templates with Amazon EKS, see
            /// Launch template support in the Amazon EKS User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NodeRole { get; set; }

            /// <summary>
            /// AmiType
            /// The AMI type for your node group. GPU instance types should use the AL2_x86_64_GPU AMI type. Non-GPU
            /// instances should use the AL2_x86_64 AMI type. Arm instances should use the AL2_ARM_64 AMI type. All
            /// types use the Amazon EKS optimized Amazon Linux 2 AMI. If you specify launchTemplate, and your
            /// launch template uses a custom AMI, then don&#39;t specify amiType, or the node group deployment will
            /// fail. For more information about using launch templates with Amazon EKS, see Launch template support
            /// in the Amazon EKS User Guide.
            /// Required: No
            /// Type: String
            /// Allowed values: AL2_ARM_64 | AL2_x86_64 | AL2_x86_64_GPU | CUSTOM
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AmiType { get; set; }

            /// <summary>
            /// ForceUpdateEnabled
            /// Force the update if the existing node group&#39;s pods are unable to be drained due to a pod disruption
            /// budget issue. If an update fails because pods could not be drained, you can force the update after
            /// it fails to terminate the old node whether or not any pods are running on the node.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ForceUpdateEnabled { get; set; }

            /// <summary>
            /// Version
            /// The Kubernetes version to use for your managed nodes. By default, the Kubernetes version of the
            /// cluster is used, and this is the only accepted specified value. If you specify launchTemplate, and
            /// your launch template uses a custom AMI, then don&#39;t specify version, or the node group deployment
            /// will fail. For more information about using launch templates with Amazon EKS, see Launch template
            /// support in the Amazon EKS User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// An object representing a node group&#39;s launch template specification. If specified, then do not
            /// specify instanceTypes, diskSize, or remoteAccess and make sure that the launch template meets the
            /// requirements in launchTemplateSpecification.
            /// Required: No
            /// Type: LaunchTemplateSpecification
            /// Update requires: No interruption
            /// </summary>
            public LaunchTemplateSpecification LaunchTemplate { get; set; }

            /// <summary>
            /// RemoteAccess
            /// The remote access (SSH) configuration to use with your node group. If you specify launchTemplate,
            /// then don&#39;t specify remoteAccess, or the node group deployment will fail. For more information about
            /// using launch templates with Amazon EKS, see Launch template support in the Amazon EKS User Guide.
            /// Required: No
            /// Type: RemoteAccess
            /// Update requires: Replacement
            /// </summary>
            public RemoteAccess RemoteAccess { get; set; }

            /// <summary>
            /// DiskSize
            /// The root device disk size (in GiB) for your node group instances. The default disk size is 20 GiB.
            /// If you specify launchTemplate, then don&#39;t specify diskSize, or the node group deployment will fail.
            /// For more information about using launch templates with Amazon EKS, see Launch template support in
            /// the Amazon EKS User Guide.
            /// Required: No
            /// Type: Double
            /// Update requires: Replacement
            /// </summary>
            public Union<double, IntrinsicFunction> DiskSize { get; set; }

            /// <summary>
            /// ClusterName
            /// The name of the cluster to create the node group in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// InstanceTypes
            /// Specify the instance types for a node group. If you specify a GPU instance type, be sure to specify
            /// AL2_x86_64_GPU with the amiType parameter. If you specify launchTemplate, then you can specify zero
            /// or one instance type in your launch template or you can specify 0-20 instance types for
            /// instanceTypes. If however, you specify an instance type in your launch template and specify any
            /// instanceTypes, the node group deployment will fail. If you don&#39;t specify an instance type in a
            /// launch template or for instanceTypes, then t3. medium is used, by default. If you specify Spot for
            /// capacityType, then we recommend specifying multiple values for instanceTypes. For more information,
            /// see Managed node group capacity types and Launch template support in the Amazon EKS User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> InstanceTypes { get; set; }

            /// <summary>
            /// Tags
            /// The metadata to apply to the node group to assist with categorization and organization. Each tag
            /// consists of a key and an optional value, both of which you define. Node group tags do not propagate
            /// to any other resources associated with the node group, such as the Amazon EC2 instances or subnets.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EKS::Nodegroup";

        public NodegroupProperties Properties { get; } = new NodegroupProperties();

    }

    public static class NodegroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NodegroupName = new ResourceAttribute<Union<string, IntrinsicFunction>>("NodegroupName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClusterName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClusterName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
