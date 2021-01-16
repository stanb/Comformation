using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition HostEntry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-hostentry.html
    /// </summary>
    public class HostEntry
    {

        /// <summary>
        /// Hostname
        /// 		
        /// The hostname to use in the /etc/hosts entry.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// IpAddress
        /// 		
        /// The IP address to use in the /etc/hosts entry.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IpAddress")]
        public Union<string, IntrinsicFunction> IpAddress { get; set; }

    }
}
