using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition HostEntry
    /// HostEntry is a property of the Amazon Elastic Container Service TaskDefinition ContainerDefinition property
    /// that specifies the hostnames and IP address entries to add to the Amazon Elastic Container Service (Amazon
    /// ECS) container&#39;s /etc/hosts file.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-hostentry.html
    /// </summary>
    public class HostEntry
    {

        /// <summary>
        /// Hostname
        /// The hostname to use in the /etc/hosts file.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// IpAddress
        /// The IP address to use in the /etc/hosts file.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IpAddress")]
        public Union<string, IntrinsicFunction> IpAddress { get; set; }

    }
}
