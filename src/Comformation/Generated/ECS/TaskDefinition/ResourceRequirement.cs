using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition ResourceRequirement
    /// The ResourceRequirement property specifies the type and amount of a resource to assign to a container. The
    /// only supported resource is a GPU. For more information, see Working with GPUs on Amazon ECS in the Amazon
    /// Elastic Container Service Developer Guide
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-resourcerequirement.html
    /// </summary>
    public class ResourceRequirement
    {

        /// <summary>
        /// Type
        /// The type of resource to assign to a container. The supported values are GPU or InferenceAccelerator.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: GPU | InferenceAccelerator
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The value for the specified resource type.
        /// If the GPU type is used, the value is the number of physical GPUs the Amazon ECS container agent
        /// will reserve for the container. The number of GPUs reserved for all containers in a task should not
        /// exceed the number of available GPUs on the container instance the task is launched on.
        /// If the InferenceAccelerator type is used, the value should match the deviceName for an
        /// InferenceAccelerator specified in a task definition.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
