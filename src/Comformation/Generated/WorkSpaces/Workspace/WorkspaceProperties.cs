using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WorkSpaces.Workspace
{
    /// <summary>
    /// AWS::WorkSpaces::Workspace WorkspaceProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html
    /// </summary>
    public class WorkspaceProperties
    {

        /// <summary>
        /// ComputeTypeName
        /// The compute type. For more information, see Amazon WorkSpaces Bundles.
        /// Required: No
        /// Type: String
        /// Allowed values: GRAPHICS | GRAPHICSPRO | PERFORMANCE | POWER | POWERPRO | STANDARD | VALUE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeTypeName")]
        public Union<string, IntrinsicFunction> ComputeTypeName { get; set; }

        /// <summary>
        /// RootVolumeSizeGib
        /// The size of the root volume. For important information about how to modify the size of the root and
        /// user volumes, see Modify a WorkSpace.
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
        /// Allowed values: ALWAYS_ON | AUTO_STOP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunningMode")]
        public Union<string, IntrinsicFunction> RunningMode { get; set; }

        /// <summary>
        /// RunningModeAutoStopTimeoutInMinutes
        /// The time after a user logs off when WorkSpaces are automatically stopped. Configured in 60-minute
        /// intervals.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunningModeAutoStopTimeoutInMinutes")]
        public Union<int, IntrinsicFunction> RunningModeAutoStopTimeoutInMinutes { get; set; }

        /// <summary>
        /// UserVolumeSizeGib
        /// The size of the user storage. For important information about how to modify the size of the root and
        /// user volumes, see Modify a WorkSpace.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserVolumeSizeGib")]
        public Union<int, IntrinsicFunction> UserVolumeSizeGib { get; set; }

    }
}
