using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition Volumes
    /// A list of volumes associated with the job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html
    /// </summary>
    public class Volumes
    {

        /// <summary>
        /// Host
        /// The contents of the host parameter determine whether your data volume persists on the host container
        /// instance and where it is stored. If the host parameter is empty, then the Docker daemon assigns a
        /// host path for your data volume. However, the data is not guaranteed to persist after the containers
        /// associated with it stop running.
        /// Required: No
        /// Type: VolumesHost
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public VolumesHost Host { get; set; }

        /// <summary>
        /// Name
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, hyphens, and
        /// underscores are allowed. This name is referenced in the sourceVolume parameter of container
        /// definition mountPoints.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
