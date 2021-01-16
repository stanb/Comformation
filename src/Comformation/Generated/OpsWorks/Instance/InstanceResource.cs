using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    /// AWS::OpsWorks::Instance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            /// AgentVersion
            /// The default AWS OpsWorks Stacks agent version. You have the following options:
            /// INHERIT - Use the stack&#39;s default agent version setting. version_number - Use the specified agent
            /// version. This value overrides the stack&#39;s default setting. To update the agent version, edit the
            /// instance configuration and specify a new version. AWS OpsWorks Stacks then automatically installs
            /// that version on the instance.
            /// The default setting is INHERIT. To specify an agent version, you must use the complete version
            /// number, not the abbreviated number shown on the console. For a list of available agent version
            /// numbers, call DescribeAgentVersions. AgentVersion cannot be set to Chef 12. 2.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AgentVersion { get; set; }

            /// <summary>
            /// AmiId
            /// A custom AMI ID to be used to create the instance. The AMI should be based on one of the supported
            /// operating systems. For more information, see Using Custom AMIs.
            /// Note If you specify a custom AMI, you must set Os to Custom.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AmiId { get; set; }

            /// <summary>
            /// Architecture
            /// The instance architecture. The default option is x86_64. Instance types do not necessarily support
            /// both architectures. For a list of the architectures that are supported by the different instance
            /// types, see Instance Families and Types.
            /// Required: No
            /// Type: String
            /// Allowed values: i386 | x86_64
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Architecture { get; set; }

            /// <summary>
            /// AutoScalingType
            /// For load-based or time-based instances, the type. Windows stacks can use only time-based instances.
            /// Required: No
            /// Type: String
            /// Allowed values: load | timer
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingType { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone of the AWS OpsWorks instance, such as us-east-2a.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// An array of BlockDeviceMapping objects that specify the instance&#39;s block devices. For more
            /// information, see Block Device Mapping. Note that block device mappings are not supported for custom
            /// AMIs.
            /// Required: No
            /// Type: List of BlockDeviceMapping
            /// Update requires: Replacement
            /// </summary>
            public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Whether to create an Amazon EBS-optimized instance.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// ElasticIps
            /// A list of Elastic IP addresses to associate with the instance.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ElasticIps { get; set; }

            /// <summary>
            /// Hostname
            /// The instance host name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Hostname { get; set; }

            /// <summary>
            /// InstallUpdatesOnBoot
            /// Whether to install operating system and package updates when the instance boots. The default value
            /// is true. To control when updates are installed, set this value to false. You must then update your
            /// instances manually by using CreateDeployment to run the update_dependencies stack command or by
            /// manually running yum (Amazon Linux) or apt-get (Ubuntu) on the instances.
            /// Note We strongly recommend using the default value of true to ensure that your instances have the
            /// latest security updates.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> InstallUpdatesOnBoot { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type, such as t2. micro. For a list of supported instance types, open the stack in the
            /// console, choose Instances, and choose + Instance. The Size list contains the currently supported
            /// types. For more information, see Instance Families and Types. The parameter values that you use to
            /// specify the various types are in the API Name column of the Available Instance Types table.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// LayerIds
            /// An array that contains the instance&#39;s layer IDs.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> LayerIds { get; set; }

            /// <summary>
            /// Os
            /// The instance&#39;s operating system, which must be set to one of the following.
            /// A supported Linux operating system: An Amazon Linux version, such as Amazon Linux 2018. 03, Amazon
            /// Linux 2017. 09, Amazon Linux 2017. 03, Amazon Linux 2016. 09, Amazon Linux 2016. 03, Amazon Linux
            /// 2015. 09, or Amazon Linux 2015. 03. A supported Ubuntu operating system, such as Ubuntu 16. 04 LTS,
            /// Ubuntu 14. 04 LTS, or Ubuntu 12. 04 LTS. CentOS Linux 7 Red Hat Enterprise Linux 7 A supported
            /// Windows operating system, such as Microsoft Windows Server 2012 R2 Base, Microsoft Windows Server
            /// 2012 R2 with SQL Server Express, 			 Microsoft Windows Server 2012 R2 with SQL Server Standard, or
            /// Microsoft Windows Server 2012 R2 with SQL Server Web. A custom AMI: Custom.
            /// For more information about the supported operating systems, see AWS OpsWorks Stacks Operating
            /// Systems.
            /// The default option is the current Amazon Linux version. If you set this parameter to Custom, you
            /// must use the CreateInstance action&#39;s AmiId parameter to specify the custom AMI that you want to use.
            /// Block device mappings are not supported if the value is Custom. For more information about supported
            /// operating systems, see Operating SystemsFor more information about how to use custom AMIs with AWS
            /// OpsWorks Stacks, see Using Custom AMIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Os { get; set; }

            /// <summary>
            /// RootDeviceType
            /// The instance root device type. For more information, see Storage for the Root Device.
            /// Required: No
            /// Type: String
            /// Allowed values: ebs | instance-store
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RootDeviceType { get; set; }

            /// <summary>
            /// SshKeyName
            /// The instance&#39;s Amazon EC2 key-pair name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SshKeyName { get; set; }

            /// <summary>
            /// StackId
            /// The stack ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the instance&#39;s subnet. If the stack is running in a VPC, you can use this parameter to
            /// override the stack&#39;s default subnet ID value and direct AWS OpsWorks Stacks to launch the instance
            /// in a different subnet.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tenancy
            /// The instance&#39;s tenancy option. The default option is no tenancy, or if the instance is running in a
            /// VPC, inherit tenancy settings from the VPC. The following are valid values for this parameter:
            /// dedicated, default, or host. Because there are costs associated with changes in tenancy options, we
            /// recommend that you research tenancy options before choosing them for your instances. For more
            /// information about dedicated hosts, see Dedicated Hosts Overview and Amazon EC2 Dedicated Hosts. For
            /// more information about dedicated instances, see Dedicated Instances and Amazon EC2 Dedicated
            /// Instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            /// TimeBasedAutoScaling
            /// The time-based scaling configuration for the instance.
            /// Required: No
            /// Type: TimeBasedAutoScaling
            /// Allowed values: load | timer
            /// Update requires: Replacement
            /// </summary>
            public TimeBasedAutoScaling TimeBasedAutoScaling { get; set; }

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
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Volumes { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::Instance";

        public InstanceProperties Properties { get; } = new InstanceProperties();

    }

    public static class InstanceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AvailabilityZone = new ResourceAttribute<Union<string, IntrinsicFunction>>("AvailabilityZone");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrivateDnsName = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrivateDnsName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PrivateIp = new ResourceAttribute<Union<string, IntrinsicFunction>>("PrivateIp");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublicDnsName = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublicDnsName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PublicIp = new ResourceAttribute<Union<string, IntrinsicFunction>>("PublicIp");
    }
}
