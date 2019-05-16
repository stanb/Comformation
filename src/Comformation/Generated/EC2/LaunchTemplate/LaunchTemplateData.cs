using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate LaunchTemplateData
    /// The information to include in the launch template.
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
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// TagSpecifications
        /// The tags to apply to the resources during launch. You can only tag instances and volumes on launch.
        /// The specified tags are applied to all instances or volumes that are created during launch. To tag a
        /// resource after it has been created, see CreateTags.
        /// Required: No
        /// Type: List of TagSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public List<TagSpecification> TagSpecifications { get; set; }

        /// <summary>
        /// UserData
        /// The Base64-encoded user data to make available to the instance. For more information, see Running
        /// Commands on Your Linux Instance at Launch (Linux) and Adding User Data (Windows).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserData")]
        public Union<string, IntrinsicFunction> UserData { get; set; }

        /// <summary>
        /// BlockDeviceMappings
        /// 		
        /// The block device mapping.
        /// 	
        /// Required: No
        /// Type: List of BlockDeviceMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDeviceMappings")]
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

        /// <summary>
        /// IamInstanceProfile
        /// The IAM instance profile.
        /// Required: No
        /// Type: IamInstanceProfile
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamInstanceProfile")]
        public IamInstanceProfile IamInstanceProfile { get; set; }

        /// <summary>
        /// KernelId
        /// The ID of the kernel.
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information, see User
        /// Provided Kernels in the Amazon Elastic Compute Cloud User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KernelId")]
        public Union<string, IntrinsicFunction> KernelId { get; set; }

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
        /// ElasticGpuSpecifications
        /// An elastic GPU to associate with the instance.
        /// Required: No
        /// Type: List of ElasticGpuSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElasticGpuSpecifications")]
        public List<ElasticGpuSpecification> ElasticGpuSpecifications { get; set; }

        /// <summary>
        /// ElasticInferenceAccelerators
        /// The elastic inference accelerator for the instance.
        /// Required: No
        /// Type: List of LaunchTemplateElasticInferenceAccelerator
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElasticInferenceAccelerators")]
        public List<LaunchTemplateElasticInferenceAccelerator> ElasticInferenceAccelerators { get; set; }

        /// <summary>
        /// Placement
        /// The placement for the instance.
        /// Required: No
        /// Type: Placement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement { get; set; }

        /// <summary>
        /// NetworkInterfaces
        /// One or more network interfaces. If you specify a network interface, you must specify any security
        /// groups as part of the network interface.
        /// Required: No
        /// Type: List of NetworkInterface
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public List<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>
        /// ImageId
        /// 	
        /// The ID of the AMI, which you can get by using DescribeImages.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageId")]
        public Union<string, IntrinsicFunction> ImageId { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type. For more information, see Instance Types in the Amazon Elastic Compute Cloud User
        /// Guide.
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
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// Monitoring
        /// The monitoring for the instance.
        /// Required: No
        /// Type: Monitoring
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Monitoring")]
        public Monitoring Monitoring { get; set; }

        /// <summary>
        /// HibernationOptions
        /// Indicates whether an instance is enabled for hibernation. This parameter is valid only if the
        /// instance meets the hibernation prerequisites. Hibernation is currently supported only for Amazon
        /// Linux. For more information, see Hibernate Your Instance in the Amazon Elastic Compute Cloud User
        /// Guide.
        /// Required: No
        /// Type: HibernationOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HibernationOptions")]
        public HibernationOptions HibernationOptions { get; set; }

        /// <summary>
        /// LicenseSpecifications
        /// The license configurations.
        /// Required: No
        /// Type: List of LicenseSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseSpecifications")]
        public List<LicenseSpecification> LicenseSpecifications { get; set; }

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
        [JsonProperty("InstanceInitiatedShutdownBehavior")]
        public Union<string, IntrinsicFunction> InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// CpuOptions
        /// 		
        /// The CPU options for the instance. For more information, see Optimizing CPU Options in the Amazon
        /// Elastic Compute Cloud User 				Guide.
        /// 	
        /// Required: No
        /// Type: CpuOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CpuOptions")]
        public CpuOptions CpuOptions { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// 	
        /// One or more security group IDs. You can create a security group using CreateSecurityGroup. You
        /// cannot specify both a security group ID and security name in the same request.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// KeyName
        /// 	
        /// The name of the key pair. You can create a key pair using CreateKeyPair or ImportKeyPair.
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
        /// If set to true, you can&#39;t terminate the instance using the Amazon EC2 console, CLI, or API. To
        /// change this attribute to false after launch, use 	 		ModifyInstanceAttribute.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public Union<bool, IntrinsicFunction> DisableApiTermination { get; set; }

        /// <summary>
        /// InstanceMarketOptions
        /// The market (purchasing) option for the instances.
        /// Required: No
        /// Type: InstanceMarketOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptions InstanceMarketOptions { get; set; }

        /// <summary>
        /// RamDiskId
        /// The ID of the RAM disk.
        /// Important We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see User Provided Kernels in the Amazon Elastic Compute Cloud User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RamDiskId")]
        public Union<string, IntrinsicFunction> RamDiskId { get; set; }

        /// <summary>
        /// CapacityReservationSpecification
        /// 		
        /// The Capacity Reservation targeting option. If you do not specify this parameter, the 			instance&#39;s
        /// Capacity Reservation preference defaults to open, which enables it 			to run in any open Capacity
        /// Reservation that has matching attributes (instance type, 			platform, Availability Zone).
        /// 	
        /// Required: No
        /// Type: CapacityReservationSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationSpecification")]
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// CreditSpecification
        /// The credit option for CPU usage of the instance. Valid for T2 or T3 instances only.
        /// Required: No
        /// Type: CreditSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreditSpecification")]
        public CreditSpecification CreditSpecification { get; set; }

    }
}
