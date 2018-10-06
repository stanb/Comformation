using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig EbsConfiguration
    /// Use the EbsConfiguration property to specify the Amazon EBS configuration of an Amazon EMR fleet instance.
    /// EbsConfiguration is a subproperty of the Amazon EMR InstanceFleetConfig InstanceTypeConfig property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html
    /// </summary>
    public class EbsConfiguration
    {

        /// <summary>
        /// EbsBlockDeviceConfigs
        /// A list of Amazon EBS volume specifications that are attached to an instance. Duplicates not allowed.
        /// Required: No
        /// Type: List of Amazon EMR InstanceFleetConfig EbsBlockDeviceConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsBlockDeviceConfigs")]
        public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether an Amazon EBS volume is EBS-optimized.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

    }
}
