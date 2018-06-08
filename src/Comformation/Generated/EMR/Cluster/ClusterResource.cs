using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster
    /// The AWS::EMR::Cluster resource creates an Amazon EMR cluster. This cluster is a collection of EC2 instances
    /// that you can run big data frameworks on to process and analyze vast amounts of data. For more information, see
    /// Plan an Amazon EMR Cluster in the Amazon EMR Management Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// AdditionalInfo
            /// (Intended for advanced uses only. ) Additional features that you want to select. This is meta
            /// information about third-party applications that third-party vendors use for testing purposes.
            /// Required: No
            /// Type: JSON object
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AdditionalInfo { get; set; }

            /// <summary>
            /// Applications
            /// The software applications to deploy on the cluster, and the arguments that Amazon EMR passes to
            /// those applications.
            /// Required: No
            /// Type: List of Amazon EMR Cluster Application property types
            /// Update requires: Replacement
            /// </summary>
			public Union<List<Application>, IntrinsicFunction> Applications { get; set; }

            /// <summary>
            /// AutoScalingRole
            /// An AWS Identity and Access Management (IAM) role for automatic scaling policies. The default role is
            /// EMR_AutoScaling_DefaultRole. The IAM role provides permissions that the automatic scaling feature
            /// requires to launch and terminate Amazon EC2 instances in an instance group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingRole { get; set; }

            /// <summary>
            /// BootstrapActions
            /// A list of bootstrap actions that Amazon EMR runs before starting applications on the cluster.
            /// Required: No
            /// Type: List of Amazon EMR Cluster BootstrapActionConfig property types
            /// Update requires: Replacement
            /// </summary>
			public Union<List<BootstrapActionConfig>, IntrinsicFunction> BootstrapActions { get; set; }

            /// <summary>
            /// Configurations
            /// The software configuration of the Amazon EMR cluster.
            /// Required: No
            /// Type: List of Amazon EMR Cluster Configurations property types
            /// Update requires: Replacement
            /// </summary>
			public Union<List<Configuration>, IntrinsicFunction> Configurations { get; set; }

            /// <summary>
            /// CustomAmiId
            /// A custom Amazon Linux AMI for the cluster (instead of an EMR-owned AMI). For more information, see
            /// Using a Custom AMI in the Amazon EMR Management Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// Example: "CustomAmiId" : "ami-7fb3bc69"
            /// </summary>
			public Union<string, IntrinsicFunction> CustomAmiId { get; set; }

            /// <summary>
            /// EbsRootVolumeSize
            /// The size, in GiB, of the EBS root device volume of the Linux AMI that's used for each EC2 instance.
            /// Currently, AWS CloudFormation supports only Amazon EMR 4. 0 and later software releases.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> EbsRootVolumeSize { get; set; }

            /// <summary>
            /// Instances
            /// Configures the EC2 instances that run jobs in the Amazon EMR cluster.
            /// Required: Yes
            /// Type: Amazon EMR Cluster JobFlowInstancesConfig
            /// Update requires: Some interruptions
            /// </summary>
			public Union<JobFlowInstancesConfig, IntrinsicFunction> Instances { get; set; }

            /// <summary>
            /// JobFlowRole
            /// (Also called instance profile and EC2 role. ) Accepts an instance profile that's associated with the
            /// role that you want to use. All EC2 instances in the cluster assume this role. For more information,
            /// see Create and Use IAM Roles for Amazon EMR in the Amazon EMR Management Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobFlowRole { get; set; }

            /// <summary>
            /// LogUri
            /// An S3 bucket location that Amazon EMR writes logs files to from a job flow. If you don't specify a
            /// value, Amazon EMR doesn't write any log files.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogUri { get; set; }

            /// <summary>
            /// Name
            /// A name for the Amazon EMR cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ReleaseLabel
            /// The Amazon EMR software release label. A release is a set of software applications and components
            /// that you can install and configure on an Amazon EMR cluster. For more information, see About Amazon
            /// EMR Releases in the Amazon EMR Release Guide.
            /// Currently, AWS CloudFormation supports only Amazon EMR 4. 0 and later software releases.
            /// Required: Conditional. If you specify the Applications property, you must specify this property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReleaseLabel { get; set; }

            /// <summary>
            /// ScaleDownBehavior
            /// Indicates how individual EC2 instances terminate when an automatic scale-in activity occurs or an
            /// instance group is resized. For more information, see Cluster in the Amazon EMR API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScaleDownBehavior { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The name of the security configuration that's applied to the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SecurityConfiguration { get; set; }

            /// <summary>
            /// ServiceRole
            /// The IAM role that Amazon EMR assumes to access AWS resources on your behalf. For more information,
            /// see Configure IAM Roles for Amazon EMR in the Amazon EMR Management Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to help you identify the Amazon EMR cluster.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VisibleToAllUsers
            /// Indicates whether the instances in the cluster are visible to all IAM users in the AWS account. If
            /// you specify true, all IAM users can view and (if they have permissions) manage the instances. If you
            /// specify false, only the IAM user that created the cluster can view and manage it.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// Default value: false
            /// </summary>
			public Union<bool, IntrinsicFunction> VisibleToAllUsers { get; set; }

        }
    
        public string Type { get; } = "AWS::EMR::Cluster";
        
        public ClusterProperties Properties { get; } = new ClusterProperties();
    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<string> MasterPublicDNS = new ResourceAttribute<string>("MasterPublicDNS");
	}
}
