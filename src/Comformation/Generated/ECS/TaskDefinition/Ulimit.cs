using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Ulimit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-ulimit.html
    /// </summary>
    public class Ulimit
    {

        /// <summary>
        /// HardLimit
        /// 		
        /// The hard limit for the ulimit type.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HardLimit")]
        public Union<int, IntrinsicFunction> HardLimit { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// The type of the ulimit.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: core | cpu | data | fsize | locks | memlock | msgqueue | nice | nofile | nproc | rss
        /// | rtprio | rttime | sigpending | stack
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// SoftLimit
        /// 		
        /// The soft limit for the ulimit type.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SoftLimit")]
        public Union<int, IntrinsicFunction> SoftLimit { get; set; }

    }
}
