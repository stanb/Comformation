using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.Workspace
{
    /// <summary>
    /// Amazon WorkSpaces Workspace WorkspaceProperties
    /// The WorkspaceProperties property type specifies information about a WorkSpace.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html
    /// </summary>
    public class WorkspaceProperties
    {

        /// <summary>
        /// ComputeTypeName
        /// The compute type. For more information, see Amazon WorkSpaces Bundles.
        /// Required: No
        /// Type: String
        /// Valid Values: VALUE | STANDARD | PERFORMANCE | POWER | GRAPHICS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeTypeName")]
        public Union<string, IntrinsicFunction> ComputeTypeName { get; set; }

        /// <summary>
        /// RootVolumeSizeGib
        /// The size of the root volume.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RootVolumeSizeGib")]
        public Union<int, IntrinsicFunction> RootVolumeSizeGib { get; set; }

        /// <summary>
        /// RunningMode
        /// The running mode. For more information, see Manage the WorkSpace Running Mode.
        /// Required: No
        /// Type: String
        /// Valid Values: AUTO_STOP | ALWAYS_ON
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunningMode")]
        public Union<string, IntrinsicFunction> RunningMode { get; set; }

        /// <summary>
        /// RunningModeAutoStopTimeoutInMinutes
        /// The time after a user logs off when WorkSpaces are automatically stopped. Configured in 60 minute
        /// intervals.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunningModeAutoStopTimeoutInMinutes")]
        public Union<int, IntrinsicFunction> RunningModeAutoStopTimeoutInMinutes { get; set; }

        /// <summary>
        /// UserVolumeSizeGib
        /// The size of the user storage.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserVolumeSizeGib")]
        public Union<int, IntrinsicFunction> UserVolumeSizeGib { get; set; }

    }
}
