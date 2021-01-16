using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster EbsBlockDeviceConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsblockdeviceconfig.html
    /// </summary>
    public class EbsBlockDeviceConfig
    {

        /// <summary>
        /// VolumeSpecification
        /// EBS volume specifications such as volume type, IOPS, and size (GiB) that will be requested for the
        /// EBS volume attached to an EC2 instance in the cluster.
        /// Required: Yes
        /// Type: VolumeSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSpecification")]
        public VolumeSpecification VolumeSpecification { get; set; }

        /// <summary>
        /// VolumesPerInstance
        /// Number of EBS volumes with a specific volume configuration that will be associated with every
        /// instance in the instance group
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumesPerInstance")]
        public Union<int, IntrinsicFunction> VolumesPerInstance { get; set; }

    }
}
