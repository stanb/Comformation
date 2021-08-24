using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition EphemeralStorage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-ephemeralstorage.html
    /// </summary>
    public class EphemeralStorage
    {

        /// <summary>
        /// SizeInGiB
        /// 		
        /// The total amount, in GiB, of ephemeral storage to set for the task. The minimum 			supported value
        /// is 21 GiB and the maximum supported value is 				200 GiB.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SizeInGiB")]
        public Union<int, IntrinsicFunction> SizeInGiB { get; set; }

    }
}
