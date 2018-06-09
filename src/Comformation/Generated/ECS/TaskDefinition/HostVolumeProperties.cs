using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition Volumes Host
    /// Host is a property of the Amazon Elastic Container Service TaskDefinition Volumes property that specifies the
    /// data volume path on the host container instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes-host.html
    /// </summary>
    public class HostVolumeProperties
    {

        /// <summary>
        /// SourcePath
        /// The data volume path on the host container instance.
        /// If you don&#39;t specify this parameter, the Docker daemon assigns a path for you, but the data volume
        /// might not persist after the associated container stops running. If you do specify a path, the data
        /// volume persists at that location on the host container instance until you manually delete it.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

    }
}
