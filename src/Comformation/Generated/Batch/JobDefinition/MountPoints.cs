using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition MountPoints
    /// Details on a Docker volume mount point that is used in a job&#39;s container properties. This parameter maps to
    /// Volumes in the Create a container section of the Docker Remote API and the --volume option to docker run.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html
    /// </summary>
    public class MountPoints
    {

        /// <summary>
        /// ReadOnly
        /// If this value is true, the container has read-only access to the volume; otherwise, the container
        /// can write to the volume. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Union<bool, IntrinsicFunction> ReadOnly { get; set; }

        /// <summary>
        /// SourceVolume
        /// The name of the volume to mount.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceVolume")]
        public Union<string, IntrinsicFunction> SourceVolume { get; set; }

        /// <summary>
        /// ContainerPath
        /// The path on the container at which to mount the host volume.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

    }
}
