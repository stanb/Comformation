using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon Elastic Block Store Block Device
    /// The Amazon Elastic Block Store block device type is an embedded property of the Amazon EC2 BlockDeviceMapping
    /// property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-template.html
    /// </summary>
    public class Ebs
    {

        /// <summary>
        /// DeleteOnTermination
        /// Determines whether to delete the volume on instance termination. The default value is true.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the volume is encrypted. Encrypted Amazon EBS volumes can only be attached to
        /// instance types that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
        /// are automatically encrypted. You cannot create an encrypted volume from an unencrypted snapshot or
        /// vice versa. If your AMI uses encrypted volumes, you can only launch the AMI on supported instance
        /// types. For more information, see Amazon EBS encryption in the Amazon EC2 User Guide for Linux
        /// Instances.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. This can be an integer from
        /// 100 – 20000.
        /// Required: Conditional Required when the volume type is io1; not used with other volume types.
        /// Type: Number
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// The snapshot ID of the volume to use to create a block device.
        /// Required: Conditional If you specify both SnapshotId and VolumeSize, VolumeSize must be equal or
        /// greater than the size of the snapshot.
        /// Type: String
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// The volume size, in gibibytes (GiB). For valid values, see the Size parameter for the CreateVolume
        /// action in the Amazon EC2 API Reference.
        /// Required: Conditional If you specify both SnapshotId and VolumeSize, VolumeSize must be equal or
        /// greater than the size of the snapshot.
        /// Type: String
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. If you set the type to io1, you must also set the Iops property. For valid values,
        /// see the VolumeType parameter for the CreateVolume action in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
