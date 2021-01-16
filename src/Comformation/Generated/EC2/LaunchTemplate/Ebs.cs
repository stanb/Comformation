using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate Ebs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping-ebs.html
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
        /// The volume type. For more information, see Amazon EBS volume types in the Amazon Elastic Compute
        /// Cloud User Guide.
        /// Required: No
        /// Type: String
        /// Allowed values: gp2 | gp3 | io1 | io2 | sc1 | st1 | standard
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

        /// <summary>
        /// KmsKeyId
        /// The ARN of the symmetric AWS Key Management Service (AWS KMS) CMK used for encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the EBS volume is encrypted. Encrypted volumes can only be attached to instances
        /// that support Amazon EBS encryption. If you are creating a volume from a snapshot, you can&#39;t specify
        /// an encryption value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Throughput
        /// The throughput to provision for a gp3 volume, with a maximum of 1,000 MiB/s.
        /// 	
        /// Valid Range: Minimum value of 125. Maximum value of 1000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Throughput")]
        public Union<int, IntrinsicFunction> Throughput { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS). For gp3, io1, and io2 volumes, this represents the
        /// number of IOPS that are provisioned for the volume. For gp2 volumes, this represents the baseline
        /// performance of the volume and the rate at which the volume accumulates I/O credits for bursting.
        /// The following are the supported values for each volume type:
        /// gp3: 3,000-16,000 IOPS io1: 100-64,000 IOPS io2: 100-64,000 IOPS
        /// For io1 and io2 volumes, we guarantee 64,000 IOPS only for Instances built on the Nitro System.
        /// Other instance families guarantee performance up to 32,000 IOPS.
        /// This parameter is supported for io1, io2, and gp3 volumes only. This parameter is not supported for
        /// gp2, st1, sc1, or standard volumes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// VolumeSize
        /// The size of the volume, in GiBs. You must specify either a snapshot ID or a volume size. The
        /// following are the supported volumes sizes for each volume type:
        /// 	 gp2 and gp3: 1-16,384 io1 and io2: 4-16,384 st1 and sc1: 125-16,384 standard: 1-1,024
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
