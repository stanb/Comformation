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
            /// The Availability Zone in which to create the new volume.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// Encrypted
            /// Indicates whether the volume is encrypted. You can attach encrypted Amazon EBS volumes only to
            /// instance types that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
            /// are automatically encrypted. You can&#39;t create an encrypted volume from an unencrypted snapshot, or
            /// vice versa. If your AMI uses encrypted volumes, you can launch the AMI only on supported instance
            /// types.
            /// Requirement is conditional: If you specify the KmsKeyId property, you must enable encryption.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// Iops
            /// The number of I/O operations per second (IOPS) that the volume supports. For Provisioned IOPS SSD
            /// volumes, this represents the number of IOPS that are provisioned for the volume. For General Purpose
            /// SSD volumes, this represents the baseline performance of the volume and the rate at which the volume
            /// accumulates I/O credits for bursting. For more information, see Amazon EBS Volume Types in the
            /// Amazon Elastic Compute Cloud User Guide.
            /// Constraints: Range is 100-16,000 IOPS for gp2 volumes and 100 to 64,000IOPS for io1 volumes, in most
            /// Regions. The maximum IOPS for io1 of 64,000 is guaranteed only on Nitro-based instances. Other
            /// instance families guarantee performance up to 32,000 IOPS.
            /// Requirement is conditional: This parameter is required for requests to create io1 volumes; it is not
            /// used in requests to create gp2, st1, sc1, or standard volumes.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Iops { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service master key that is used to create
            /// the encrypted volume, such as
            /// arn:aws:kms:us-east-2:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If you create an
            /// encrypted volume and don&#39;t specify this property, AWS CloudFormation uses the default master key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// Size
            /// The size of the volume, in gibibytes (GiBs).
            /// If you specify the SnapshotId property, specify a size that is equal to or greater than the size of
            /// the snapshot. If you don&#39;t specify a size, EC2 uses the size of the snapshot as the volume size.
            /// Requirement is conditional: If you don&#39;t specify a value for the SnapshotId property, then you must
            /// specify this property.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// SnapshotId
            /// The snapshot from which to create the volume.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this volume.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VolumeType
            /// The volume type. This can be gp2 for General Purpose SSD, io1 for Provisioned IOPS SSD, st1 for
            /// Throughput Optimized HDD, sc1 for Cold HDD, or standard for Magnetic volumes. If you set the type to
            /// io1, you must also set the Iops property.
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
