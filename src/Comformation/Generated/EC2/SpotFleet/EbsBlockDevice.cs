using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet Ebs
    /// Ebs is a property of the Amazon Elastic Compute Cloud SpotFleet BlockDeviceMappings property that defines a
    /// block device for an Amazon Elastic Block Store (Amazon EBS) volume.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html
    /// </summary>
    public class EbsBlockDevice
    {

        /// <summary>
        /// DeleteOnTermination
        /// Indicates whether to delete the volume when the instance is terminated.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Encrypted
        /// Indicates whether the EBS volume is encrypted. Encrypted Amazon EBS volumes can be attached only to
        /// instances that support Amazon EBS encryption.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports. For more information, see
        /// Iops for the EbsBlockDevice action in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SnapshotId
        /// The snapshot ID of the volume that you want to use. If you specify both the SnapshotId and
        /// VolumeSize properties, VolumeSize must be equal to or greater than the size of the snapshot.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// The volume size, in Gibibytes (GiB). If you specify both the SnapshotId and VolumeSize properties,
        /// VolumeSize must be equal to or greater than the size of the snapshot. For more information about
        /// specifying the volume size, see VolumeSize for the EbsBlockDevice action in the Amazon EC2 API
        /// Reference.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. For more information about specifying the volume type, see VolumeType for the
        /// EbsBlockDevice action in the Amazon EC2 API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
