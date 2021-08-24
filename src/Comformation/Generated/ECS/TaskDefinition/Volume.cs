using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Volume
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// DockerVolumeConfiguration
        /// 		
        /// This parameter is specified when you are using Docker volumes.
        /// 		
        /// Windows containers only support the use of the local driver. To use bind 			mounts, specify the host
        /// parameter instead.
        /// 		
        /// Note Docker volumes are not supported by tasks run on AWS Fargate.
        /// 	
        /// Required: No
        /// Type: DockerVolumeConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DockerVolumeConfiguration")]
        public DockerVolumeConfiguration DockerVolumeConfiguration { get; set; }

        /// <summary>
        /// EFSVolumeConfiguration
        /// 		
        /// This parameter is specified when you are using an Amazon Elastic File System file system for task
        /// 			storage.
        /// 	
        /// Required: No
        /// Type: EFSVolumeConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EFSVolumeConfiguration")]
        public EFSVolumeConfiguration EFSVolumeConfiguration { get; set; }

        /// <summary>
        /// Host
        /// 		
        /// This parameter is specified when you are using bind mount host volumes. The contents 			of the host
        /// parameter determine whether your bind mount host volume 			persists on the host container instance
        /// and where it is stored. If the host 			parameter is empty, then the Docker daemon assigns a host
        /// path for your data volume. 			However, the data is not guaranteed to persist after the containers
        /// associated with it 			stop running.
        /// 		
        /// Windows containers can mount whole directories on the same drive as 				$env:ProgramData. Windows
        /// containers cannot mount directories on a 			different drive, and mount point cannot be across
        /// drives. For example, you can mount 				C:\my\path:C:\my\path and D:\:D:\, but not
        /// 				D:\my\path:C:\my\path or D:\:C:\my\path.
        /// 	
        /// Required: No
        /// Type: HostVolumeProperties
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Host")]
        public HostVolumeProperties Host { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, underscores, and
        /// hyphens are allowed. This name is referenced in the 				sourceVolume parameter of container
        /// definition 			mountPoints.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
