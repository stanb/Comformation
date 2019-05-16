using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-volumeconfiguration.html
    /// </summary>
    public class VolumeConfiguration
    {

        /// <summary>
        /// Encrypted
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// Iops
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// MountPoint
        /// </summary>
        [JsonProperty("MountPoint")]
        public Union<string, IntrinsicFunction> MountPoint { get; set; }

        /// <summary>
        /// NumberOfDisks
        /// </summary>
        [JsonProperty("NumberOfDisks")]
        public Union<int, IntrinsicFunction> NumberOfDisks { get; set; }

        /// <summary>
        /// RaidLevel
        /// </summary>
        [JsonProperty("RaidLevel")]
        public Union<int, IntrinsicFunction> RaidLevel { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// VolumeType
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
