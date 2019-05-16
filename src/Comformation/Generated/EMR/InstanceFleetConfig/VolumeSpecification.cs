using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig VolumeSpecification
    /// VolumeSpecification is a subproperty of the EbsBlockDeviceConfig property type. VolumeSecification determines
    /// the volume type, IOPS, and size (GiB) for EBS volumes attached to EC2 instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html
    /// </summary>
    public class VolumeSpecification
    {

        /// <summary>
        /// Iops
        /// The number of I/O operations per second (IOPS) that the volume supports.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// SizeInGB
        /// The volume size, in gibibytes (GiB). This can be a number from 1 - 1024. If the volume type is
        /// EBS-optimized, the minimum value is 10.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SizeInGB")]
        public Union<int, IntrinsicFunction> SizeInGB { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. Volume types supported are gp2, io1, standard.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
