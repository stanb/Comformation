using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition Device
    /// The Device property type specifies a device on a host container instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html
    /// </summary>
    public class Device
    {

        /// <summary>
        /// ContainerPath
        /// The path inside the container to expose the host device to.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

        /// <summary>
        /// HostPath
        /// The path for the device on the host container instance.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HostPath")]
        public Union<string, IntrinsicFunction> HostPath { get; set; }

        /// <summary>
        /// Permissions
        /// The explicit permissions to provide to the container for the device. By default, the container is
        /// able to read, write, and mknod the device.
        /// Required: No
        /// Type: List of String values
        /// Valid values: read, write, and mknod
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permissions")]
        public Union<List<string>, IntrinsicFunction> Permissions { get; set; }

    }
}
