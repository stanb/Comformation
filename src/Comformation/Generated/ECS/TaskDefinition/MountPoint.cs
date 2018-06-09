using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition MountPoint
    /// MountPoints is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition property
    /// that specifies the mount points for data volumes in a container.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-mountpoints.html
    /// </summary>
    public class MountPoint
    {

        /// <summary>
        /// ContainerPath
        /// The path on the container that indicates where you want to mount the volume.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

        /// <summary>
        /// ReadOnly
        /// Indicates whether the container can write to the volume. If you specify true, the container has
        /// read-only access to the volume. If you specify false, the container can write to the volume. By
        /// default, the value is false.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Union<bool, IntrinsicFunction> ReadOnly { get; set; }

        /// <summary>
        /// SourceVolume
        /// The name of the volume to mount.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("SourceVolume")]
        public Union<string, IntrinsicFunction> SourceVolume { get; set; }

    }
}
