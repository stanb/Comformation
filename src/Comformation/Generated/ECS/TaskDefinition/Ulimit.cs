using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition Ulimit
    /// Ulimit is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition property that
    /// specifies resource limits for an Amazon Elastic Container Service (Amazon ECS) container.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-ulimit.html
    /// </summary>
    public class Ulimit
    {

        /// <summary>
        /// HardLimit
        /// The hard limit for the ulimit type.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("HardLimit")]
        public Union<int, IntrinsicFunction> HardLimit { get; set; }

        /// <summary>
        /// Name
        /// The type of ulimit. For valid values, see the name content for the Ulimit data type in the Amazon
        /// Elastic Container Service API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// SoftLimit
        /// The soft limit for the ulimit type.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("SoftLimit")]
        public Union<int, IntrinsicFunction> SoftLimit { get; set; }

    }
}
