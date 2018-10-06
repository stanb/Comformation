using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR EbsConfiguration EbsBlockDeviceConfigs
    /// EbsBlockDeviceConfigs is a property of the Amazon EMR EbsConfiguration property that defines the settings for
    /// the Amazon Elastic Block Store (Amazon EBS) volumes that Amazon EMR (Amazon EMR) associates with your
    /// instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig.html
    /// </summary>
    public class EbsBlockDeviceConfig
    {

        /// <summary>
        /// VolumeSpecification
        /// The settings for the Amazon EBS volumes.
        /// Required: Yes
        /// Type: Amazon EMR EbsConfiguration EbsBlockDeviceConfig VolumeSpecification
        /// </summary>
        [JsonProperty("VolumeSpecification")]
        public VolumeSpecification VolumeSpecification { get; set; }

        /// <summary>
        /// VolumesPerInstance
        /// The number of Amazon EBS volumes that you want to create for each instance in the EMR cluster or
        /// instance group. The number cannot be 0.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("VolumesPerInstance")]
        public Union<int, IntrinsicFunction> VolumesPerInstance { get; set; }

    }
}
