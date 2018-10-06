using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition Volumes
    /// The Volumes property type specifies data volumes for containers to use in a job definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html
    /// </summary>
    public class Volumes
    {

        /// <summary>
        /// Host
        /// The contents of the Host parameter determine whether your data volume persists on the host container
        /// instance and where it is stored. If the host parameter is empty, then the Docker daemon assigns a
        /// host path for your data volume, but the data is not guaranteed to persist after the containers
        /// associated with it stop running.
        /// Required: no
        /// Type: AWS Batch JobDefinition VolumesHost
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Host")]
        public VolumesHost Host { get; set; }

        /// <summary>
        /// Name
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, hyphens, and
        /// underscores are allowed. This name is referenced in the SourceVolume parameter of container
        /// definition MountPoints.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
