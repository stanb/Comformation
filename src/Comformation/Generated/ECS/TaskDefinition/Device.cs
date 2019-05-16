using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Device
    /// The Device property specifies an object representing a container instance host device.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html
    /// </summary>
    public class Device
    {

        /// <summary>
        /// ContainerPath
        /// The path inside the container at which to expose the host device.
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
        /// The explicit permissions to provide to the container for the device. By default, the container has
        /// permissions for read, write, and mknod for the device.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Permissions")]
        public List<Union<string, IntrinsicFunction>> Permissions { get; set; }

    }
}
