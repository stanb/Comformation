using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition VolumeFrom
    /// The VolumeFrom property specifies details on a data volume from another container in the same task definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-volumesfrom.html
    /// </summary>
    public class VolumeFrom
    {

        /// <summary>
        /// ReadOnly
        /// If this value is true, the container has read-only access to the volume. If this value is false,
        /// then the container can write to the volume. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Union<bool, IntrinsicFunction> ReadOnly { get; set; }

        /// <summary>
        /// SourceContainer
        /// The name of another container within the same task definition from which to mount volumes.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourceContainer")]
        public Union<string, IntrinsicFunction> SourceContainer { get; set; }

    }
}
