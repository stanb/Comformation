using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition HostVolumeProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes-host.html
    /// </summary>
    public class HostVolumeProperties
    {

        /// <summary>
        /// SourcePath
        /// 		
        /// When the host parameter is used, specify a sourcePath to 			declare the path on the host container
        /// instance that is presented to the container. If 			this parameter is empty, then the Docker daemon
        /// has assigned a host path for you. If the 				host parameter contains a sourcePath file location,
        /// then 			the data volume persists at the specified location on the host container instance until
        /// 			you delete it manually. If the sourcePath value does not exist on the host 			container instance,
        /// the Docker daemon creates it. If the location does exist, the 			contents of the source path folder
        /// are exported.
        /// 		
        /// If you are using the Fargate launch type, the sourcePath 			parameter is not supported.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourcePath")]
        public Union<string, IntrinsicFunction> SourcePath { get; set; }

    }
}
