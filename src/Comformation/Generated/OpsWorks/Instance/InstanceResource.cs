using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    /// AWS::OpsWorks::Instance
    /// Creates an Amazon Elastic Compute Cloud (Amazon EC2) instance for an AWS OpsWorks stack. Instances for AWS
    /// OpsWorks stacks handle the work of serving applications and balancing traffic, for example.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            /// AgentVersion
            /// The version of the AWS OpsWorks agent that AWS OpsWorks installs on each instance. AWS OpsWorks
            /// sends commands to the agent to performs tasks on your instances, such as starting Chef runs. For
            /// valid values, see the AgentVersion parameter for the CreateInstance action in the AWS OpsWorks
            /// Stacks API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AgentVersion { get; set; }

            /// <summary>
            /// AmiId
            /// The ID of the custom Amazon Machine Image (AMI) to be used to create the instance. For more
            /// information about custom AMIs, see Using Custom AMIs in the AWS OpsWorks User Guide.
            /// Note If you specify this property, you must set the Os property to Custom.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> AmiId { get; set; }

            /// <summary>
            /// Architecture
            /// The instance architecture.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> Architecture { get; set; }

            /// <summary>
            /// AutoScalingType
            /// For scaling instances, the type of scaling. If you specify load-based scaling, do not specify a
            /// time-based scaling configuration. For valid values, see CreateInstance in the AWS OpsWorks Stacks
            /// API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingType { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The instance Availability Zone.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// A list of block devices that are mapped to the AWS OpsWorks instance. For more information, see the
            /// BlockDeviceMappings parameter for the CreateInstance action in the AWS OpsWorks Stacks API
            /// Reference.
            /// Required: No
            /// Type: List of AWS OpsWorks Instance BlockDeviceMapping
            /// Update requires: Replacement
            /// </summary>
			public Union<List<BlockDeviceMapping>, IntrinsicFunction> BlockDeviceMappings { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Whether the instance is optimized for Amazon Elastic Block Store (Amazon EBS) I/O. If you specify an
            /// Amazon EBS-optimized instance type, AWS OpsWorks enables EBS optimization by default. For more
            /// information, see Amazon EBS–Optimized Instances in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// ElasticIps
            /// A list of Elastic IP addresses to associate with the instance.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ElasticIps { get; set; }

            /// <summary>
            /// Hostname
            /// The name of the instance host.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Hostname { get; set; }

            /// <summary>
            /// InstallUpdatesOnBoot
            /// Whether to install operating system and package updates when the instance boots.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Some interruptions
            /// </summary>
			public Union<bool, IntrinsicFunction> InstallUpdatesOnBoot { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type, which must be supported by AWS OpsWorks. For more information, see CreateInstance
            /// in the AWS OpsWorks Stacks API Reference.
            /// If you specify an Amazon EBS-optimized instance type, AWS OpsWorks enables EBS optimization by
            /// default. For more information about Amazon EBS-optimized instance types, see Amazon EBS–Optimized
            /// Instances in the Amazon EC2 User Guide for Linux Instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// LayerIds
            /// The IDs of the AWS OpsWorks layers to associate with this instance.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Some interruptions
            /// </summary>
			public Union<List<string>, IntrinsicFunction> LayerIds { get; set; }

            /// <summary>
            /// Os
            /// The instance operating system. For more information, see CreateInstance in the AWS OpsWorks Stacks
            /// API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Os { get; set; }

            /// <summary>
            /// RootDeviceType
            /// The root device type of the instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RootDeviceType { get; set; }

            /// <summary>
            /// SshKeyName
            /// The SSH key name of the instance.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> SshKeyName { get; set; }

            /// <summary>
            /// StackId
            /// The ID of the AWS OpsWorks stack that this instance will be associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the instance&#39;s subnet. If the stack is running in a VPC, you can use this parameter to
            /// override the stack&#39;s default subnet ID value and direct AWS OpsWorks to launch the instance in a
            /// different subnet.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tenancy
            /// The tenancy of the instance. For more information, see the Tenancy parameter for the CreateInstance
            /// action in the AWS OpsWorks Stacks API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            /// TimeBasedAutoScaling
            /// The time-based scaling configuration for the instance.
            /// Required: No
            /// Type: AWS OpsWorks TimeBasedAutoScaling Type
            /// Update requires: Replacement
            /// </summary>
			public Union<TimeBasedAutoScaling, IntrinsicFunction> TimeBasedAutoScaling { get; set; }

            /// <summary>
            /// VirtualizationType
            /// The instance&#39;s virtualization type, paravirtual or hvm.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VirtualizationType { get; set; }

            /// <summary>
            /// Volumes
            /// A list of AWS OpsWorks volume IDs to associate with the instance. For more information, see
            /// AWS::OpsWorks::Volume.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Volumes { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::Instance";
        
        public InstanceProperties Properties { get; } = new InstanceProperties();
    }

	public static class InstanceAttributes
	{
        public static readonly ResourceAttribute<string> AvailabilityZone = new ResourceAttribute<string>("AvailabilityZone");
        public static readonly ResourceAttribute<string> PrivateDnsName = new ResourceAttribute<string>("PrivateDnsName");
        public static readonly ResourceAttribute<string> PrivateIp = new ResourceAttribute<string>("PrivateIp");
        public static readonly ResourceAttribute<string> PublicDnsName = new ResourceAttribute<string>("PublicDnsName");
        public static readonly ResourceAttribute<string> PublicIp = new ResourceAttribute<string>("PublicIp");
	}
}
