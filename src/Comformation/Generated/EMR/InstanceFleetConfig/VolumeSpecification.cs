using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig VolumeSpecification
    /// Use the VolumeSpecification property to specify settings—such as volume type, IOPS, and size (GiB)—for the
    /// Amazon EBS volume attached to an EC2 instance in the fleet. VolumeSpecification is a subproperty of the Amazon
    /// EMR InstanceFleetConfig EbsBlockDeviceConfig property.
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
        /// The volume size, in gibibytes (GiB). For valid values, see VolumeSpecification in the Amazon EMR API
        /// Reference.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SizeInGB")]
        public Union<int, IntrinsicFunction> SizeInGB { get; set; }

        /// <summary>
        /// VolumeType
        /// The volume type. For valid values, see VolumeSpecification in the Amazon EMR API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
