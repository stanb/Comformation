using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition VolumesHost
    /// The VolumesHost property type specifies whether your data volume persists on the host container instance and
    /// where it is stored. If the host parameter is empty, then the Docker daemon assigns a host path for your data
    /// volume, but the data is not guaranteed to persist after the containers associated with it stop running.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html
    /// </summary>
    public class VolumesHost
    {

        /// <summary>
        /// SourcePath
        /// The path on the host container instance that is presented to the container. If this parameter is
        /// empty, then the Docker daemon has assigned a host path for you. If the VolumesHost parameter
        /// contains a SourcePath file location, then the data volume persists at the specified location on the
        /// host container instance until you delete it manually. If the SourcePath value does not exist on the
        /// host container instance, the Docker daemon creates it. If the location does exist, the contents of
        /// the source path folder are exported.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

    }
}
