using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskSet
{
    /// <summary>
    /// AWS::ECS::TaskSet ServiceRegistry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-serviceregistry.html
    /// </summary>
    public class ServiceRegistry
    {

        /// <summary>
        /// ContainerName
        /// 		
        /// The container name value, already specified in the task definition, to be used for 			your service
        /// discovery service. If the task definition that your service task specifies 			uses the bridge or
        /// host network mode, you must specify a 				containerName and containerPort combination from the task
        /// 			definition. If the task definition that your service task specifies uses the 				awsvpc network
        /// mode and a type SRV DNS record is used, you must specify 			either a containerName and containerPort
        /// combination or a 				port value, but not both.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        /// ContainerPort
        /// 		
        /// The port value, already specified in the task definition, to be used for your service 			discovery
        /// service. If the task definition your service task specifies uses the 				bridge or host network
        /// mode, you must specify a 				containerName and containerPort combination from the task
        /// 			definition. If the task definition your service task specifies uses the 				awsvpc network mode
        /// and a type SRV DNS record is used, you must specify 			either a containerName and containerPort
        /// combination or a 				port value, but not both.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        /// Port
        /// 		
        /// The port value used if your service discovery service specified an SRV record. This 			field may be
        /// used if both the awsvpc network mode and SRV records are 			used.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// RegistryArn
        /// 		
        /// The Amazon Resource Name (ARN) of the service registry. The currently supported service registry is
        /// 			AWS Cloud Map. For more information, see CreateService.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RegistryArn")]
        public Union<string, IntrinsicFunction> RegistryArn { get; set; }

    }
}
