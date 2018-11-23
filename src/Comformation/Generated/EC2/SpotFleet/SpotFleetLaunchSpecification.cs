using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications
    /// LaunchSpecifications is a property of the Amazon EC2 SpotFleet SpotFleetRequestConfigData property that
    /// defines the launch specifications for the Spot fleet request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html
    /// </summary>
    public class SpotFleetLaunchSpecification
    {

        /// <summary>
        /// BlockDeviceMappings
        /// Defines the block devices that are mapped to the Spot instances.
        /// Required: No
        /// Type: List of Amazon Elastic Compute Cloud SpotFleet BlockDeviceMappings
        /// </summary>
        [JsonProperty("BlockDeviceMappings")]
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether the instances are optimized for Amazon Elastic Block Store (Amazon EBS) I/O. This
        /// optimization provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal EBS I/O performance. This optimization isn&#39;t available with all instance types.
        /// Additional usage charges apply when you use an Amazon EBS-optimized instance.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

        /// <summary>
        /// IamInstanceProfile
        /// Defines the AWS Identity and Access Management (IAM) instance profile to associate with the
        /// instances.
        /// Required: No
        /// Type: Amazon Elastic Compute Cloud SpotFleet IamInstanceProfile
        /// </summary>
        [JsonProperty("IamInstanceProfile")]
        public IamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// ImageId
        /// The unique ID of the Amazon Machine Image (AMI) to launch on the instances.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ImageId")]
        public Union<string, IntrinsicFunction> ImageId { get; set; }

        /// <summary>
        /// InstanceType
        /// Specifies the instance type of the EC2 instances.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// KernelId
        /// The ID of the kernel that is associated with the Amazon Elastic Compute Cloud (Amazon EC2) AMI.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("KernelId")]
        public Union<string, IntrinsicFunction> KernelId { get; set; }

        /// <summary>
        /// KeyName
        /// An Amazon EC2 key pair to associate with the instances.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("KeyName")]
        public Union<string, IntrinsicFunction> KeyName { get; set; }

        /// <summary>
        /// Monitoring
        /// Enable or disable monitoring for the instances.
        /// Required: No
        /// Type: Amazon EC2 SpotFleet Monitoring
        /// </summary>
        [JsonProperty("Monitoring")]
        public SpotFleetMonitoring Monitoring { get; set; }

        /// <summary>
        /// NetworkInterfaces
        /// The network interfaces to associate with the instances.
        /// Required: No
        /// Type: List of Amazon Elastic Compute Cloud SpotFleet NetworkInterfaces
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; }

        /// <summary>
        /// Placement
        /// Defines a placement group, which is a logical grouping of instances within a single Availability
        /// Zone (AZ).
        /// Required: No
        /// Type: Amazon Elastic Compute Cloud SpotFleet Placement
        /// </summary>
        [JsonProperty("Placement")]
        public SpotPlacement Placement { get; set; }

        /// <summary>
        /// RamdiskId
        /// The ID of the RAM disk to select. Some kernels require additional drivers at launch. Check the
        /// kernel requirements for information about whether you need to specify a RAM disk. To find kernel
        /// requirements, refer to the AWS Resource Center and search for the kernel ID.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RamdiskId")]
        public Union<string, IntrinsicFunction> RamdiskId { get; set; }

        /// <summary>
        /// SecurityGroups
        /// One or more security group IDs to associate with the instances.
        /// Required: No
        /// Type: List of Amazon Elastic Compute Cloud SpotFleet SecurityGroups
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<GroupIdentifier> SecurityGroups { get; set; }

        /// <summary>
        /// SpotPrice
        /// The bid price per unit hour for the specified instance type. If you don&#39;t specify a value, Amazon
        /// EC2 uses the Spot bid price for the fleet. For more information, see How Spot Fleet Works in the
        /// Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SpotPrice")]
        public Union<string, IntrinsicFunction> SpotPrice { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet in which to launch the instances.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

        /// <summary>
        /// TagSpecifications
        /// The tags to apply during creation.
        /// Required: No
        /// Type: List of SpotFleetTagSpecification
        /// </summary>
        [JsonProperty("TagSpecifications")]
        public List<SpotFleetTagSpecification> TagSpecifications { get; set; }

        /// <summary>
        /// UserData
        /// Base64-encoded MIME user data that instances use when starting up.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("UserData")]
        public Union<string, IntrinsicFunction> UserData { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of units provided by the specified instance type. These units are the same units that you
        /// chose to set the target capacity in terms of instances or a performance characteristic, such as
        /// vCPUs, memory, or I/O. For more information, see How Spot Fleet Works in the Amazon EC2 User Guide
        /// for Linux Instances.
        /// If the target capacity divided by this value is not a whole number, Amazon EC2 rounds the number of
        /// instances to the next whole number.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<double, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
