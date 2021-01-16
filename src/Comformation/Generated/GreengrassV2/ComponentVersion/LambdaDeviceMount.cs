using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaDeviceMount
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdadevicemount.html
    /// </summary>
    public class LambdaDeviceMount
    {

        /// <summary>
        /// Path
        /// The mount path for the device in the file system.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Permission
        /// The permission to access the device: read/only (ro) or read/write (rw).
        /// Default: ro
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permission")]
        public Union<string, IntrinsicFunction> Permission { get; set; }

        /// <summary>
        /// AddGroupOwner
        /// Whether or not to add the component&#39;s system user as an owner of the device.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AddGroupOwner")]
        public Union<bool, IntrinsicFunction> AddGroupOwner { get; set; }

    }
}
