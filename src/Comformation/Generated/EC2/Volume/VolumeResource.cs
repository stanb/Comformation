using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Volume
{
    /// <summary>
    /// AWS::EC2::Volume
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
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// Encrypted
            /// Indicates whether the volume should be encrypted. The effect of setting the encryption state to true
            /// depends on the volume origin (new or from a snapshot), starting encryption state, ownership, and
            /// whether encryption by default is enabled. For more information, see Encryption by default in the
            /// Amazon Elastic Compute Cloud User Guide.
            /// Encrypted Amazon EBS volumes must be attached to instances that support Amazon EBS encryption. For
            /// more information, see Supported instance types.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// </summary>
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
            public Union<int, IntrinsicFunction> Iops { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The identifier of the AWS Key Management Service (AWS KMS) customer master key 	(CMK) to use for
            /// Amazon EBS encryption. If KmsKeyId is specified, the 	encrypted state must be true.
            /// 	 	
            /// If you omit this property and your account is enabled for encryption by default, 		or Encrypted is
            /// set to true, 		then the volume is encrypted using the default CMK specified for your account. If
            /// 		your account does not have a default CMK, then the volume is encrypted using the 		AWS managed
            /// CMK.
            /// 	
            /// Alternatively, if you want to specify a different CMK, you can specify one of the 	following:
            /// Key ID. For example, 1234abcd-12ab-34cd-56ef-1234567890ab. Key alias. Specify the alias for the CMK,
            /// prefixed with alias/. For 	example, for a CMK with the alias my_cmk, use alias/my_cmk. 	Or to
            /// specify the AWS managed CMK, use alias/aws/ebs. Key ARN. For example,
            /// arn:aws:kms:us-east-1:012345678910:key/1234abcd-12ab-34cd-56ef-1234567890ab. Alias ARN. For example,
            /// arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// MultiAttachEnabled
            /// Indicates whether Amazon EBS Multi-Attach is enabled.
            /// Note AWS CloudFormation does not currently support updating a single-attach volume to be
            /// multi-attach enabled, updating a multi-attach enabled volume to be single-attach, or updating the
            /// size or number of I/O operations per second (IOPS) of a multi-attach enabled volume.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> MultiAttachEnabled { get; set; }

            /// <summary>
            /// OutpostArn
            /// The Amazon Resource Name (ARN) of the Outpost.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> OutpostArn { get; set; }

            /// <summary>
            /// Size
            /// The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. If you
            /// specify a snapshot, the default is the snapshot size. You can specify a volume size that is equal to
            /// or larger than the snapshot size.
            /// The following are the supported volumes sizes for each volume type:
            /// 	 gp2 and gp3: 1-16,384 io1 and io2: 4-16,384 st1 and sc1: 125-16,384 standard: 1-1,024
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// SnapshotId
            /// The snapshot from which to create the volume. You must specify either a snapshot ID or a volume
            /// size.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
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
            /// Throughput
            /// The throughput that the volume supports, in MiB/s.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Throughput { get; set; }

            /// <summary>
            /// VolumeType
            /// The volume type. This parameter can be one of the following values:
            /// General Purpose SSD: gp2 | gp3 Provisioned IOPS SSD: io1 | io2 Throughput Optimized HDD: st1 Cold
            /// HDD: sc1 Magnetic: standard
            /// For more information, see Amazon EBS volume types in the Amazon Elastic Compute Cloud User Guide.
            /// Default: gp2
            /// Required: No
            /// Type: String
            /// Allowed values: gp2 | gp3 | io1 | io2 | sc1 | st1 | standard
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VolumeType { get; set; }

        }

        public string Type { get; } = "AWS::EC2::Volume";

        public VolumeProperties Properties { get; } = new VolumeProperties();

    }
}
