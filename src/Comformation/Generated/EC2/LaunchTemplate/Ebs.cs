using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate Ebs
    /// The Ebs property type specifies parameters for a block device for an EBS volume in a Amazon EC2 launch
    /// template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html
    /// </summary>
    public class Ebs
    {

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
        /// VolumeType
        /// The volume type.
        /// Valid values include: standard, io1, gp2, sc1, and st1.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

        /// <summary>
        /// KmsKeyId
        /// The ARN of the AWS Key Management Service (AWS KMS) CMK used for encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the EBS volume is encrypted. Encrypted volumes can only be attached to instances
        /// that support Amazon EBS encryption. If you are creating a volume from a snapshot, you can't specify
        /// an encryption value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. For io1, this represents
        /// the number of IOPS that are provisioned for the volume. For gp2, this represents the baseline
        /// performance of the volume and the rate at which the volume accumulates I/O credits for bursting. For
        /// more information about General Purpose SSD baseline performance, I/O credits, and bursting, see
        /// Amazon EBS Volume Types in the Amazon EC2 User Guide for Linux Instances.
        /// Condition: This parameter is required for requests to create io1 volumes; it is not used in requests
        /// to create gp2, st1, sc1, or standard volumes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// VolumeSize
        /// The size of the volume, in GiB.
        /// Default: If you're creating the volume from a snapshot and don't specify a volume size, the default
        /// is the snapshot size.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether the EBS volume is deleted on instance termination.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

    }
}
