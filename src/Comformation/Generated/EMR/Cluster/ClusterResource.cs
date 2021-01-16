using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// AdditionalInfo
            /// A JSON string for selecting additional features.
            /// Required: No
            /// Type: Json
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AdditionalInfo { get; set; }

            /// <summary>
            /// Applications
            /// The applications to install on this cluster, for example, Spark, Flink, Oozie, Zeppelin, and so on.
            /// Required: No
            /// Type: List of Application
            /// Update requires: Replacement
            /// </summary>
            public List<Application> Applications { get; set; }

            /// <summary>
            /// AutoScalingRole
            /// An IAM role for automatic scaling policies. The default role is EMR_AutoScaling_DefaultRole. The IAM
            /// role provides permissions that the automatic scaling feature requires to launch and terminate EC2
            /// instances in an instance group.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingRole { get; set; }

            /// <summary>
            /// BootstrapActions
            /// A list of bootstrap actions to run before Hadoop starts on the cluster nodes.
            /// Required: No
            /// Type: List of BootstrapActionConfig
            /// Update requires: Replacement
            /// </summary>
            public List<BootstrapActionConfig> BootstrapActions { get; set; }

            /// <summary>
            /// Configurations
            /// Applies only to Amazon EMR releases 4. x and later. The list of Configurations supplied to the EMR
            /// cluster.
            /// Required: No
            /// Type: List of Configuration
            /// Update requires: Replacement
            /// </summary>
            public List<Configuration> Configurations { get; set; }

            /// <summary>
            /// CustomAmiId
            /// Available only in Amazon EMR version 5. 7. 0 and later. The ID of a custom Amazon EBS-backed Linux
            /// AMI if the cluster uses a custom AMI.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomAmiId { get; set; }

            /// <summary>
            /// EbsRootVolumeSize
            /// The size, in GiB, of the Amazon EBS root device volume of the Linux AMI that is used for each EC2
            /// instance. Available in Amazon EMR version 4. x and later.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> EbsRootVolumeSize { get; set; }

            /// <summary>
            /// Instances
            /// A specification of the number and type of Amazon EC2 instances.
            /// Required: Yes
            /// Type: JobFlowInstancesConfig
            /// Update requires: Some interruptions
            /// </summary>
            public JobFlowInstancesConfig Instances { get; set; }

            /// <summary>
            /// JobFlowRole
            /// Also called instance profile and EC2 role. An IAM role for an EMR cluster. The EC2 instances of the
            /// cluster assume this role. The default role is EMR_EC2_DefaultRole. In order to use the default role,
            /// you must have already created it using the CLI or console.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobFlowRole { get; set; }

            /// <summary>
            /// KerberosAttributes
            /// Attributes for Kerberos configuration when Kerberos authentication is enabled using a security
            /// configuration. For more information see Use Kerberos Authentication in the Amazon EMR Management
            /// Guide.
            /// Required: No
            /// Type: KerberosAttributes
            /// Update requires: Replacement
            /// </summary>
            public KerberosAttributes KerberosAttributes { get; set; }

            /// <summary>
            /// LogEncryptionKmsKeyId
            /// The AWS KMS customer master key (CMK) used for encrypting log files. This attribute is only
            /// available with EMR version 5. 30. 0 and later, excluding EMR 6. 0. 0.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogEncryptionKmsKeyId { get; set; }

            /// <summary>
            /// LogUri
            /// The path to the Amazon S3 location where logs for this cluster are stored.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogUri { get; set; }

            /// <summary>
            /// ManagedScalingPolicy
            /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed scaling policy
            /// defines the limits for resources, such as EC2 instances that can be added or terminated from a
            /// cluster. The policy only applies to the core and task nodes. The master node cannot be scaled after
            /// initial configuration.
            /// Required: No
            /// Type: ManagedScalingPolicy
            /// Update requires: No interruption
            /// </summary>
            public ManagedScalingPolicy ManagedScalingPolicy { get; set; }

            /// <summary>
            /// Name
            /// The name of the cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ReleaseLabel
            /// The Amazon EMR release label, which determines the version of open-source application packages
            /// installed on the cluster. Release labels are in the form emr-x. x. x, where x. x. x is an Amazon EMR
            /// release version such as emr-5. 14. 0. For more information about Amazon EMR release versions and
            /// included application versions and features, see https://docs. aws. amazon.
            /// com/emr/latest/ReleaseGuide/. The release label applies only to Amazon EMR releases version 4. 0 and
            /// later. Earlier versions use AmiVersion.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReleaseLabel { get; set; }

            /// <summary>
            /// ScaleDownBehavior
            /// The way that individual Amazon EC2 instances terminate when an automatic scale-in activity occurs or
            /// an instance group is resized. TERMINATE_AT_INSTANCE_HOUR indicates that Amazon EMR terminates nodes
            /// at the instance-hour boundary, regardless of when the request to terminate the instance was
            /// submitted. This option is only available with Amazon EMR 5. 1. 0 and later and is the default for
            /// clusters created using that version. TERMINATE_AT_TASK_COMPLETION indicates that Amazon EMR adds
            /// nodes to a deny list and drains tasks from nodes before terminating the Amazon EC2 instances,
            /// regardless of the instance-hour boundary. With either behavior, Amazon EMR removes the least active
            /// nodes first and blocks instance termination if it could lead to HDFS corruption.
            /// TERMINATE_AT_TASK_COMPLETION is available only in Amazon EMR version 4. 1. 0 and later, and is the
            /// default for versions of Amazon EMR earlier than 5. 1. 0.
            /// Required: No
            /// Type: String
            /// Allowed values: TERMINATE_AT_INSTANCE_HOUR | TERMINATE_AT_TASK_COMPLETION
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScaleDownBehavior { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The name of the security configuration applied to the cluster.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityConfiguration { get; set; }

            /// <summary>
            /// ServiceRole
            /// The IAM role that will be assumed by the Amazon EMR service to access AWS resources on your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// StepConcurrencyLevel
            /// Specifies the number of steps that can be executed concurrently. The default value is 1. The maximum
            /// value is 256.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> StepConcurrencyLevel { get; set; }

            /// <summary>
            /// Steps
            /// A list of steps to run.
            /// Required: No
            /// Type: List of StepConfig
            /// Update requires: Replacement
            /// </summary>
            public List<StepConfig> Steps { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags associated with a cluster.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VisibleToAllUsers
            /// Indicates whether the cluster is visible to all IAM users of the AWS account associated with the
            /// cluster. If this value is set to true, all IAM users of that AWS account can view and manage the
            /// cluster if they have the proper policy permissions set. If this value is false, only the IAM user
            /// that created the cluster can view and manage it. This value can be changed using the
            /// SetVisibleToAllUsers action.
            /// Note When you create clusters directly through the EMR console or API, this value is set to true by
            /// default. However, for AWS::EMR::Cluster resources in CloudFormation, the default is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> VisibleToAllUsers { get; set; }

        }

        public string Type { get; } = "AWS::EMR::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

    public static class ClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MasterPublicDNS = new ResourceAttribute<Union<string, IntrinsicFunction>>("MasterPublicDNS");
    }
}
