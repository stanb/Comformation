using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition ResourceRequirement
    /// The type and amount of a resource to assign to a container. Currently, the only supported resource type is
    /// GPU.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-resourcerequirement.html
    /// </summary>
    public class ResourceRequirement
    {

        /// <summary>
        /// Type
        /// The type of resource to assign to a container. Currently, the only supported resource type is GPU.
        /// Required: No
        /// Type: String
        /// Allowed Values: GPU
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The number of physical GPUs to reserve for the container. The number of GPUs reserved for all
        /// containers in a job should not exceed the number of available GPUs on the compute resource that the
        /// job is launched on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
