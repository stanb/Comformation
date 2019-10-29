using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet EbsBlockDevice
    /// Describes a block device for an EBS volume.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html
    /// </summary>
    public class EbsBlockDevice
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether the EBS volume is deleted on instance termination. For more information, see
        /// Preserving Amazon EBS Volumes on Instance Termination in the Amazon Elastic Compute Cloud User
        /// Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the encryption state of an EBS volume is changed while being restored from a
        /// backing snapshot. The effect of setting the encryption state to true depends on the volume origin
        /// (new or from a snapshot), starting encryption state, ownership, and whether encryption by default is
        /// enabled. For more information, see Amazon EBS Encryption in the Amazon Elastic Compute Cloud User
        /// Guide.
        /// In no case can you remove encryption from an encrypted volume.
        /// Encrypted volumes can only be attached to instances that support Amazon EBS encryption. For more
        /// information, see Supported Instance Types.
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
        /// Regions. Maximum io1 IOPS of 64,000 is guaranteed only on Nitro-based instances. Other instance
        /// families guarantee performance up to 32,000 IOPS. For more information, see Amazon EBS Volume Types
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// Condition: This parameter is required for requests to create io1 volumes; it is not used in requests
        /// to create gp2, st1, sc1, or standard volumes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// The ID of the snapshot.
        /// Required: No
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
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. If you set the type to io1, you must also specify the IOPS that the volume
        /// supports.
        /// Default: gp2
        /// Required: No
        /// Type: String
        /// Allowed Values: gp2 | io1 | sc1 | st1 | standard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
