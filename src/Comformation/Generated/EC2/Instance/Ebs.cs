using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance Ebs
    /// Specifies a block device for an EBS volume.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-blockdev-template.html
    /// </summary>
    public class Ebs
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether the EBS volume is deleted on instance termination.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// 		
        /// Indicates whether the volume is encrypted. Encrypted Amazon EBS volumes can only be attached to
        /// 			instance types that support Amazon EBS encryption. Volumes that are created from encrypted
        /// snapshots 			are automatically encrypted. You cannot create an encrypted volume from an unencrypted
        /// snapshot or 			vice versa. If your AMI uses encrypted volumes, you can only launch the AMI on
        /// supported instance 			types. For more information, see 				Amazon EBS Volume Types in the Amazon
        /// Elastic Compute Cloud User 					Guide.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. For io1 volumes, this
        /// represents the number of IOPS that are provisioned for the volume. For gp2 volumes, this represents
        /// the baseline performance of the volume and the rate at which the volume accumulates I/O credits for
        /// bursting. For more information, see Amazon EBS Volume Types in the Amazon Elastic Compute Cloud User
        /// Guide.
        /// Constraints: Range is 100-16,000 IOPS for gp2 volumes and 100 to 64,000IOPS for io1 volumes in most
        /// Regions. Maximum io1IOPS of 64,000 is guaranteed only on Nitro-based instances. Other instance
        /// families guarantee performance up to 32,000 IOPS. For more information, see Amazon EBS Volume Types
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// Condition: This parameter is required for requests to create io1 volumes; it is not used in requests
        /// to create gp2, st1, sc1, or standard volumes.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// 		
        /// The ID of the snapshot.
        /// 		
        /// If you specify both SnapshotId and VolumeSize,VolumeSize must be equal or greater than the size of
        /// the snapshot.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// The size of the volume, in GiB.
        /// Default: If you&#39;re creating the volume from a snapshot and don&#39;t specify a volume size, the default
        /// is the snapshot size.
        /// Constraints: 1-16384 for General Purpose SSD (gp2), 4-16384 for Provisioned IOPS SSD (io1),
        /// 500-16384 for Throughput Optimized HDD (st1), 500-16384 for Cold HDD (sc1), and 1-1024 for Magnetic
        /// (standard) volumes. If you specify a snapshot, the volume size must be equal to or larger than the
        /// snapshot size.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. If you set the type to io1, you must also set the Iops property.
        /// Default: standard
        /// Required: No
        /// Type: String
        /// Allowed Values: gp2 | io1 | sc1 | st1 | standard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
