using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig EbsBlockDeviceConfig
    /// Use the EbsBlockDeviceConfig property to specify the settings for the Amazon EBS volumes that Amazon EMR
    /// associates with your instances. The EbsBlockDeviceConfigs subproperty of the Amazon EMR InstanceFleetConfig
    /// EbsConfiguration property contains a list of EbsBlockDeviceConfig property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html
    /// </summary>
    public class EbsBlockDeviceConfig
    {

        /// <summary>
        /// VolumeSpecification
        /// Amazon EBS volume specifications, such as volume type, IOPS, and size (GiB), for the EBS volume
        /// attached to an EC2 instance in the fleet.
        /// Required: Yes
        /// Type: Amazon EMR InstanceFleetConfig VolumeSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeSpecification")]
        public Union<VolumeSpecification, IntrinsicFunction> VolumeSpecification { get; set; }

        /// <summary>
        /// VolumesPerInstance
        /// The number of Amazon EBS volumes with a specific volume configuration that are associated with every
        /// instance in the fleet.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumesPerInstance")]
        public Union<int, IntrinsicFunction> VolumesPerInstance { get; set; }

    }
}
