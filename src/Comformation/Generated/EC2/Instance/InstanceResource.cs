using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance
    /// The AWS::EC2::Instance resource creates an EC2 instance.
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
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances Update requires: Replacement for
            /// instance store-backed instances
            /// </summary>
			public Union<string, IntrinsicFunction> AdditionalInfo { get; set; }

            /// <summary>
            /// Affinity
            /// Indicates whether Amazon Elastic Compute Cloud (Amazon EC2) always associates the instance with a
            /// dedicated host. If you want Amazon EC2 to always restart the instance (if it was stopped) onto the
            /// same host on which it was launched, specify host. If you want Amazon EC2 to restart the instance on
            /// any available host, but to try to launch the instance onto the last host it ran on (on a best-effort
            /// basis), specify default.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Affinity { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// Specifies the name of the Availability Zone in which the instance is located.
            /// For more information about AWS regions and Availability Zones, see Regions and Availability Zones in
            /// the Amazon EC2 User Guide.
            /// Required: No. If not specified, an Availability Zone will be automatically chosen for you based on
            /// the load balancing criteria for the region.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// Defines a set of Amazon Elastic Block Store block device mappings, ephemeral instance store block
            /// device mappings, or both. For more information, see Amazon Elastic Block Store or Amazon EC2
            /// Instance Store in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: A list of Amazon EC2 Block Device Mapping Property.
            /// Update requires: Replacement. If you change only the DeleteOnTermination property for one or more
            /// block devices, update requires No interruption.
            /// </summary>
			public Union<List<BlockDeviceMapping>, IntrinsicFunction> BlockDeviceMappings { get; set; }

            /// <summary>
            /// CreditSpecification
            /// Specifies the credit option for CPU usage of a T2 instance.
            /// Required: No
            /// Type: Amazon EC2 Instance CreditSpecification.
            /// Update requires: No interruption
            /// </summary>
			public Union<CreditSpecification, IntrinsicFunction> CreditSpecification { get; set; }

            /// <summary>
            /// DisableApiTermination
            /// Specifies whether the instance can be terminated through the API.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableApiTermination { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Specifies whether the instance is optimized for Amazon Elastic Block Store I/O. This optimization
            /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to provide optimal
            /// EBS I/O performance.
            /// For more information about the instance types that can be launched as Amazon EBS optimized
            /// instances, see Amazon EBS-Optimized Instances in the Amazon Elastic Compute Cloud User Guide.
            /// Additional fees are incurred when using Amazon EBS-optimized instances.
            /// Required: No. By default, AWS CloudFormation specifies false.
            /// Type: Boolean
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances Update requires: Replacement for
            /// instance store-backed instances
            /// </summary>
			public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// ElasticGpuSpecifications
            /// Specifies the Elastic GPUs. An Elastic GPU is a GPU resource that you can attach to your instance to
            /// accelerate the graphics performance of your applications. For more information, see Amazon EC2
            /// Elastic GPUs in the Amazon EC2 User Guide for Windows Instances. Duplicates are not allowed.
            /// Required: No
            /// Type: List of Amazon EC2 Instance ElasticGpuSpecification
            /// Update requires: Replacement
            /// </summary>
			public Union<List<ElasticGpuSpecification>, IntrinsicFunction> ElasticGpuSpecifications { get; set; }

            /// <summary>
            /// HostId
            /// If you specify host for the Affinity property, the ID of a dedicated host that the instance is
            /// associated with. If you don't specify an ID, Amazon EC2 launches the instance onto any available,
            /// compatible dedicated host in your account. This type of launch is called an untargeted launch. Note
            /// that for untargeted launches, you must have a compatible, dedicated host available to successfully
            /// launch instances.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HostId { get; set; }

            /// <summary>
            /// IamInstanceProfile
            /// The name of an instance profile or a reference to an AWS::IAM::InstanceProfile resource.
            /// For more information about IAM roles, see Working with Roles in the AWS Identity and Access
            /// Management User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IamInstanceProfile { get; set; }

            /// <summary>
            /// ImageId
            /// Provides the unique ID of the Amazon Machine Image (AMI) that was assigned during registration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ImageId { get; set; }

            /// <summary>
            /// InstanceInitiatedShutdownBehavior
            /// Indicates whether an instance stops or terminates when you shut down the instance from the
            /// instance's operating system shutdown command. You can specify stop or terminate. For more
            /// information, see the RunInstances command in the Amazon EC2 API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceInitiatedShutdownBehavior { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type, such as t2. micro. The default type is "m3. medium". For a list of instance
            /// types, see Instance Families and Types.
            /// Required: No
            /// Type: String
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances Update requires: Replacement for
            /// instance store-backed instances
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Ipv6AddressCount
            /// The number of IPv6 addresses to associate with the instance's primary network interface. Amazon EC2
            /// automatically selects the IPv6 addresses from the subnet range. To specify specific IPv6 addresses,
            /// use the Ipv6Addresses property and don't specify this property.
            /// For restrictions on which instance types support IPv6 addresses, see the RunInstances action in the
            /// Amazon EC2 API Reference.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Ipv6AddressCount { get; set; }

            /// <summary>
            /// Ipv6Addresses
            /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with
            /// the instance's primary network interface. To specify a number of IPv6 addresses, use the
            /// Ipv6AddressCount property and don't specify this property.
            /// For information about restrictions on which instance types support IPv6 addresses, see the
            /// RunInstances action in the Amazon EC2 API Reference.
            /// Required: No
            /// Type: List of EC2 NetworkInterface Ipv6Addresses
            /// Update requires: Replacement
            /// </summary>
			public Union<List<InstanceIpv6Address>, IntrinsicFunction> Ipv6Addresses { get; set; }

            /// <summary>
            /// KernelId
            /// The kernel ID.
            /// Required: No
            /// Type: String
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances Update requires: Replacement for
            /// instance store-backed instances
            /// </summary>
			public Union<string, IntrinsicFunction> KernelId { get; set; }

            /// <summary>
            /// KeyName
            /// Provides the name of the Amazon EC2 key pair.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyName { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// The launch template to use.
            /// Required: No
            /// Type: Amazon EC2 Instance LaunchTemplateSpecification
            /// Update requires: Replacement
            /// </summary>
			public Union<LaunchTemplateSpecification, IntrinsicFunction> LaunchTemplate { get; set; }

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
            /// A list of embedded objects that describes the network interfaces to associate with this instance.
            /// Note If you use this property to point to a network interface, you must terminate the original
            /// interface before attaching a new one to allow the update of the instance to succeed. If this
            /// resource has a public IP address and is also in a VPC that is defined in the same template, you must
            /// use the DependsOn attribute to declare a dependency on the VPC-gateway attachment. For more
            /// information, see DependsOn Attribute.
            /// Required: No
            /// Type: A list of EC2 NetworkInterface Embedded Property Type
            /// Update requires: Replacement
            /// </summary>
			public Union<List<NetworkInterface>, IntrinsicFunction> NetworkInterfaces { get; set; }

            /// <summary>
            /// PlacementGroupName
            /// The name of an existing placement group that you want to launch the instance into (for cluster
            /// instances).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroupName { get; set; }

            /// <summary>
            /// PrivateIpAddress
            /// The private IP address for this instance.
            /// Important If you make an update to an instance that requires replacement, you must assign a new
            /// private IP address. During a replacement, AWS CloudFormation creates a new instance but doesn't
            /// delete the old instance until the stack has successfully updated. If the stack update fails, AWS
            /// CloudFormation uses the old instance in order to roll back the stack to the previous working state.
            /// The old and new instances cannot have the same private IP address.
            /// (Optional) If you're using Amazon VPC, you can use this parameter to assign the instance a specific
            /// available IP address from the subnet (for example, 10. 0. 0. 25). By default, Amazon VPC selects an
            /// IP address from the subnet for the instance.
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
            /// Required: No
            /// Type: String
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances Update requires: Replacement for
            /// instance store-backed instances
            /// </summary>
			public Union<string, IntrinsicFunction> RamdiskId { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list that contains the security group IDs for VPC security groups to assign to the Amazon EC2
            /// instance. If you specified the NetworkInterfaces property, do not specify this property.
            /// Required: Conditional. Required for VPC security groups.
            /// Type: List of String values
            /// Update requires:
            /// Update requires: No interruption for instances that are in a VPC. Update requires: Replacement for
            /// instances that are not in a VPC.
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            /// SecurityGroups
            /// Valid only for Amazon EC2 security groups. A list that contains the Amazon EC2 security groups to
            /// assign to the Amazon EC2 instance. The list can contain both the name of existing Amazon EC2
            /// security groups or references to AWS::EC2::SecurityGroup resources created in the template.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement.
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            /// SourceDestCheck
            /// Controls whether source/destination checking is enabled on the instance. Also determines if an
            /// instance in a VPC will perform network address translation (NAT).
            /// A value of "true" means that source/destination checking is enabled, and a value of "false" means
            /// that checking is disabled. For the instance to perform NAT, the value must be "false". For more
            /// information, see NAT Instances in the Amazon Virtual Private Cloud User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> SourceDestCheck { get; set; }

            /// <summary>
            /// SsmAssociations
            /// The SSM document and parameter values in AWS Systems Manager to associate with this instance. To use
            /// this property, you must specify an IAM instance profile role for the instance. For more information,
            /// see Create an Instance Profile for Systems Manager in the AWS Systems Manager User Guide.
            /// Note You can currently associate only one document with an instance.
            /// Required: No
            /// Type: List of Amazon EC2 Instance SsmAssociations.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<SsmAssociation>, IntrinsicFunction> SsmAssociations { get; set; }

            /// <summary>
            /// SubnetId
            /// If you're using Amazon VPC, this property specifies the ID of the subnet that you want to launch the
            /// instance into. If you specified the NetworkInterfaces property, do not specify this property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this instance.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Tenancy
            /// The tenancy of the instance that you want to launch, such as default, dedicated, or host. If you
            /// specify a tenancy value of dedicated or host, you must launch the instance in a VPC. For more
            /// information, see Dedicated Instances in the Amazon VPC User Guide.
            /// Required: No
            /// Type: String
            /// Update requires:
            /// Update requires: No interruption if this property was set to dedicated and you change it to host or
            /// vice versa. Update requires: Replacement for all other changes.
            /// </summary>
			public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            /// UserData
            /// Base64-encoded MIME user data that is made available to the instances.
            /// Required: No
            /// Type: String
            /// Update requires:
            /// Update requires: Some interruptions for Amazon EBS-backed instances. Note For EBS-backed instances,
            /// changing the UserData stops and then starts the instance; however, Amazon EC2 doesn't automatically
            /// run the updated UserData. To update configurations on your instance, use the cfn-hup helper script.
            /// Update requires: Replacement for instance store-backed instances.
            /// </summary>
			public Union<string, IntrinsicFunction> UserData { get; set; }

            /// <summary>
            /// Volumes
            /// The Amazon EBS volumes to attach to the instance.
            /// Note Before detaching a volume, unmount any file systems on the device within your operating system.
            /// If you don't unmount the file system, a volume might get stuck in a busy state while detaching.
            /// Required: No
            /// Type: A list of EC2 MountPoints.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Volume>, IntrinsicFunction> Volumes { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Instance";
        
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
