using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaContainerParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdacontainerparams.html
    /// </summary>
    public class LambdaContainerParams
    {

        /// <summary>
        /// MemorySizeInKB
        /// The memory size of the container, expressed in kilobytes.
        /// Default: 16384 (16 MB)
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MemorySizeInKB")]
        public Union<int, IntrinsicFunction> MemorySizeInKB { get; set; }

        /// <summary>
        /// MountROSysfs
        /// Whether or not the container can read information from the device&#39;s /sys folder.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MountROSysfs")]
        public Union<bool, IntrinsicFunction> MountROSysfs { get; set; }

        /// <summary>
        /// Volumes
        /// The list of volumes that the container can access.
        /// Required: No
        /// Type: List of LambdaVolumeMount
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Volumes")]
        public List<LambdaVolumeMount> Volumes { get; set; }

        /// <summary>
        /// Devices
        /// The list of system devices that the container can access.
        /// Required: No
        /// Type: List of LambdaDeviceMount
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Devices")]
        public List<LambdaDeviceMount> Devices { get; set; }

    }
}
