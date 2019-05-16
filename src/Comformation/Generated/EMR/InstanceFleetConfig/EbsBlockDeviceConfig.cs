using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig EbsBlockDeviceConfig
    /// EbsBlockDeviceConfig is a subproperty of the EbsConfiguration property type. EbsBlockDeviceConfig defines the
    /// number and type of EBS volumes to associate with all EC2 instances in an EMR cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html
    /// </summary>
    public class EbsBlockDeviceConfig
    {

        /// <summary>
        /// VolumeSpecification
        /// EBS volume specifications such as volume type, IOPS, and size (GiB) that will be requested for the
        /// EBS volume attached to an EC2 instance in the cluster.
        /// Required: Yes
        /// Type: VolumeSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeSpecification")]
        public VolumeSpecification VolumeSpecification { get; set; }

        /// <summary>
        /// VolumesPerInstance
        /// 	
        /// Number of EBS volumes with a specific volume configuration that will be associated with every
        /// instance in the instance group
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumesPerInstance")]
        public Union<int, IntrinsicFunction> VolumesPerInstance { get; set; }

    }
}
