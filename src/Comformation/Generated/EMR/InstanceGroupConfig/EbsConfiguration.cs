using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig EbsConfiguration
    /// The Amazon EBS configuration of a cluster instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html
    /// </summary>
    public class EbsConfiguration
    {

        /// <summary>
        /// EbsBlockDeviceConfigs
        /// An array of Amazon EBS volume specifications attached to a cluster instance.
        /// Required: No
        /// Type: List of EbsBlockDeviceConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbsBlockDeviceConfigs")]
        public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether an Amazon EBS volume is EBS-optimized.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

    }
}
