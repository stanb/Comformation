using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate LaunchTemplateData
    /// The LaunchTemplateData property type specifies the information to include the launch template for an Amazon
    /// EC2 instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html
    /// </summary>
    public class LaunchTemplateData
    {

        /// <summary>
        /// SecurityGroups
        /// [EC2-Classic, default VPC] One or more security group names. For a nondefault VPC, you must use
        /// security group IDs instead. You cannot specify both a security group ID and security name in the
        /// same request.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// TagSpecifications
        /// The tags to apply to the resources during launch. You can tag instances and volumes. The specified
        /// tags are applied to all instances or volumes that are created during launch.
        /// Required: No
        /// Type: List of Amazon EC2 LaunchTemplate TagSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public List<TagSpecification> TagSpecifications { get; set; }

        /// <summary>
        /// UserData
        /// The Base64-encoded user data to make available to the instance. For more information, see Running
        /// Commands on Your Linux Instance at Launch in the Amazon EC2 User Guide for Linux Instances and
        /// Adding User Data in the Amazon EC2 User Guide for Windows Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserData")]
        public Union<string, IntrinsicFunction> UserData { get; set; }

        /// <summary>
        /// InstanceInitiatedShutdownBehavior
        /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance
        /// (using the operating system command for system shutdown).
        /// Valid values include stop and terminate. The default is stop.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceInitiatedShutdownBehavior")]
        public Union<string, IntrinsicFunction> InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// BlockDeviceMappings
        /// The block device mapping.
        /// Required: No
        /// Type: List of Amazon EC2 LaunchTemplate BlockDeviceMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDeviceMappings")]
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

        /// <summary>
        /// IamInstanceProfile
        /// The IAM instance profile.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate IamInstanceProfile
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamInstanceProfile")]
        public IamInstanceProfile IamInstanceProfile { get; set; }

        /// <summary>
        /// KernelId
        /// The ID of the kernel.
        /// Important We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see User Provided Kernels in the Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KernelId")]
        public Union<string, IntrinsicFunction> KernelId { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// One or more security group IDs. You cannot specify both a security group ID and security name in the
        /// same request. For information on creating a security group, see CreateSecurityGroup in the Amazon
        /// EC2 API Reference.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization provides dedicated
        /// throughput to Amazon EBS and an optimized configuration stack to provide optimal Amazon EBS I/O
        /// performance. This optimization isn&#39;t available with all instance types. Additional usage charges
        /// apply when using an EBS-optimized instance.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

        /// <summary>
        /// KeyName
        /// The name of the key pair. For information on creating a key pair, see CreateKeyPair or ImportKeyPair
        /// in the Amazon EC2 API Reference.
        /// Important If you do not specify a key pair, you can&#39;t connect to the instance unless you choose an
        /// AMI that is configured to allow users another way to log in.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyName")]
        public Union<string, IntrinsicFunction> KeyName { get; set; }

        /// <summary>
        /// DisableApiTermination
        /// If set to true, you can&#39;t terminate the instance using the Amazon EC2 console, CLI, or API.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public Union<bool, IntrinsicFunction> DisableApiTermination { get; set; }

        /// <summary>
        /// ElasticGpuSpecifications
        /// An elastic GPU to associate with the instance.
        /// Required: No
        /// Type: List of Amazon EC2 LaunchTemplate ElasticGpuSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElasticGpuSpecifications")]
        public List<ElasticGpuSpecification> ElasticGpuSpecifications { get; set; }

        /// <summary>
        /// Placement
        /// The placement for the instance.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate Placement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement { get; set; }

        /// <summary>
        /// InstanceMarketOptions
        /// The market (purchasing) option for the instances.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate InstanceMarketOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptions InstanceMarketOptions { get; set; }

        /// <summary>
        /// NetworkInterfaces
        /// One or more network interfaces.
        /// Required: No
        /// Type: List of Amazon EC2 LaunchTemplate NetworkInterface
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public List<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>
        /// ImageId
        /// The ID of the AMI. For more information, see DescribeImages in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageId")]
        public Union<string, IntrinsicFunction> ImageId { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type. For a list of valid values, see RequestLaunchTemplateData in the Amazon EC2 API
        /// Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// RamDiskId
        /// The ID of the RAM disk.
        /// Important We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see User Provided Kernels in the Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RamDiskId")]
        public Union<string, IntrinsicFunction> RamDiskId { get; set; }

        /// <summary>
        /// Monitoring
        /// The monitoring for the instance.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate Monitoring
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Monitoring")]
        public Monitoring Monitoring { get; set; }

        /// <summary>
        /// CreditSpecification
        /// The credit option for CPU usage of the instance. Valid for T2 instances only.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate CreditSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreditSpecification")]
        public CreditSpecification CreditSpecification { get; set; }

    }
}
