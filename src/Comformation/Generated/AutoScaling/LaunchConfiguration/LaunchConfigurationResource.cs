using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html
    /// </summary>
    public class LaunchConfigurationResource : ResourceBase
    {
        public class LaunchConfigurationProperties
        {
            /// <summary>
            /// AssociatePublicIpAddress
            /// For Auto Scaling groups that are running in a virtual private cloud (VPC), specifies whether to
            /// assign a public IP address to the group&#39;s instances. If you specify true, each instance in the Auto
            /// Scaling group receives a unique public IP address. For more information, see Launching Auto Scaling
            /// instances in a VPC in the Amazon EC2 Auto Scaling User Guide.
            /// If an instance receives a public IP address and is also in a VPC that is defined in the same stack
            /// template, you must use the DependsOn attribute to declare a dependency on the VPC-gateway
            /// attachment.
            /// Note If the instance is launched into a default subnet, the default is to assign a public IP
            /// address, unless you disabled the option to assign a public IP address on the subnet. If the instance
            /// is launched into a nondefault subnet, the default is not to assign a public IP address, unless you
            /// enabled the option to assign a public IP address on the subnet.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// Specifies how block devices are exposed to the instance. You can specify virtual devices and EBS
            /// volumes.
            /// Required: No
            /// Type: List of BlockDeviceMapping
            /// Update requires: Replacement
            /// </summary>
            public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

            /// <summary>
            /// ClassicLinkVPCId
            /// The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to.
            /// For more information, see ClassicLink in the Amazon EC2 User Guide for Linux Instances and Linking
            /// EC2-Classic instances to a VPC in the Amazon EC2 Auto Scaling User Guide.
            /// This property can only be used if you are launching EC2-Classic instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClassicLinkVPCId { get; set; }

            /// <summary>
            /// ClassicLinkVPCSecurityGroups
            /// The IDs of one or more security groups for the VPC that you specified in the ClassicLinkVPCId
            /// property.
            /// If you specify the ClassicLinkVPCId property, you must specify this property.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ClassicLinkVPCSecurityGroups { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Specifies whether the launch configuration is optimized for EBS I/O (true) or not (false). This
            /// optimization provides dedicated throughput to Amazon EBS and an optimized configuration stack to
            /// provide optimal EBS I/O performance. Additional fees are incurred when you enable EBS optimization
            /// for an instance type that is not EBS-optimized by default. For more information, see Amazon
            /// EBS–optimized instances in the Amazon EC2 User Guide for Linux Instances.
            /// The default value is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// IamInstanceProfile
            /// Provides the name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM
            /// role for the instance. The instance profile contains the IAM role.
            /// For more information, see IAM role for applications that run on Amazon EC2 instances in the Amazon
            /// EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IamInstanceProfile { get; set; }

            /// <summary>
            /// ImageId
            /// Provides the unique ID of the Amazon Machine Image (AMI) that was assigned during registration. For
            /// more information, see Finding a Linux AMI in the Amazon EC2 User Guide for Linux Instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ImageId { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the Amazon EC2 instance you want to use to create the launch configuration. Use this
            /// property if you want the launch configuration to use settings from an existing Amazon EC2 instance.
            /// When you use an instance to create a launch configuration, all properties are derived from the
            /// instance with the exception of BlockDeviceMapping and AssociatePublicIpAddress. You can override any
            /// properties from the instance by specifying them in the launch configuration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// InstanceMonitoring
            /// Controls whether instances in this group are launched with detailed (true) or basic (false)
            /// monitoring. The default value is true (enabled).
            /// Important When detailed monitoring is enabled, Amazon CloudWatch generates metrics every minute and
            /// your account is charged a fee. When you disable detailed monitoring, CloudWatch generates metrics
            /// every 5 minutes. For more information, see Configure monitoring for Auto Scaling instances in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> InstanceMonitoring { get; set; }

            /// <summary>
            /// InstanceType
            /// Specifies the instance type of the EC2 instance. For information about available instance types, see
            /// Available instance types in the Amazon EC2 User Guide for Linux Instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// KernelId
            /// Provides the ID of the kernel associated with the EC2 AMI.
            /// Note We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information, see
            /// User provided kernels in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KernelId { get; set; }

            /// <summary>
            /// KeyName
            /// Provides the name of the EC2 key pair.
            /// Important If you do not specify a key pair, you can&#39;t connect to the instance unless you choose an
            /// AMI that is configured to allow users another way to log in. For information on creating a key pair,
            /// see Amazon EC2 key pairs and Linux instances in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyName { get; set; }

            /// <summary>
            /// LaunchConfigurationName
            /// The name of the launch configuration. This name must be unique per Region per account.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            /// MetadataOptions
            /// The metadata options for the instances. For more information, see Configuring the Instance Metadata
            /// Options in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: MetadataOptions
            /// Update requires: Replacement
            /// </summary>
            public MetadataOptions MetadataOptions { get; set; }

            /// <summary>
            /// PlacementTenancy
            /// The tenancy of the instance, either default or dedicated. An instance with dedicated tenancy runs on
            /// isolated, single-tenant hardware and can only be launched into a VPC. You must set the value of this
            /// property to dedicated if want to launch dedicated instances in a shared tenancy VPC (a VPC with the
            /// instance placement tenancy attribute set to default).
            /// If you specify this property, you must specify at least one subnet in the VPCZoneIdentifier property
            /// of the AWS::AutoScaling::AutoScalingGroup resource.
            /// For more information, see Configuring instance tenancy with Amazon EC2 Auto Scaling in the Amazon
            /// EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlacementTenancy { get; set; }

            /// <summary>
            /// RamDiskId
            /// The ID of the RAM disk to select.
            /// Note We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information, see
            /// User provided kernels in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RamDiskId { get; set; }

            /// <summary>
            /// SecurityGroups
            /// A list that contains the security groups to assign to the instances in the Auto Scaling group. The
            /// list can contain both the IDs of existing security groups and references to SecurityGroup resources
            /// created in the template.
            /// For more information, see Security groups for your VPC in the Amazon Virtual Private Cloud User
            /// Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// SpotPrice
            /// The maximum hourly price you are willing to pay for any Spot Instances launched to fulfill the
            /// request. Spot Instances are launched when the price you specify exceeds the current Spot price. For
            /// more information, see Requesting Spot Instances for fault-tolerant and flexible applications in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Note When you change your maximum price by creating a new launch configuration, running instances
            /// will continue to run as long as the maximum price for those running instances is higher than the
            /// current Spot price.
            /// Valid Range: Minimum value of 0. 001
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SpotPrice { get; set; }

            /// <summary>
            /// UserData
            /// The Base64-encoded user data to make available to the launched EC2 instances.
            /// For more information, see Instance metadata and user data in the Amazon EC2 User Guide for Linux
            /// Instances.
            /// Required: No
            /// Type: String
            /// Maximum: 21847
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserData { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::LaunchConfiguration";

        public LaunchConfigurationProperties Properties { get; } = new LaunchConfigurationProperties();

    }
}
