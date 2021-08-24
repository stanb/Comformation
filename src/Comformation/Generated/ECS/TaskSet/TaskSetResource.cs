using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskSet
{
    /// <summary>
    /// AWS::ECS::TaskSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html
    /// </summary>
    public class TaskSetResource : ResourceBase
    {
        public class TaskSetProperties
        {
            /// <summary>
            /// Cluster
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service to create
            /// the 			task set in.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            /// ExternalId
            /// 		
            /// An optional non-unique tag that identifies this task set in external systems. If the 			task set is
            /// associated with a service discovery registry, the tasks in this task set 			will have the
            /// ECS_TASK_SET_EXTERNAL_ID AWS Cloud Map attribute set to the provided 			value.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExternalId { get; set; }

            /// <summary>
            /// LaunchType
            /// 		
            /// The launch type that new tasks in the task set will use. For more information, see 				Amazon ECS
            /// Launch Types in the Amazon Elastic Container Service Developer Guide.
            /// 		
            /// If a launchType is specified, the capacityProviderStrategy 			parameter must be omitted.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: EC2 | EXTERNAL | FARGATE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LaunchType { get; set; }

            /// <summary>
            /// LoadBalancers
            /// 		
            /// A load balancer object representing the load balancer to use with the task set. The 			supported
            /// load balancer types are either an Application Load Balancer or a Network Load Balancer.
            /// 	
            /// Required: No
            /// Type: List of LoadBalancer
            /// Update requires: Replacement
            /// </summary>
            public List<LoadBalancer> LoadBalancers { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// 		
            /// The network configuration for the task set.
            /// 	
            /// Required: No
            /// Type: NetworkConfiguration
            /// Update requires: Replacement
            /// </summary>
            public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// PlatformVersion
            /// 		
            /// The platform version that the tasks in the task set should use. A platform version is 			specified
            /// only for tasks using the Fargate launch type. If one isn&#39;t 			specified, the LATEST platform version
            /// is used by default.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

            /// <summary>
            /// Scale
            /// 		
            /// A floating-point percentage of the desired number of tasks to place and keep running 			in the task
            /// set.
            /// 	
            /// Required: No
            /// Type: Scale
            /// Update requires: No interruption
            /// </summary>
            public Scale Scale { get; set; }

            /// <summary>
            /// Service
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the service to create the task set in.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Service { get; set; }

            /// <summary>
            /// ServiceRegistries
            /// 		
            /// The details of the service discovery registries to assign to this task set. For more 			information,
            /// see Service 				Discovery.
            /// 	
            /// Required: No
            /// Type: List of ServiceRegistry
            /// Update requires: Replacement
            /// </summary>
            public List<ServiceRegistry> ServiceRegistries { get; set; }

            /// <summary>
            /// TaskDefinition
            /// 		
            /// The task definition for the tasks in the task set to use.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TaskDefinition { get; set; }

        }

        public string Type { get; } = "AWS::ECS::TaskSet";

        public TaskSetProperties Properties { get; } = new TaskSetProperties();

    }

    public static class TaskSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
