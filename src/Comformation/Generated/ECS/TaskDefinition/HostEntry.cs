using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition HostEntry
    /// The HostEntry property specifies a hostname and an IP address that are added to the /etc/hosts file of a
    /// container through the extraHosts parameter of its ContainerDefinition resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-hostentry.html
    /// </summary>
    public class HostEntry
    {

        /// <summary>
        /// Hostname
        /// The hostname to use in the /etc/hosts entry.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// IpAddress
        /// The IP address to use in the /etc/hosts entry.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IpAddress")]
        public Union<string, IntrinsicFunction> IpAddress { get; set; }

    }
}
