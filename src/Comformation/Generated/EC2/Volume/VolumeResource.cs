using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Volume
{
    /// <summary>
    /// AWS::EC2::Volume
    /// Specifies an Amazon Elastic Block Store (Amazon EBS) volume.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html
    /// </summary>
    public class VolumeResource : ResourceBase
    {
        public class VolumeProperties
        {
            /// <summary>
            /// AutoEnableIO
            /// Indicates whether the volume is auto-enabled for I/O operations. By default, Amazon EBS disables I/O
            /// to the volume from attached EC2 instances when it determines that a volume&#39;s data is potentially
            /// inconsistent. If the consistency of the volume is not a concern, and you prefer that the volume be
            /// made available immediately if it&#39;s impaired, you can configure the volume to automatically enable
            /// I/O.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoEnableIO { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone in which to create the volume.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// Encrypted
            /// Specifies whether the volume should be encrypted. The effect of setting the encryption state to true
            /// depends on the volume origin (new or from a snapshot), starting encryption state, ownership, and
            /// whether encryption by default is enabled. For more information, see Encryption by Default in the
            /// Amazon Elastic Compute Cloud User Guide.
            /// Encrypted Amazon EBS volumes must be attached to instances that support Amazon EBS encryption. For
            /// more information, see Supported Instance Types.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// Iops
            /// The number of I/O operations per second (IOPS) to provision for the volume, with a maximum ratio of
            /// 50 IOPS/GiB. Range is 100 to 64,000 IOPS for volumes in most Regions. Maximum IOPS of 64,000 is
            /// guaranteed only on Nitro-based instances. Other instance families guarantee performance up to 32,000
            /// IOPS. For more information, see Amazon EBS Volume Types in the Amazon Elastic Compute Cloud User
            /// Guide.
            /// This parameter is valid only for Provisioned IOPS SSD (io1) volumes.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Iops { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The identifier of the AWS Key Management Service (AWS KMS) customer master key (CMK) to use for
            /// Amazon EBS encryption. If this parameter is not specified, your AWS managed CMK for EBS is used. If
            /// KmsKeyId is specified, the encrypted state must be true.
            /// You can specify the CMK using any of the following:
            /// Key ID. For example, key/1234abcd-12ab-34cd-56ef-1234567890ab. Key alias. For example,
            /// alias/ExampleAlias. Key ARN. For example,
            /// arn:aws:kms:us-east-1:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. Alias ARN. For example,
            /// arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
            /// AWS authenticates the CMK asynchronously. Therefore, if you specify an ID, alias, or ARN that is not
            /// valid, the action can appear to complete, but eventually fails.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// Size
            /// The size of the volume, in GiBs.
            /// Constraints: 1-16,384 for gp2, 4-16,384 for io1, 500-16,384 for st1, 500-16,384 for sc1, and 1-1,024
            /// for standard. If you specify a snapshot, the volume size must be equal to or larger than the
            /// snapshot size.
            /// Default: If you&#39;re creating the volume from a snapshot and don&#39;t specify a volume size, the default
            /// is the snapshot size.
            /// Note At least one of Size or SnapshotId is required.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// SnapshotId
            /// The snapshot from which to create the volume.
            /// Note At least one of Size or SnapshotId are required.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotId { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply to the volume during creation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VolumeType
            /// The volume type. This can be gp2 for General Purpose SSD, io1 for Provisioned IOPS SSD, st1 for
            /// Throughput Optimized HDD, sc1 for Cold HDD, or standard for Magnetic volumes.
            /// Default: gp2
            /// Required: No
            /// Type: String
            /// Allowed Values: gp2 | io1 | sc1 | st1 | standard
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VolumeType { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Volume";

        public VolumeProperties Properties { get; } = new VolumeProperties();

    }
}
