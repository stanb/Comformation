using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition DockerVolumeConfiguration
    /// The DockerVolumeConfiguration property specifies a Docker volume configuration and is used when you use Docker
    /// volumes. Docker volumes are only supported when you are using the EC2 launch type. Windows containers only
    /// support the use of the local driver. To use bind mounts, specify a host instead.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html
    /// </summary>
    public class DockerVolumeConfiguration
    {

        /// <summary>
        /// Autoprovision
        /// If this value is true, the Docker volume is created if it does not already exist.
        /// Note This field is only used if the scope is shared.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Autoprovision")]
        public Union<bool, IntrinsicFunction> Autoprovision { get; set; }

        /// <summary>
        /// Driver
        /// The Docker volume driver to use. The driver value must match the driver name provided by Docker
        /// because it is used for task placement. If the driver was installed using the Docker plugin CLI, use
        /// docker plugin ls to retrieve the driver name from your container instance. If the driver was
        /// installed using another method, use Docker plugin discovery to retrieve the driver name. For more
        /// information, see Docker plugin discovery. This parameter maps to Driver in the Create a volume
        /// section of the Docker Remote API and the xxdriver option to docker volume create.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Driver")]
        public Union<string, IntrinsicFunction> Driver { get; set; }

        /// <summary>
        /// DriverOpts
        /// A map of Docker driver-specific options passed through. This parameter maps to DriverOpts in the
        /// Create a volume section of the Docker Remote API and the xxopt option to docker volume create.
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DriverOpts")]
        public Dictionary<string, Union<string, IntrinsicFunction>> DriverOpts { get; set; }

        /// <summary>
        /// Labels
        /// Custom metadata to add to your Docker volume. This parameter maps to Labels in the Create a volume
        /// section of the Docker Remote API and the xxlabel option to docker volume create.
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Labels")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Labels { get; set; }

        /// <summary>
        /// Scope
        /// The scope for the Docker volume that determines its lifecycle. Docker volumes that are scoped to a
        /// task are automatically provisioned when the task starts and destroyed when the task stops. Docker
        /// volumes that are scoped as shared persist after the task stops.
        /// Required: No
        /// Type: String
        /// Allowed Values: shared | task
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

    }
}
