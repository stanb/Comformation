using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Volume
    /// The Volume property specifies a data volume used in a task definition. For tasks that use a Docker volume,
    /// specify a DockerVolumeConfiguration. For tasks that use a bind mount host volume, specify a host and optional
    /// sourcePath. For more information, see Using Data Volumes in Tasks.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// DockerVolumeConfiguration
        /// This parameter is specified when you are using Docker volumes. Docker volumes are only supported
        /// when you are using the EC2 launch type. Windows containers only support the use of the local driver.
        /// To use bind mounts, specify a host instead.
        /// Required: No
        /// Type: DockerVolumeConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DockerVolumeConfiguration")]
        public DockerVolumeConfiguration DockerVolumeConfiguration { get; set; }

        /// <summary>
        /// Host
        /// This parameter is specified when you are using bind mount host volumes. Bind mount host volumes are
        /// supported when you are using either the EC2 or Fargate launch types. The contents of the host
        /// parameter determine whether your bind mount host volume persists on the host container instance and
        /// where it is stored. If the host parameter is empty, then the Docker daemon assigns a host path for
        /// your data volume. However, the data is not guaranteed to persist after the containers associated
        /// with it stop running.
        /// Windows containers can mount whole directories on the same drive as $env:ProgramData. Windows
        /// containers cannot mount directories on a different drive, and mount point cannot be across drives.
        /// For example, you can mount C:\my\path:C:\my\path and D:\:D:\, but not D:\my\path:C:\my\path or
        /// D:\:C:\my\path.
        /// Required: No
        /// Type: HostVolumeProperties
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Host")]
        public HostVolumeProperties Host { get; set; }

        /// <summary>
        /// Name
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, and hyphens are
        /// allowed. This name is referenced in the sourceVolume parameter of container definition mountPoints.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
