using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition Volumes
    /// Volumes is a property of the AWS::ECS::TaskDefinition resource that specifies a list of data volumes, which
    /// your containers can then access.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumes.html
    /// </summary>
    public class Volume
    {

        /// <summary>
        /// Host
        /// Determines whether your data volume persists on the host container instance and at the location
        /// where it is stored.
        /// Required: No
        /// Type: Amazon Elastic Container Service TaskDefinition Volumes Host
        /// </summary>
        [JsonProperty("Host")]
        public Union<HostVolumeProperties, IntrinsicFunction> Host { get; set; }

        /// <summary>
        /// Name
        /// The name of the volume. To specify mount points in your container definitions, use the value of this
        /// property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
