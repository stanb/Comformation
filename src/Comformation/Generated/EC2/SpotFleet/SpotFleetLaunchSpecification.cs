using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotFleetLaunchSpecification
    /// Specifies the launch specification for one or more Spot Instances. If you include On-Demand capacity in your
    /// fleet request, you can&#39;t use SpotFleetLaunchSpecification; you must use LaunchTemplateConfig.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html
    /// </summary>
    public class SpotFleetLaunchSpecification
    {

        /// <summary>
        /// BlockDeviceMappings
        /// One or more block devices that are mapped to the Spot instances. You can&#39;t specify both a snapshot
        /// ID and an encryption value. This is because only blank volumes can be encrypted on creation. If a
        /// snapshot is the basis for a volume, it is not blank and its encryption status is used for the volume
        /// encryption status.
        /// Required: No
        /// Type: List of BlockDeviceMapping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDeviceMappings")]
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether the instances are optimized for EBS I/O. This optimization provides dedicated
        /// throughput to Amazon EBS and an optimized configuration stack to provide optimal EBS I/O
        /// performance. This optimization isn&#39;t available with all instance types. Additional usage charges
        /// apply when using an EBS Optimized instance.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

        /// <summary>
        /// IamInstanceProfile
        /// The IAM instance profile.
        /// Required: No
        /// Type: IamInstanceProfileSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamInstanceProfile")]
        public IamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// ImageId
        /// The ID of the AMI.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageId")]
        public Union<string, IntrinsicFunction> ImageId { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type.
        /// Required: Yes
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
        /// KernelId
        /// The ID of the kernel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KernelId")]
        public Union<string, IntrinsicFunction> KernelId { get; set; }

        /// <summary>
        /// KeyName
        /// The name of the key pair.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyName")]
        public Union<string, IntrinsicFunction> KeyName { get; set; }

        /// <summary>
        /// Monitoring
        /// Enable or disable monitoring for the instances.
        /// Required: No
        /// Type: SpotFleetMonitoring
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Monitoring")]
        public SpotFleetMonitoring Monitoring { get; set; }

        /// <summary>
        /// NetworkInterfaces
        /// One or more network interfaces. If you specify a network interface, you must specify subnet IDs and
        /// security group IDs using the network interface.
        /// Required: No
        /// Type: List of InstanceNetworkInterfaceSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; }

        /// <summary>
        /// Placement
        /// The placement information.
        /// Required: No
        /// Type: SpotPlacement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Placement")]
        public SpotPlacement Placement { get; set; }

        /// <summary>
        /// RamdiskId
        /// The ID of the RAM disk. Some kernels require additional drivers at launch. Check the kernel
        /// requirements for information about whether you need to specify a RAM disk. To find kernel
        /// requirements, refer to the AWS Resource Center and search for the kernel ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RamdiskId")]
        public Union<string, IntrinsicFunction> RamdiskId { get; set; }

        /// <summary>
        /// SecurityGroups
        /// One or more security groups. When requesting instances in a VPC, you must specify the IDs of the
        /// security groups. When requesting instances in EC2-Classic, you can specify the names or the IDs of
        /// the security groups.
        /// Required: No
        /// Type: List of GroupIdentifier
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<GroupIdentifier> SecurityGroups { get; set; }

        /// <summary>
        /// SpotPrice
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. If this value is
        /// not specified, the default is the Spot price specified for the fleet. To determine the Spot price
        /// per unit hour, divide the Spot price by the value of WeightedCapacity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotPrice")]
        public Union<string, IntrinsicFunction> SpotPrice { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet in which to launch the instances. To specify multiple subnets, separate them
        /// using commas; for example, &quot;subnet-a61dafcf, subnet-65ea5f08&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

        /// <summary>
        /// TagSpecifications
        /// The tags to apply during creation.
        /// Required: No
        /// Type: List of SpotFleetTagSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public List<SpotFleetTagSpecification> TagSpecifications { get; set; }

        /// <summary>
        /// UserData
        /// The Base64-encoded user data that instances use when starting up.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserData")]
        public Union<string, IntrinsicFunction> UserData { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of units provided by the specified instance type. These are the same units that you chose
        /// to set the target capacity in terms of instances, or a performance characteristic such as vCPUs,
        /// memory, or I/O.
        /// If the target capacity divided by this value is not a whole number, Amazon EC2 rounds the number of
        /// instances to the next whole number. If this value is not specified, the default is 1.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<double, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
