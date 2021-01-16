using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration BlockDevice
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html
    /// </summary>
    public class BlockDevice
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether to delete the volume when the instance is terminated. For Amazon EC2 Auto Scaling,
        /// the default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Specifies whether the EBS volume is encrypted. Encrypted EBS volumes can only be attached to
        /// instances that support Amazon EBS encryption. For more information, see Supported instance types. If
        /// your AMI uses encrypted volumes, you can also only launch it on supported instance types.
        /// Note If you are creating a volume from a snapshot, you cannot specify an encryption value. Volumes
        /// that are created from encrypted snapshots are automatically encrypted, and volumes that are created
        /// from unencrypted snapshots are automatically unencrypted. By default, encrypted snapshots use the
        /// AWS managed CMK that is used for EBS encryption, but you can specify a custom CMK when you create
        /// the snapshot. The ability to encrypt a snapshot during copying also allows you to apply a new CMK to
        /// an already-encrypted snapshot. Volumes restored from the resulting copy are only accessible using
        /// the new CMK. Enabling encryption by default results in all EBS volumes being encrypted with the AWS
        /// managed CMK or a customer managed CMK, whether or not the snapshot was encrypted.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) to provision for the volume. The maximum ratio of
        /// IOPS to volume size (in GiB) is 50:1, so for 5,000 provisioned IOPS, you need at least 100 GiB
        /// storage on the volume. For more information, see Amazon EBS volume types in the Amazon EC2 User
        /// Guide for Linux Instances.
        /// If the volume type is io1, this property is required. (Not used with standard, gp2, st1, or sc1
        /// volumes. )
        /// Required: Conditional
        /// Type: Integer
        /// Minimum: 100
        /// Maximum: 20000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// The snapshot ID of the volume to use.
        /// You must specify either a VolumeSize or a SnapshotId.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// The volume size, in Gibibytes (GiB). This can be a number from 1-1,024 for standard, 4-16,384 for
        /// io1, 1-16,384 for gp2, and 500-16,384 for st1 and sc1.
        /// If you create a volume from a snapshot and you don&#39;t specify a volume size, the default is the
        /// snapshot size.
        /// You must specify either a VolumeSize or a SnapshotId. If you specify both SnapshotId and VolumeSize,
        /// VolumeSize must be equal or greater than the size of the snapshot.
        /// Required: Conditional
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 16384
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type, which can be standard for Magnetic, io1 for Provisioned IOPS SSD, gp2 for General
        /// Purpose SSD, st1 for Throughput Optimized HDD, or sc1 for Cold HDD. For more information, see Amazon
        /// EBS volume types in the Amazon EC2 User Guide for Linux Instances.
        /// Valid values: standard | io1 | gp2 | st1 | sc1
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
