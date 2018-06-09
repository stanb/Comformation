using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR EbsConfiguration
    /// EbsConfiguration is a property of the Amazon EMR Cluster InstanceGroupConfig property and the
    /// AWS::EMR::InstanceGroupConfig resource that defines Amazon Elastic Block Store (Amazon EBS) storage volumes to
    /// attach to your Amazon EMR (Amazon EMR) instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html
    /// </summary>
    public class EbsConfiguration
    {

        /// <summary>
        /// EbsBlockDeviceConfigs
        /// Configures the block storage devices that are associated with your EMR instances.
        /// Required: No
        /// Type: List of Amazon EMR EbsConfiguration EbsBlockDeviceConfigs
        /// </summary>
        [JsonProperty("EbsBlockDeviceConfigs")]
        public Union<List<EbsBlockDeviceConfig>, IntrinsicFunction> EbsBlockDeviceConfigs { get; set; }

        /// <summary>
        /// EbsOptimized
        /// Indicates whether the instances are optimized for Amazon EBS I/O. This optimization provides
        /// dedicated throughput to Amazon EBS and an optimized configuration stack to provide optimal EBS I/O
        /// performance. For more information about fees and supported instance types, see EBS-Optimized
        /// Instances in the Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: Boolean
        /// Default value: false
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

    }
}
