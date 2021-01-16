using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition LinuxParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html
    /// </summary>
    public class LinuxParameters
    {

        /// <summary>
        /// Capabilities
        /// 		
        /// The Linux capabilities for the container that are added to or dropped from the default
        /// 			configuration provided by Docker.
        /// 		
        /// Note For tasks that use the Fargate launch type, 					capabilities is supported for all platform
        /// versions but the 					add parameter is only supported if using platform version 1. 4. 0 or
        /// 				later.
        /// 	
        /// Required: No
        /// Type: KernelCapabilities
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Capabilities")]
        public KernelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Devices
        /// 		
        /// Any host devices to expose to the container. This parameter maps to 				Devices in the Create a
        /// container section of the 			Docker Remote API and the --device option to docker run.
        /// 		
        /// Note If you are using tasks that use the Fargate launch type, the 					devices parameter is not
        /// supported.
        /// 	
        /// Required: No
        /// Type: List of Device
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Devices")]
        public List<Device> Devices { get; set; }

        /// <summary>
        /// InitProcessEnabled
        /// 		
        /// Run an init process inside the container that forwards signals and reaps 			processes. This
        /// parameter maps to the --init option to docker run. This parameter requires version 1. 25 of the
        /// Docker Remote API or greater on your container instance. To check the Docker Remote API version on
        /// your container instance, log in to your container instance and run the following command: sudo
        /// docker version --format &#39;{{. Server. APIVersion}}&#39;
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitProcessEnabled")]
        public Union<bool, IntrinsicFunction> InitProcessEnabled { get; set; }

        /// <summary>
        /// MaxSwap
        /// 		
        /// The total amount of swap memory (in MiB) a container can use. This parameter will be 			translated
        /// to the --memory-swap option to docker run where the value would be the sum of 			the container
        /// memory plus the maxSwap value.
        /// 		
        /// If a maxSwap value of 0 is specified, the container will not 			use swap. Accepted values are 0 or
        /// any positive integer. If the 				maxSwap parameter is omitted, the container will use the swap
        /// 			configuration for the container instance it is running on. A maxSwap value 			must be set for the
        /// swappiness parameter to be used.
        /// 		
        /// Note If you are using tasks that use the Fargate launch type, the 					maxSwap parameter is not
        /// supported.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MaxSwap")]
        public Union<int, IntrinsicFunction> MaxSwap { get; set; }

        /// <summary>
        /// SharedMemorySize
        /// 		
        /// The value for the size (in MiB) of the /dev/shm volume. This parameter 			maps to the --shm-size
        /// option to docker 				run.
        /// 		
        /// Note If you are using tasks that use the Fargate launch type, the 					sharedMemorySize parameter is
        /// not supported.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SharedMemorySize")]
        public Union<int, IntrinsicFunction> SharedMemorySize { get; set; }

        /// <summary>
        /// Swappiness
        /// 		
        /// This allows you to tune a container&#39;s memory swappiness behavior. A 				swappiness value of 0 will
        /// cause swapping to not happen 			unless absolutely necessary. A swappiness value of 100 will 			cause
        /// pages to be swapped very aggressively. Accepted values are whole numbers between 				0 and 100. If
        /// the swappiness parameter is not 			specified, a default value of 60 is used. If a value is not
        /// specified for 				maxSwap then this parameter is ignored. This parameter maps to the
        /// 				--memory-swappiness option to docker run.
        /// 		
        /// Note If you are using tasks that use the Fargate launch type, the 					swappiness parameter is not
        /// supported.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Swappiness")]
        public Union<int, IntrinsicFunction> Swappiness { get; set; }

        /// <summary>
        /// Tmpfs
        /// 		
        /// The container path, mount options, and size (in MiB) of the tmpfs mount. This 			parameter maps to
        /// the --tmpfs option to docker run.
        /// 		
        /// Note If you are using tasks that use the Fargate launch type, the 					tmpfs parameter is not
        /// supported.
        /// 	
        /// Required: No
        /// Type: List of Tmpfs
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tmpfs")]
        public List<Tmpfs> Tmpfs { get; set; }

    }
}
