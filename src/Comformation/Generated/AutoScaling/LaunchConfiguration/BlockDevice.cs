using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// Amazon EC2 Auto Scaling LaunchConfig BlockDevice
    /// The Amazon EC2 Auto Scaling EBS BlockDevice type is an embedded property of the Amazon EC2 Auto Scaling
    /// LaunchConfiguration BlockDeviceMapping type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html
    /// </summary>
    public class BlockDevice
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether to delete the volume when the instance is terminated. By default, Amazon EC2 Auto
        /// Scaling uses true.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the volume is encrypted. Encrypted EBS volumes must be attached to instances that
        /// support Amazon EBS encryption. Volumes that you create from encrypted snapshots are automatically
        /// encrypted. You cannot create an encrypted volume from an unencrypted snapshot or an unencrypted
        /// volume from an encrypted snapshot.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. The maximum ratio of IOPS
        /// to volume size is 30.
        /// Required: No
        /// Type: Integer.
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// The snapshot ID of the volume to use.
        /// Required: Conditional If you specify both SnapshotId and VolumeSize, VolumeSize must be equal or
        /// greater than the size of the snapshot.
        /// Type: String
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// The volume size, in Gibibytes (GiB). This can be a number from 1 – 1024. If the volume type is EBS
        /// optimized, the minimum value is 10. For more information about specifying the volume type, see
        /// EbsOptimized in AWS::AutoScaling::LaunchConfiguration.
        /// Required: Conditional If you specify both SnapshotId and VolumeSize, VolumeSize must be equal or
        /// greater than the size of the snapshot.
        /// Type: Integer.
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. By default, Amazon EC2 Auto Scaling uses the standard volume type. For more
        /// information, see Ebs in the Amazon EC2 Auto Scaling API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
