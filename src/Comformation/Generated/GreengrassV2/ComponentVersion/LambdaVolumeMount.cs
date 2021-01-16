using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaVolumeMount
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdavolumemount.html
    /// </summary>
    public class LambdaVolumeMount
    {

        /// <summary>
        /// SourcePath
        /// The path to the physical volume in the file system.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

        /// <summary>
        /// DestinationPath
        /// The path to the logical volume in the file system.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DestinationPath")]
        public Union<string, IntrinsicFunction> DestinationPath { get; set; }

        /// <summary>
        /// Permission
        /// The permission to access the volume: read/only (ro) or read/write (rw).
        /// Default: ro
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permission")]
        public Union<string, IntrinsicFunction> Permission { get; set; }

        /// <summary>
        /// AddGroupOwner
        /// Whether or not to add the AWS IoT Greengrass user group as an owner of the volume.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AddGroupOwner")]
        public Union<bool, IntrinsicFunction> AddGroupOwner { get; set; }

    }
}
