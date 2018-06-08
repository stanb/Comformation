using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition KernelCapabilities
    /// The KernelCapabilities property type specifies the Linux capabilities to add or drop from the default Docker
    /// configuration in an Amazon Elastic Container Service (Amazon ECS) container. For more information, see
    /// KernelCapabilities in the Amazon Elastic Container Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-kernelcapabilities.html
    /// </summary>
    public class KernelCapabilities
    {

        /// <summary>
        /// Add
        /// The Linux capabilities to add to the default Docker configuration. This maps to CapAdd in the Create
        /// a container section of the Docker Remote API and the --cap-add option to docker run. For valid
        /// values, see KernelCapabilities in the Amazon Elastic Container Service API Reference.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Add")]
        public Union<List<string>, IntrinsicFunction> Add { get; set; }

        /// <summary>
        /// Drop
        /// The Linux capabilities to remove from the default Docker configuration. This maps to CapDrop in the
        /// Create a container section of the Docker Remote API and the --cap-drop option to docker run. For
        /// valid values, see KernelCapabilities in the Amazon Elastic Container Service API Reference.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Drop")]
        public Union<List<string>, IntrinsicFunction> Drop { get; set; }

    }
}
