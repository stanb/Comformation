using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Volume
{
    /// <summary>
    /// AWS::EC2::Volume
    /// The AWS::EC2::Volume type creates a new Amazon Elastic Block Store (Amazon EBS) volume.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html
    /// </summary>
    public class VolumeResource : ResourceBase
    {
        public class VolumeProperties
        {
            /// <summary>
            /// AutoEnableIO
            /// Indicates whether the volume is auto-enabled for I/O operations. By default, Amazon EBS disables I/O
            /// to the volume from attached EC2 instances when it determines that a volume's data is potentially
            /// inconsistent. If the consistency of the volume is not a concern, and you prefer that the volume be
            /// made available immediately if it's impaired, you can configure the volume to automatically enable
            /// I/O. For more information, see Working with the AutoEnableIO Volume Attribute in the Amazon EC2 User
            /// Guide for Linux Instances.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-autoenableio
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoEnableIO { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone in which to create the new volume.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// Encrypted
            /// Indicates whether the volume is encrypted. You can attach encrypted Amazon EBS volumes only to
            /// instance types that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
            /// are automatically encrypted. You can't create an encrypted volume from an unencrypted snapshot, or
            /// vice versa. If your AMI uses encrypted volumes, you can launch the AMI only on supported instance
            /// types. For more information, see Amazon EBS encryption in the Amazon EC2 User Guide for Linux
            /// Instances.
            /// Required: Conditional. If you specify the KmsKeyId property, you must enable encryption.
            /// Type: Boolean
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-encrypted
            /// </summary>
			public Union<bool, IntrinsicFunction> Encrypted { get; set; }

            /// <summary>
            /// Iops
            /// The number of I/O operations per second (IOPS) that the volume supports. For more information about
            /// the valid sizes for each volume type, see the Iops parameter for the CreateVolume action in the
            /// Amazon EC2 API Reference.
            /// Required: Conditional. Required when the volume type is io1; not used with other volume types.
            /// Type: Number
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-iops
            /// </summary>
			public Union<int, IntrinsicFunction> Iops { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service master key that is used to create
            /// the encrypted volume, such as
            /// arn:aws:kms:us-east-2:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If you create an
            /// encrypted volume and don't specify this property, AWS CloudFormation uses the default master key.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-kmskeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// Size
            /// The size of the volume, in gibibytes (GiBs). For more information about the valid sizes for each
            /// volume type, see the Size parameter for the CreateVolume action in the Amazon EC2 API Reference.
            /// If you specify the SnapshotId property, specify a size that is equal to or greater than the size of
            /// the snapshot. If you don't specify a size, EC2 uses the size of the snapshot as the volume size.
            /// Required: Conditional. If you don't specify a value for the SnapshotId property, you must specify
            /// this property.
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-size
            /// </summary>
			public Union<int, IntrinsicFunction> Size { get; set; }

            /// <summary>
            /// SnapshotId
            /// The snapshot from which to create the new volume.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-snapshotid
            /// </summary>
			public Union<string, IntrinsicFunction> SnapshotId { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this volume.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VolumeType
            /// The volume type. If you set the type to io1, you must also set the Iops property. For valid values,
            /// see the VolumeType parameter for the CreateVolume action in the Amazon EC2 API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-volumetype
            /// </summary>
			public Union<string, IntrinsicFunction> VolumeType { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::Volume";
        
        public VolumeProperties Properties { get; } = new VolumeProperties();
    }
}
