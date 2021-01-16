using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet EbsBlockDevice
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html
    /// </summary>
    public class EbsBlockDevice
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether the EBS volume is deleted on instance termination. For more information, see
        /// Preserving Amazon EBS volumes on instance termination in the Amazon EC2 User Guide.
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
        /// This parameter is not returned by 	DescribeImageAttribute.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS). For gp3, io1, and io2 volumes, this represents the
        /// number of IOPS that are provisioned for the volume. For gp2 volumes, this represents the baseline
        /// performance of the volume and the rate at which the volume accumulates I/O credits for bursting.
        /// The following are the supported values for each volume type:
        /// gp3: 3,000-16,000 IOPS io1: 100-64,000 IOPS io2: 100-64,000 IOPS
        /// For io1 and io2 volumes, we guarantee 64,000 IOPS only for Instances built on the Nitro System.
        /// Other instance families guarantee performance up to 32,000 IOPS.
        /// This parameter is required for io1 and io2 volumes. The default for gp3 volumes is 3,000 IOPS. This
        /// parameter is not supported for gp2, st1, sc1, or standard volumes.
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
        /// The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. If you
        /// specify a snapshot, the default is the snapshot size. You can specify a volume size that is equal to
        /// or larger than the snapshot size.
        /// The following are the supported volumes sizes for each volume type:
        /// 	 gp2 and gp3:1-16,384 io1 and io2: 4-16,384 st1 and sc1: 125-16,384 standard: 1-1,024
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. For more information, see Amazon EBS volume types in the Amazon EC2 User Guide. If
        /// the volume type is io1 or io2, you must specify the IOPS that the volume supports.
        /// Required: No
        /// Type: String
        /// Allowed values: gp2 | gp3 | io1 | io2 | sc1 | st1 | standard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
