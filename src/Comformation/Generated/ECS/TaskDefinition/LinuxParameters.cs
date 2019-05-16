using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition LinuxParameters
    /// The LinuxParameters property specifies Linux-specific options that are applied to the container, such as Linux
    /// KernelCapabilities.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html
    /// </summary>
    public class LinuxParameters
    {

        /// <summary>
        /// Capabilities
        /// The Linux capabilities for the container that are added to or dropped from the default configuration
        /// provided by Docker.
        /// Note If you are using tasks that use the Fargate launch type, capabilities is supported but the add
        /// parameter is not supported.
        /// Required: No
        /// Type: KernelCapabilities
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Capabilities")]
        public KernelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Devices
        /// Any host devices to expose to the container. This parameter maps to Devices in the Create a
        /// container section of the Docker Remote API and the --device option to docker run.
        /// Note If you are using tasks that use the Fargate launch type, the devices parameter is not
        /// supported.
        /// Required: No
        /// Type: List of Device
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Devices")]
        public List<Device> Devices { get; set; }

        /// <summary>
        /// InitProcessEnabled
        /// Run an init process inside the container that forwards signals and reaps processes. This parameter
        /// maps to the --init option to docker run. This parameter requires version 1. 25 of the Docker Remote
        /// API or greater on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: sudo docker version
        /// --format &#39;{{. Server. APIVersion}}&#39;
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitProcessEnabled")]
        public Union<bool, IntrinsicFunction> InitProcessEnabled { get; set; }

        /// <summary>
        /// SharedMemorySize
        /// The value for the size (in MiB) of the /dev/shm volume. This parameter maps to the --shm-size option
        /// to docker run.
        /// Note If you are using tasks that use the Fargate launch type, the sharedMemorySize parameter is not
        /// supported.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SharedMemorySize")]
        public Union<int, IntrinsicFunction> SharedMemorySize { get; set; }

        /// <summary>
        /// Tmpfs
        /// The container path, mount options, and size (in MiB) of the tmpfs mount. This parameter maps to the
        /// --tmpfs option to docker run.
        /// Note If you are using tasks that use the Fargate launch type, the tmpfs parameter is not supported.
        /// Required: No
        /// Type: List of Tmpfs
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tmpfs")]
        public List<Tmpfs> Tmpfs { get; set; }

    }
}
