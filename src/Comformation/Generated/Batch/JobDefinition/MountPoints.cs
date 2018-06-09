using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition MountPoints
    /// The MountPoints property type specifies mount points for data volumes in your container. This parameter maps
    /// to Volumes in the Create a container section of the Docker Remote API and the --volume option to docker run.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html
    /// </summary>
    public class MountPoints
    {

        /// <summary>
        /// ReadOnly
        /// If this value is true, the container has read-only access to the volume; otherwise, the container
        /// can write to the volume. The default value is false.
        /// Required: no
        /// Type: Boolean
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Union<bool, IntrinsicFunction> ReadOnly { get; set; }

        /// <summary>
        /// SourceVolume
        /// The name of the volume to mount.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("SourceVolume")]
        public Union<string, IntrinsicFunction> SourceVolume { get; set; }

        /// <summary>
        /// ContainerPath
        /// The path on the container at which to mount the host volume.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

    }
}
