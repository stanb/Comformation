using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// AWS::EMR::InstanceFleetConfig EbsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html
    /// </summary>
    public class EbsConfiguration
    {

        /// <summary>
        /// EbsBlockDeviceConfigs
        /// An array of Amazon EBS volume specifications attached to a cluster instance.
        /// Required: No
        /// Type: List of EbsBlockDeviceConfig
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
