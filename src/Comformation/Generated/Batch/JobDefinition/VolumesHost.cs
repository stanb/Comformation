using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition VolumesHost
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html
    /// </summary>
    public class VolumesHost
    {

        /// <summary>
        /// SourcePath
        /// The path on the host container instance that&#39;s presented to the container. If this parameter is
        /// empty, then the Docker daemon has assigned a host path for you. If this parameter contains a file
        /// location, then the data volume persists at the specified location on the host container instance
        /// until you delete it manually. If the source path location doesn&#39;t exist on the host container
        /// instance, the Docker daemon creates it. If the location does exist, the contents of the source path
        /// folder are exported.
        /// Note This parameter isn&#39;t applicable to jobs that run on Fargate resources and shouldn&#39;t be
        /// provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

    }
}
