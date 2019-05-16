using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance
    /// Specifies an EC2 instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            /// AdditionalInfo
            /// Reserved.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> AdditionalInfo { get; set; }

            /// <summary>
            /// Affinity
            /// 	
            /// Indicates whether the instance is associated with a dedicated host. If you want the instance 	 	to
            /// always restart on the same host on which it was launched, specify host. If you 		want the instance
            /// to restart on any available host, but try to launch onto the last host it 		ran on (on a best-effort
            /// basis), specify default.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> Affinity { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone of the instance.
            /// If not specified, an Availability Zone will be automatically chosen for you based on the load
            /// balancing criteria for the Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// The block device mapping entries.
            /// Required: No
            /// Type: List of BlockDeviceMapping
            /// </summary>
			public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

            /// <summary>
            /// CreditSpecification
            /// The credit option for CPU usage of the T2 or T3 instance. Valid values are standard and unlimited.
            /// To change this attribute after launch, use ModifyInstanceCreditSpecification. For more information,
            /// see Burstable Performance Instances in the Amazon Elastic Compute Cloud User Guide.
            /// Default: standard (T2 instances) or unlimited (T3 instances)
            /// Required: No
            /// Type: CreditSpecification
            /// Update requires: No interruption
            /// </summary>
			public CreditSpecification CreditSpecification { get; set; }

            /// <summary>
            /// DisableApiTermination
            /// If you set this parameter to true, you can&#39;t terminate the instance using the Amazon EC2 console,
            /// CLI, or API; otherwise, you can. To change this attribute to false after launch, use
            /// ModifyInstanceAttribute. Alternatively, if you set InstanceInitiatedShutdownBehavior to terminate,
            /// you can terminate the instance by running the shutdown command from the instance.
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableApiTermination { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization provides dedicated
            /// throughput to Amazon EBS and an optimized configuration stack to provide optimal Amazon EBS I/O
            /// performance. This optimization isn&#39;t available with all instance types. Additional usage charges
            /// apply when using an EBS-optimized instance.
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// </summary>
			public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// ElasticGpuSpecifications
            /// An elastic GPU to associate with the instance. An Elastic GPU is a GPU resource that you can attach
            /// to your Windows instance to accelerate the graphics performance of your applications. For more
            /// information, see Amazon EC2 Elastic GPUs in the Amazon Elastic Compute Cloud User Guide.
            /// Required: No
            /// Type: List of ElasticGpuSpecification
            /// Update requires: Replacement
            /// </summary>
			public List<ElasticGpuSpecification> ElasticGpuSpecifications { get; set; }

            /// <summary>
            /// ElasticInferenceAccelerators
            /// An elastic inference accelerator to associate with the instance. Elastic inference accelerators are
            /// a resource you can attach to your Amazon EC2 instances to accelerate your Deep Learning (DL)
            /// inference workloads.
            /// Required: No
            /// Type: List of ElasticInferenceAccelerator
            /// Update requires: Replacement
            /// </summary>
			public List<ElasticInferenceAccelerator> ElasticInferenceAccelerators { get; set; }

            /// <summary>
            /// HostId
            /// 	
            /// If you specify host for the Affinity property, the ID of a dedicated host that the instance is
            /// associated with. 	 If you don&#39;t specify an ID, Amazon EC2 launches the instance onto any available,
            /// compatible dedicated host in your account. 	 This type of launch is called an untargeted launch.
            /// Note that for untargeted launches, you must have a compatible, dedicated 	 host available to
            /// successfully launch instances.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> HostId { get; set; }

            /// <summary>
            /// IamInstanceProfile
            /// The IAM instance profile.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IamInstanceProfile { get; set; }

            /// <summary>
            /// ImageId
            /// The ID of the AMI, which you can get by calling DescribeImages. An AMI ID is required to launch an
            /// instance and must be specified here or in a launch template.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ImageId { get; set; }

            /// <summary>
            /// InstanceInitiatedShutdownBehavior
            /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance
            /// (using the operating system command for system shutdown).
            /// Default: stop
            /// Required: No
            /// Type: String
            /// Allowed Values: stop | terminate
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceInitiatedShutdownBehavior { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type. For more information, see Instance Types in the Amazon Elastic Compute Cloud User
            /// Guide.
            /// Default: m1. small
            /// Required: No
            /// Type: String
            /// Allowed Values: a1. 2xlarge | a1. 4xlarge | a1. large | a1. medium | a1. xlarge | c1. medium | c1.
            /// xlarge | c3. 2xlarge | c3. 4xlarge | c3. 8xlarge | c3. large | c3. xlarge | c4. 2xlarge | c4.
            /// 4xlarge | c4. 8xlarge | c4. large | c4. xlarge | c5. 18xlarge | c5. 2xlarge | c5. 4xlarge | c5.
            /// 9xlarge | c5. large | c5. xlarge | c5d. 18xlarge | c5d. 2xlarge | c5d. 4xlarge | c5d. 9xlarge | c5d.
            /// large | c5d. xlarge | c5n. 18xlarge | c5n. 2xlarge | c5n. 4xlarge | c5n. 9xlarge | c5n. large | c5n.
            /// xlarge | cc1. 4xlarge | cc2. 8xlarge | cg1. 4xlarge | cr1. 8xlarge | d2. 2xlarge | d2. 4xlarge | d2.
            /// 8xlarge | d2. xlarge | f1. 16xlarge | f1. 2xlarge | f1. 4xlarge | g2. 2xlarge | g2. 8xlarge | g3.
            /// 16xlarge | g3. 4xlarge | g3. 8xlarge | g3s. xlarge | h1. 16xlarge | h1. 2xlarge | h1. 4xlarge | h1.
            /// 8xlarge | hi1. 4xlarge | hs1. 8xlarge | i2. 2xlarge | i2. 4xlarge | i2. 8xlarge | i2. xlarge | i3.
            /// 16xlarge | i3. 2xlarge | i3. 4xlarge | i3. 8xlarge | i3. large | i3. metal | i3. xlarge | i3en.
            /// 12xlarge | i3en. 24xlarge | i3en. 2xlarge | i3en. 3xlarge | i3en. 6xlarge | i3en. large | i3en.
            /// metal | i3en. xlarge | m1. large | m1. medium | m1. small | m1. xlarge | m2. 2xlarge | m2. 4xlarge |
            /// m2. xlarge | m3. 2xlarge | m3. large | m3. medium | m3. xlarge | m4. 10xlarge | m4. 16xlarge | m4.
            /// 2xlarge | m4. 4xlarge | m4. large | m4. xlarge | m5. 12xlarge | m5. 24xlarge | m5. 2xlarge | m5.
            /// 4xlarge | m5. large | m5. metal | m5. xlarge | m5a. 12xlarge | m5a. 24xlarge | m5a. 2xlarge | m5a.
            /// 4xlarge | m5a. large | m5a. xlarge | m5ad. 12xlarge | m5ad. 16xlarge | m5ad. 24xlarge | m5ad.
            /// 2xlarge | m5ad. 4xlarge | m5ad. 8xlarge | m5ad. large | m5ad. xlarge | m5d. 12xlarge | m5d. 24xlarge
            /// | m5d. 2xlarge | m5d. 4xlarge | m5d. large | m5d. metal | m5d. xlarge | p2. 16xlarge | p2. 8xlarge |
            /// p2. xlarge | p3. 16xlarge | p3. 2xlarge | p3. 8xlarge | p3dn. 24xlarge | r3. 2xlarge | r3. 4xlarge |
            /// r3. 8xlarge | r3. large | r3. xlarge | r4. 16xlarge | r4. 2xlarge | r4. 4xlarge | r4. 8xlarge | r4.
            /// large | r4. xlarge | r5. 12xlarge | r5. 24xlarge | r5. 2xlarge | r5. 4xlarge | r5. large | r5. metal
            /// | r5. xlarge | r5a. 12xlarge | r5a. 24xlarge | r5a. 2xlarge | r5a. 4xlarge | r5a. large | r5a.
            /// xlarge | r5ad. 12xlarge | r5ad. 16xlarge | r5ad. 24xlarge | r5ad. 2xlarge | r5ad. 4xlarge | r5ad.
            /// 8xlarge | r5ad. large | r5ad. xlarge | r5d. 12xlarge | r5d. 24xlarge | r5d. 2xlarge | r5d. 4xlarge |
            /// r5d. large | r5d. metal | r5d. xlarge | t1. micro | t2. 2xlarge | t2. large | t2. medium | t2. micro
            /// | t2. nano | t2. small | t2. xlarge | t3. 2xlarge | t3. large | t3. medium | t3. micro | t3. nano |
            /// t3. small | t3. xlarge | t3a. 2xlarge | t3a. large | t3a. medium | t3a. micro | t3a. nano | t3a.
            /// small | t3a. xlarge | u-12tb1. metal | u-6tb1. metal | u-9tb1. metal | x1. 16xlarge | x1. 32xlarge |
            /// x1e. 16xlarge | x1e. 2xlarge | x1e. 32xlarge | x1e. 4xlarge | x1e. 8xlarge | x1e. xlarge | z1d.
            /// 12xlarge | z1d. 2xlarge | z1d. 3xlarge | z1d. 6xlarge | z1d. large | z1d. metal | z1d. xlarge
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Ipv6AddressCount
            /// [EC2-VPC] The number of IPv6 addresses to associate with the primary network interface. Amazon EC2
            /// chooses the IPv6 addresses from the range of your subnet. You cannot specify this option and the
            /// option to assign specific IPv6 addresses in the same request. You can specify this option if you&#39;ve
            /// specified a minimum number of instances to launch.
            /// You cannot specify this option and the network interfaces option in the same request.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            /// Ipv6Addresses
            /// [EC2-VPC] The IPv6 addresses from the range of the subnet to associate with the primary network
            /// interface. You cannot specify this option and the option to assign a number of IPv6 addresses in the
            /// same request. You cannot specify this option if you&#39;ve specified a minimum number of instances to
            /// launch.
            /// You cannot specify this option and the network interfaces option in the same request.
            /// Required: No
            /// Type: List of InstanceIpv6Address
            /// Update requires: Replacement
            /// </summary>
			public List<InstanceIpv6Address> Ipv6Addresses { get; set; }

            /// <summary>
            /// KernelId
            /// The ID of the kernel.
            /// Important We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
            /// see PV-GRUB in the Amazon Elastic Compute Cloud User Guide.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> KernelId { get; set; }

            /// <summary>
            /// KeyName
            /// The name of the key pair. You can create a key pair using CreateKeyPair or ImportKeyPair.
            /// Important If you do not specify a key pair, you can&#39;t connect to the instance unless you choose an
            /// AMI that is configured to allow users another way to log in.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyName { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// The launch template to use to launch the instances. Any parameters that you specify 	in the AWS
            /// CloudFormation template override the same parameters in the launch template. You can specify either
            /// the name or ID of a launch template, but not both.
            /// Required: No
            /// Type: LaunchTemplateSpecification
            /// Update requires: Replacement
            /// </summary>
			public LaunchTemplateSpecification LaunchTemplate { get; set; }

            /// <summary>
            /// LicenseSpecifications
            /// The license configurations.
            /// Required: No
            /// Type: List of LicenseSpecification
            /// Update requires: Replacement
            /// </summary>
			public List<LicenseSpecification> LicenseSpecifications { get; set; }

            /// <summary>
            /// Monitoring
            /// Specifies whether detailed monitoring is enabled for the instance.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Monitoring { get; set; }

            /// <summary>
            /// NetworkInterfaces
            /// 	
            /// The network interfaces to associate with the instance.
            /// 	
            /// Note If you use this property to point to a network interface, you must terminate the original
            /// 			interface before attaching a new one to allow the update of the instance to succeed. If this
            /// resource has a public IP address and is also in a VPC that is defined in the same 		 template, you
            /// must use the 		 DependsOn Attribute to declare a dependency on the VPC-gateway 			attachment.
            /// 	
            /// Required: No
            /// Type: List of NetworkInterface
            /// Update requires: Replacement
            /// </summary>
			public List<NetworkInterface> NetworkInterfaces { get; set; }

            /// <summary>
            /// PlacementGroupName
            /// 	
            /// The name of an existing placement group that you want to launch the instance into (for cluster
            /// instances).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroupName { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// [EC2-VPC] The primary IPv4 address. You must specify a value from the IPv4 address range of the
            /// subnet.
            /// Only one private IP address can be designated as primary. You can&#39;t specify this option if you&#39;ve
            /// specified the option to designate a private IP address as the primary IP address in a network
            /// interface specification. You cannot specify this option if you&#39;re launching more than one instance
            /// in the request.
            /// 	
            /// You cannot specify this option and the network interfaces option in the same request.
            /// 	
            /// If you make an update to an instance that requires replacement, you must assign a new private 			IP
            /// address. During a replacement, AWS CloudFormation creates a new instance but doesn&#39;t delete 			the
            /// old instance until the stack has successfully updated. If the stack update fails, AWS
            /// 			CloudFormation uses the old instance in order to roll back the stack to the previous working
            /// 			state. The old and new instances cannot have the same private IP address.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

            /// <summary>
            /// RamdiskId
            /// The ID of the RAM disk to select. Some kernels require additional drivers at launch. Check the
            /// kernel requirements for information about whether you need to specify a RAM disk. To find kernel
            /// requirements, go to the AWS Resource Center and search for the kernel ID.
            /// Important We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
            /// see PV-GRUB in the Amazon Elastic Compute Cloud User Guide.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> RamdiskId { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The IDs of the security groups. You can create a security group using CreateSecurityGroup.
            /// If you specify a network interface, you must specify any security groups as part of the network
            /// interface.
            /// Required: Conditional
            /// Type: List of String
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SecurityGroups
            /// [EC2-Classic, default VPC] The names of the security groups. For a nondefault VPC, 	you must use
            /// security group IDs instead.
            /// 	
            /// You cannot specify this option and the network interfaces option in the same request. The 		list can
            /// contain both the name of existing Amazon EC2 security groups or references to
            /// 		AWS::EC2::SecurityGroup resources created in the template.
            /// Default: Amazon EC2 uses the default security group.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// SourceDestCheck
            /// Specifies whether to enable an instance launched in a VPC to perform NAT. This controls whether
            /// source/destination checking is enabled on the instance. A value of true means that checking is
            /// enabled, and false means that checking is disabled. The value must be false for the instance to
            /// perform NAT. For more information, see NAT Instances in the Amazon Virtual Private Cloud User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            /// SsmAssociations
            /// 	
            /// The SSM 		document and parameter values in AWS Systems Manager to associate with this instance. To
            /// use this 		property, you must specify an IAM instance profile role for the instance. For more
            /// information, see 		 			Create an Instance Profile for Systems Manager in the AWS Systems Manager
            /// User 				Guide.
            /// 		 		
            /// Note You can currently associate only one document with an instance.
            /// Required: No
            /// Type: List of SsmAssociation
            /// Update requires: No interruption
            /// </summary>
			public List<SsmAssociation> SsmAssociations { get; set; }

            /// <summary>
            /// SubnetId
            /// [EC2-VPC] The ID of the subnet to launch the instance into.
            /// You cannot specify this option and the network interfaces option in the same request.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply to the resources during launch. You can only tag instances and volumes on launch.
            /// The specified tags are applied to all instances or volumes that are created during launch. To tag a
            /// resource after it has been created, see CreateTags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Tenancy
            /// The tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of
            /// dedicated runs on single-tenant hardware. The host tenancy is not supported for the ImportInstance
            /// command.
            /// Required: No
            /// Type: String
            /// Allowed Values: dedicated | default | host
            /// </summary>
			public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            /// UserData
            /// The user data to make available to the instance. For more information, see Running Commands on Your
            /// Linux Instance at Launch (Linux) and Adding User Data (Windows). If you are using a command line
            /// tool, base64-encoding is performed for you, and you can load the text from a file. Otherwise, you
            /// must provide base64-encoded text. User data is limited to 16 KB.
            /// Required: No
            /// Type: String
            /// </summary>
			public Union<string, IntrinsicFunction> UserData { get; set; }

            /// <summary>
            /// Volumes
            /// The volumes to attach to the instance.
            /// Required: No
            /// Type: List of Volume
            /// Update requires: No interruption
            /// </summary>
			public List<Volume> Volumes { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Instance";

        public InstanceProperties Properties { get; } = new InstanceProperties();

        /// <summary>
        /// Associate the CreationPolicy attribute with a resource to prevent its status from reaching create complete until AWS CloudFormation receives
        /// a specified number of success signals or the timeout period is exceeded. To signal a resource, you can use the cfn-signal helper script or 
        /// SignalResource API. AWS CloudFormation publishes valid signals to the stack events so that you track the number of signals sent.
        /// The creation policy is invoked only when AWS CloudFormation creates the associated resource.Currently, the only AWS CloudFormation resources 
        /// that support creation policies are AWS::AutoScaling::AutoScalingGroup, AWS::EC2::Instance, and AWS::CloudFormation::WaitCondition.
        /// Use the CreationPolicy attribute when you want to wait on resource configuration actions before stack creation proceeds. For example, if you 
        /// install and configure software applications on an EC2 instance, you might want those applications to be running before proceeding. In such 
        /// cases, you can add a CreationPolicy attribute to the instance, and then send a success signal to the instance after the applications are 
        /// installed and configured.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-creationpolicy.html
        /// </summary>
        public CreationPolicy CreationPolicy { get; set; }

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
