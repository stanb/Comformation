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
        /// Indicates whether the volume is deleted on instance termination. For Amazon EC2 Auto Scaling, the
        /// default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Specifies whether the volume should be encrypted. Encrypted EBS volumes can only be attached to
        /// instances that support Amazon EBS encryption. For more information, see Supported Instance Types. If
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
        /// The number of input/output (I/O) operations per second (IOPS) to provision for the volume. For gp3
        /// and io1 volumes, this represents the number of IOPS that are provisioned for the volume. For gp2
        /// volumes, this represents the baseline performance of the volume and the rate at which the volume
        /// accumulates I/O credits for bursting.
        /// The following are the supported values for each volume type:
        /// gp3: 3,000-16,000 IOPS io1: 100-64,000 IOPS
        /// For io1 volumes, we guarantee 64,000 IOPS only for Instances built on the Nitro System. Other
        /// instance families guarantee performance up to 32,000 IOPS.
        /// Iops is supported when the volume type is gp3 or io1 and required only when the volume type is io1.
        /// (Not used with standard, gp2, st1, or sc1 volumes. )
        /// Required: Conditional
        /// Type: Integer
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
        /// Throughput
        /// The throughput (MiBps) to provision for a gp3 volume.
        /// Required: No
        /// Type: Integer
        /// Minimum: 125
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Throughput")]
        public Union<int, IntrinsicFunction> Throughput { get; set; }

        /// <summary>
        /// VolumeSize
        /// The volume size, in GiBs. The following are the supported volumes sizes for each volume type:
        /// gp2 and gp3: 1-16,384 io1: 4-16,384 st1 and sc1: 125-16,384 standard: 1-1,024
        /// You must specify either a SnapshotId or a VolumeSize. If you specify both SnapshotId and VolumeSize,
        /// the volume size must be equal or greater than the size of the snapshot.
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
        /// The volume type. For more information, see Amazon EBS Volume Types in the Amazon EC2 User Guide for
        /// Linux Instances.
        /// Valid Values: standard | io1 | gp2 | st1 | sc1 | gp3
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
