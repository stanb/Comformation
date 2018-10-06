using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon ECS TaskDefinition DockerVolumeConfiguration
    /// The DockerVolumeConfiguration property type specifies the configuration of a Docker volume. This parameter is
    /// specified when using Docker volumes. Docker volumes are only supported when using the EC2 launch type. Windows
    /// containers only support the use of the local driver. To use bind mounts, specify a host instead.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html
    /// </summary>
    public class DockerVolumeConfiguration
    {

        /// <summary>
        /// Autoprovision
        /// If true, the Docker volume is created if it does not already exist. This field is only used if the
        /// scope is shared.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Autoprovision")]
        public Union<bool, IntrinsicFunction> Autoprovision { get; set; }

        /// <summary>
        /// Driver
        /// The Docker volume driver to use. The driver value must match the driver name provided by Docker
        /// because it is used for task placement. For more information, see DockerVolumeConfiguration in the
        /// Amazon Elastic Container Service API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Driver")]
        public Union<string, IntrinsicFunction> Driver { get; set; }

        /// <summary>
        /// DriverOpts
        /// A map of Docker driver specific options passed through. For more information, see
        /// DockerVolumeConfiguration in the Amazon Elastic Container Service API Reference.
        /// Duplicate values are not allowed.
        /// Required: No
        /// Type: List of Strings
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DriverOpts")]
        public Dictionary<string, Union<string, IntrinsicFunction>> DriverOpts { get; set; }

        /// <summary>
        /// Labels
        /// Custom metadata to add to your Docker volume. For more information, see DockerVolumeConfiguration in
        /// the Amazon Elastic Container Service API Reference.
        /// Duplicate values are not allowed.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Labels")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Labels { get; set; }

        /// <summary>
        /// Scope
        /// The scope for the Docker volume which determines it&#39;s lifecycle. Docker volumes that are scoped to a
        /// task are automatically provisioned when the task starts and destroyed when the task stops. Docker
        /// volumes that are scoped as shared persist after the task stops.
        /// Valid values include shared and task.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

    }
}
