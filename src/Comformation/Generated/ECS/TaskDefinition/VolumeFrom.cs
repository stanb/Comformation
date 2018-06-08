using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition VolumeFrom
    /// VolumesFrom is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition property
    /// that mounts data volumes from other containers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-volumesfrom.html
    /// </summary>
    public class VolumeFrom
    {

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
        /// SourceContainer
        /// The name of the container that has the volumes to mount.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("SourceContainer")]
        public Union<string, IntrinsicFunction> SourceContainer { get; set; }

    }
}
