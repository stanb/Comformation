using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration
    /// Creates an Auto Scaling launch configuration that can be used by an Auto Scaling group to configure Auto
    /// Scaling instances.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html
    /// </summary>
    public class LaunchConfigurationResource : ResourceBase
    {
        public class LaunchConfigurationProperties
        {
            /// <summary>
            /// AssociatePublicIpAddress
            /// For Amazon EC2 instances in a VPC, indicates whether instances in the Auto Scaling group receive
            /// public IP addresses. If you specify true, each instance in the Auto Scaling receives a unique public
            /// IP address.
            /// Note If this resource has a public IP address and is also in a VPC that is defined in the same
            /// template, you must use the DependsOn attribute to declare a dependency on the VPC-gateway
            /// attachment. For more information, see DependsOn Attribute.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cf-as-launchconfig-associatepubip
            /// </summary>
			public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// Specifies how block devices are exposed to the instance. You can specify virtual devices and EBS
            /// volumes.
            /// Required: No
            /// Type: A list of BlockDeviceMappings.
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-blockdevicemappings
            /// </summary>
			public Union<List<BlockDeviceMapping>, IntrinsicFunction> BlockDeviceMappings { get; set; }

            /// <summary>
            /// ClassicLinkVPCId
            /// The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to. You can specify this
            /// property only for EC2-Classic instances. For more information, see ClassicLink in the Amazon Elastic
            /// Compute Cloud User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcid
            /// </summary>
			public Union<string, IntrinsicFunction> ClassicLinkVPCId { get; set; }

            /// <summary>
            /// ClassicLinkVPCSecurityGroups
            /// The IDs of one or more security groups for the VPC that you specified in the ClassicLinkVPCId
            /// property.
            /// Required: Conditional. If you specified the ClassicLinkVPCId property, you must specify this
            /// property.
            /// Type: List of String values
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcsecuritygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ClassicLinkVPCSecurityGroups { get; set; }

            /// <summary>
            /// EbsOptimized
            /// Specifies whether the launch configuration is optimized for EBS I/O. This optimization provides
            /// dedicated throughput to Amazon EBS and an optimized configuration stack to provide optimal EBS I/O
            /// performance.
            /// Additional fees are incurred when using EBS-optimized instances. For more information about fees and
            /// supported instance types, see EBS-Optimized Instances in the Amazon EC2 User Guide for Linux
            /// Instances.
            /// Required: No If this property is not specified, "false" is used.
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ebsoptimized
            /// </summary>
			public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

            /// <summary>
            /// IamInstanceProfile
            /// Provides the name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM
            /// role for the instance. The instance profile contains the IAM role.
            /// Required: No
            /// Type: String (1–1600 chars)
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-iaminstanceprofile
            /// </summary>
			public Union<string, IntrinsicFunction> IamInstanceProfile { get; set; }

            /// <summary>
            /// ImageId
            /// Provides the unique ID of the Amazon Machine Image (AMI) that was assigned during registration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-imageid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// InstanceMonitoring
            /// Indicates whether detailed instance monitoring is enabled for the Auto Scaling group. By default,
            /// this property is set to true (enabled).
            /// When detailed monitoring is enabled, Amazon CloudWatch (CloudWatch) generates metrics every minute
            /// and your account is charged a fee. When you disable detailed monitoring, CloudWatch generates
            /// metrics every 5 minutes. For more information, see Monitor Your Auto Scaling Groups and Instances
            /// Using Amazon CloudWatch in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancemonitoring
            /// </summary>
			public Union<bool, IntrinsicFunction> InstanceMonitoring { get; set; }

            /// <summary>
            /// InstanceType
            /// Specifies the instance type of the EC2 instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancetype
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// KernelId
            /// Provides the ID of the kernel associated with the EC2 AMI.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-kernelid
            /// </summary>
			public Union<string, IntrinsicFunction> KernelId { get; set; }

            /// <summary>
            /// KeyName
            /// Provides the name of the EC2 key pair.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-keyname
            /// </summary>
			public Union<string, IntrinsicFunction> KeyName { get; set; }

            /// <summary>
            /// LaunchConfigurationName
            /// The name of the launch configuration. This name must be unique within the scope of your AWS account.
            /// Length Constraints: Minimum length of 1. Maximum length of 255.
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-autoscaling-launchconfig-launchconfigurationname
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            /// PlacementTenancy
            /// The tenancy of the instance. An instance with a tenancy of dedicated runs on single-tenant hardware
            /// and can only be launched in a VPC. You must set the value of this parameter to dedicated if want to
            /// launch dedicated instances in a shared tenancy VPC (a VPC with the instance placement tenancy
            /// attribute set to default). For more information, see CreateLaunchConfiguration in the Amazon EC2
            /// Auto Scaling API Reference.
            /// If you specify this property, you must specify at least one subnet in the VPCZoneIdentifier property
            /// of the AWS::AutoScaling::AutoScalingGroup resource.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-placementtenancy
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementTenancy { get; set; }

            /// <summary>
            /// RamDiskId
            /// The ID of the RAM disk to select. Some kernels require additional drivers at launch. Check the
            /// kernel requirements for information about whether you need to specify a RAM disk. To find kernel
            /// requirements, refer to the AWS Resource Center and search for the kernel ID.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ramdiskid
            /// </summary>
			public Union<string, IntrinsicFunction> RamDiskId { get; set; }

            /// <summary>
            /// SecurityGroups
            /// A list that contains the EC2 security groups to assign to the instances in the Auto Scaling group.
            /// The list can contain the IDs of existing EC2 security groups or references to
            /// AWS::EC2::SecurityGroup resources created in the template.
            /// Required: No
            /// Type: A list of security groups.
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-securitygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            /// SpotPrice
            /// The spot price for this Auto Scaling group. If a spot price is set, then the Auto Scaling group will
            /// launch when the current spot price is less than the amount specified in the template.
            /// When you have specified a spot price for an auto scaling group, the group will only launch when the
            /// spot price has been met, regardless of the setting in the Auto Scaling group's DesiredCapacity.
            /// For more information about configuring a spot price for an Auto Scaling group, see Launching Spot
            /// Instances in your Auto Scaling Group in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// Note When you change your bid price by creating a new launch configuration, running instances will
            /// continue to run as long as the bid price for those running instances is higher than the current Spot
            /// price.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-spotprice
            /// </summary>
			public Union<string, IntrinsicFunction> SpotPrice { get; set; }

            /// <summary>
            /// UserData
            /// The user data available to the launched EC2 instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-userdata
            /// </summary>
			public Union<string, IntrinsicFunction> UserData { get; set; }

        }
    
        public string Type { get; } = "AWS::AutoScaling::LaunchConfiguration";
        
        public LaunchConfigurationProperties Properties { get; } = new LaunchConfigurationProperties();
    }
}
