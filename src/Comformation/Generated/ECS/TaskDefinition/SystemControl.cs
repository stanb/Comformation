using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition SystemControl
    /// A list of namespaced kernel parameters to set in the container. This parameter maps to Sysctls in the Create a
    /// container section of the Docker Remote API and the --sysctl option to docker run.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-systemcontrol.html
    /// </summary>
    public class SystemControl
    {

        /// <summary>
        /// Namespace
        /// The namespaced kernel parameter for which to set a value.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// Value
        /// The value for the namespaced kernel parameter specified in namespace.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
