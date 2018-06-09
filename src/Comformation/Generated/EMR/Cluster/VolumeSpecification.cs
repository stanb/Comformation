using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR EbsConfiguration EbsBlockDeviceConfig VolumeSpecification
    /// VolumeSpecification is a property of the Amazon EMR EbsConfiguration property that configures the Amazon
    /// Elastic Block Store (Amazon EBS) volumes that Amazon EMR (Amazon EMR) associates with your instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html
    /// </summary>
    public class VolumeSpecification
    {

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
        /// SizeInGB
        /// The volume size, in Gibibytes (GiB). For more information about specifying the volume size, see
        /// VolumeSize for the EbsBlockDevice action in the Amazon EC2 API Reference.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("SizeInGB")]
        public Union<int, IntrinsicFunction> SizeInGB { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type, such as standard or io1. For more information about specifying the volume type, see
        /// VolumeType for the EbsBlockDevice action in the Amazon EC2 API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
