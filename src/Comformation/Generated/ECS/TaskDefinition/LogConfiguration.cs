using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition LogConfiguration
    /// LogConfiguration is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition
    /// property that configures a custom log driver for an Amazon Elastic Container Service (Amazon ECS) container.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// LogDriver
        /// The log driver to use for the container. This parameter requires that your container instance uses
        /// Docker Remote API Version 1. 18 or greater. For more information, see the logDriver content for the
        /// LogConfiguration data type in the Amazon Elastic Container Service API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("LogDriver")]
        public Union<string, IntrinsicFunction> LogDriver { get; set; }

        /// <summary>
        /// Options
        /// The configuration options to send to the log driver. This parameter requires that your container
        /// instance uses Docker Remote API Version 1. 18 or greater.
        /// Required: No
        /// Type: Key-value pairs, with the option name as the key and the option value as the value.
        /// </summary>
        [JsonProperty("Options")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Options { get; set; }

    }
}
