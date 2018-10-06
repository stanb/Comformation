using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition Volumes
    /// Volumes is a property of the AWS::ECS::TaskDefinition resource that specifies a list of data volumes, which
    /// your containers can then access.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// DockerVolumeConfiguration
        /// Specifies the configuration of a Docker volume. This parameter is specified when using Docker
        /// volumes. Docker volumes are only supported when using the EC2 launch type. Windows containers only
        /// support the use of the local driver. To use bind mounts, specify a host instead.
        /// Required: No
        /// Type: Amazon ECS TaskDefinition DockerVolumeConfiguration
        /// </summary>
        [JsonProperty("DockerVolumeConfiguration")]
        public DockerVolumeConfiguration DockerVolumeConfiguration { get; set; }

        /// <summary>
        /// Host
        /// Determines whether your data volume persists on the host container instance and at the location
        /// where it is stored.
        /// Required: No
        /// Type: Amazon Elastic Container Service TaskDefinition Volumes Host
        /// </summary>
        [JsonProperty("Host")]
        public HostVolumeProperties Host { get; set; }

        /// <summary>
        /// Name
        /// The name of the volume. To specify mount points in your container definitions, use the value of this
        /// property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
