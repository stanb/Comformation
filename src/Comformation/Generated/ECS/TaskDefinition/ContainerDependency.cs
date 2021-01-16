using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition ContainerDependency
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdependency.html
    /// </summary>
    public class ContainerDependency
    {

        /// <summary>
        /// ContainerName
        /// 		
        /// The name of a container.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        /// Condition
        /// 		
        /// The dependency condition of the container. The following are the available conditions 			and their
        /// behavior:
        /// 		
        /// 			 			 			 			 		 				 START - This condition emulates the behavior of links and 					volumes
        /// today. It validates that a dependent container is started before 					permitting other containers to
        /// start. 			 				 COMPLETE - This condition validates that a dependent 					container runs to
        /// completion (exits) before permitting other containers to 					start. This can be useful for
        /// nonessential containers that run a script and then 					exit. This condition cannot be set on an
        /// essential container. 			 				 SUCCESS - This condition is the same as 						COMPLETE, but it also
        /// requires that the container exits with a 						zero status. This condition cannot be set on an
        /// essential 					container. 			 				 HEALTHY - This condition validates that the dependent
        /// 					container passes its Docker health check before permitting other containers to 					start. This
        /// requires that the dependent container has health checks configured. 					This condition is confirmed
        /// only at task startup. 			
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: COMPLETE | HEALTHY | START | SUCCESS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

    }
}
