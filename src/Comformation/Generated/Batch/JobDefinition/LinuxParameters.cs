using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition LinuxParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html
    /// </summary>
    public class LinuxParameters
    {

        /// <summary>
        /// Swappiness
        /// This allows you to tune a container&#39;s memory swappiness behavior. A swappiness value of 0 causes
        /// swapping not to happen unless absolutely necessary. A swappiness value of 100 causes pages to be
        /// swapped very aggressively. Accepted values are whole numbers between 0 and 100. If the swappiness
        /// parameter isn&#39;t specified, a default value of 60 is used. If a value isn&#39;t specified for maxSwap
        /// then this parameter is ignored. If maxSwap is set to 0, the container doesn&#39;t use swap. This
        /// parameter maps to the --memory-swappiness option to docker run.
        /// Consider the following when you use a per-container swap configuration.
        /// Swap space must be enabled and allocated on the container instance for the containers to use. Note
        /// The Amazon ECS optimized AMIs don&#39;t have swap enabled by default. You must enable swap on the
        /// instance to use this feature. For more information, see Instance Store Swap Volumes in the Amazon
        /// EC2 User Guide for Linux Instances or How do I allocate memory to work as swap space in an Amazon
        /// EC2 instance by using a swap file? The swap space parameters are only supported for job definitions
        /// using EC2 resources. If the maxSwap and swappiness parameters are omitted from a job definition,
        /// each container will have a default swappiness value of 60 and the total swap usage will be limited
        /// to two times the memory reservation of the container.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Swappiness")]
        public Union<int, IntrinsicFunction> Swappiness { get; set; }

        /// <summary>
        /// Tmpfs
        /// The container path, mount options, and size (in MiB) of the tmpfs mount. This parameter maps to the
        /// --tmpfs option to docker run.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: List of Tmpfs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tmpfs")]
        public List<Tmpfs> Tmpfs { get; set; }

        /// <summary>
        /// SharedMemorySize
        /// The value for the size (in MiB) of the /dev/shm volume. This parameter maps to the --shm-size option
        /// to docker run.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SharedMemorySize")]
        public Union<int, IntrinsicFunction> SharedMemorySize { get; set; }

        /// <summary>
        /// Devices
        /// Any host devices to expose to the container. This parameter maps to Devices in the Create a
        /// container section of the Docker Remote API and the --device option to docker run.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: List of Device
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Devices")]
        public List<Device> Devices { get; set; }

        /// <summary>
        /// InitProcessEnabled
        /// If true, run an init process inside the container that forwards signals and reaps processes. This
        /// parameter maps to the --init option to docker run. This parameter requires version 1. 25 of the
        /// Docker Remote API or greater on your container instance. To check the Docker Remote API version on
        /// your container instance, log into your container instance and run the following command: sudo docker
        /// version | grep &quot;Server API version&quot;
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InitProcessEnabled")]
        public Union<bool, IntrinsicFunction> InitProcessEnabled { get; set; }

        /// <summary>
        /// MaxSwap
        /// The total amount of swap memory (in MiB) a container can use. This parameter is translated to the
        /// --memory-swap option to docker run where the value is the sum of the container memory plus the
        /// maxSwap value. For more information, see --memory-swap details in the Docker documentation.
        /// If a maxSwap value of 0 is specified, the container doesn&#39;t use swap. Accepted values are 0 or any
        /// positive integer. If the maxSwap parameter is omitted, the container doesn&#39;t use the swap
        /// configuration for the container instance it is running on. A maxSwap value must be set for the
        /// swappiness parameter to be used.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxSwap")]
        public Union<int, IntrinsicFunction> MaxSwap { get; set; }

    }
}
