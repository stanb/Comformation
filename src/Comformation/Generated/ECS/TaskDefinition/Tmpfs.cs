using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon ECS TaskDefinition Tmpfs
    /// The Tmpfs property type specifies the container path, mount options, and size of the tmpfs mount.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html
    /// </summary>
    public class Tmpfs
    {

        /// <summary>
        /// ContainerPath
        /// The absolute file path where the tmpfs volume is to be mounted.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

        /// <summary>
        /// MountOptions
        /// The list of tmpfs volume mount options. For a complete list of valid values, see Tmpfs in the Amazon
        /// Elastic Container Service API Reference.
        /// Duplicate values are not allowed.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MountOptions")]
        public List<Union<string, IntrinsicFunction>> MountOptions { get; set; }

        /// <summary>
        /// Size
        /// The size (in MiB) of the tmpfs volume.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

    }
}
