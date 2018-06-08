using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition PortMapping
    /// PortMappings is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition property
    /// that maps a container port to a host port.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-portmappings.html
    /// </summary>
    public class PortMapping
    {

        /// <summary>
        /// ContainerPort
        /// The port number on the container bound to the host port.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        /// HostPort
        /// The host port number on the container instance that you want to reserve for your container. You can
        /// specify a non-reserved host port for your container port mapping, omit the host port, or set the
        /// host port to 0. If you specify a container port but no host port, your container host port is
        /// assigned automatically .
        /// Don't specify a host port in the 49153 to 65535 port range; these ports are reserved for automatic
        /// assignment. Other reserved ports include 22 for SSH, 2375 and 2376 for Docker, and 51678 for the
        /// Amazon Elastic Container Service container agent. Don't specify a host port that is being used for a
        /// task—that port is reserved while the task is running.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("HostPort")]
        public Union<int, IntrinsicFunction> HostPort { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol used for the port mapping. For valid values, see the protocol parameter in the Amazon
        /// Elastic Container Service Developer Guide. By default, AWS CloudFormation specifies tcp.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
