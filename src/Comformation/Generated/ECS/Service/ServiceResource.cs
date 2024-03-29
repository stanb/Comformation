using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// CapacityProviderStrategy
            /// The capacity provider strategy to use for the service.
            /// A capacity provider strategy consists of one or more capacity providers along with the base and
            /// weight to assign to them. A capacity provider must be associated with the cluster to be used in a
            /// capacity provider strategy. The PutClusterCapacityProviders API is used to associate a capacity
            /// provider with a cluster. Only capacity providers with an ACTIVE or UPDATING status can be used.
            /// Review the Capacity provider considerations in the Amazon Elastic Container Service Developer Guide.
            /// If a capacityProviderStrategy is specified, the launchType parameter must be omitted. If no
            /// capacityProviderStrategy or launchType is specified, the defaultCapacityProviderStrategy for the
            /// cluster is used.
            /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider must
            /// already be created. New capacity providers can be created with the CreateCapacityProvider API
            /// operation.
            /// To use an AWS Fargate capacity provider, specify either the FARGATE or FARGATE_SPOT capacity
            /// providers. The AWS Fargate capacity providers are available to all accounts and only need to be
            /// associated with a cluster to be used.
            /// The PutClusterCapacityProviders API operation is used to update the list of available capacity
            /// providers for a cluster after the cluster is created.
            /// Required: No
            /// Type: List of CapacityProviderStrategyItem
            /// Update requires: No interruption
            /// </summary>
            public List<CapacityProviderStrategyItem> CapacityProviderStrategy { get; set; }

            /// <summary>
            /// Cluster
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the cluster on which to run your service. 			If
            /// you do not specify a cluster, the default cluster is assumed.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            /// DeploymentConfiguration
            /// 		
            /// Optional deployment parameters that control how many tasks run during the deployment 			and the
            /// ordering of stopping and starting tasks.
            /// 	
            /// Required: No
            /// Type: DeploymentConfiguration
            /// Update requires: No interruption
            /// </summary>
            public DeploymentConfiguration DeploymentConfiguration { get; set; }

            /// <summary>
            /// DeploymentController
            /// 		
            /// The deployment controller to use for the service. If no deployment controller is 			specified, the
            /// default value of ECS is used.
            /// 	
            /// Required: No
            /// Type: DeploymentController
            /// Update requires: Replacement
            /// </summary>
            public DeploymentController DeploymentController { get; set; }

            /// <summary>
            /// DesiredCount
            /// The number of instantiations of the specified task definition to place and keep running on your
            /// cluster.
            /// If a desired count is not specified, a default value of 1 is used. When using the DAEMON scheduling
            /// strategy, the desired count is not required.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DesiredCount { get; set; }

            /// <summary>
            /// EnableECSManagedTags
            /// 		
            /// Specifies whether to enable Amazon ECS managed tags for the tasks within the service. For 			more
            /// information, see Tagging Your Amazon ECS 				Resources in the Amazon Elastic Container Service
            /// Developer Guide.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableECSManagedTags { get; set; }

            /// <summary>
            /// EnableExecuteCommand
            /// 		
            /// Whether or not the execute command functionality is enabled for the service. If 				true, the
            /// execute command functionality is enabled for all containers 			in tasks as part of the service.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableExecuteCommand { get; set; }

            /// <summary>
            /// HealthCheckGracePeriodSeconds
            /// 		
            /// The period of time, in seconds, that the Amazon ECS service scheduler should ignore 			unhealthy
            /// Elastic Load Balancing target health checks after a task has first started. This is only used
            /// 			when your service is configured to use a load balancer. If your service has a load 			balancer
            /// defined and you don&#39;t specify a health check grace period value, the default 			value of 0 is used.
            /// 		
            /// If your service&#39;s tasks take a while to start and respond to Elastic Load Balancing health checks,
            /// you 			can specify a health check grace period of up to 2,147,483,647 seconds. During that 			time,
            /// the Amazon ECS service scheduler ignores health check status. This grace period can 			prevent the
            /// service scheduler from marking tasks as unhealthy and stopping them before 			they have time to come
            /// up.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckGracePeriodSeconds { get; set; }

            /// <summary>
            /// LaunchType
            /// The launch type on which to run your service. For more information, see Amazon ECS Launch Types in
            /// the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Allowed values: EC2 | EXTERNAL | FARGATE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LaunchType { get; set; }

            /// <summary>
            /// LoadBalancers
            /// A list of load balancer objects to associate with the service. If you specify the Role property,
            /// LoadBalancers must be specified as well. For information about the number of load balancers that you
            /// can specify per service, see Service Load Balancing in the Amazon Elastic Container Service
            /// Developer Guide.
            /// Required: No
            /// Type: List of LoadBalancer
            /// Update requires: Replacement
            /// </summary>
            public List<LoadBalancer> LoadBalancers { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// The network configuration for the service. This parameter is required for task definitions that use
            /// the awsvpc network mode to receive their own elastic network interface, and it is not supported for
            /// other network modes. For more information, see Task Networking in the Amazon Elastic Container
            /// Service Developer Guide.
            /// Required: Conditional
            /// Type: NetworkConfiguration
            /// Update requires: No interruption
            /// </summary>
            public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// PlacementConstraints
            /// 		
            /// An array of placement constraint objects to use for tasks in your service. You can 			specify a
            /// maximum of 10 constraints per task (this limit includes constraints in the 			task definition and
            /// those specified at runtime).
            /// 	
            /// Required: No
            /// Type: List of PlacementConstraint
            /// Update requires: Replacement
            /// </summary>
            public List<PlacementConstraint> PlacementConstraints { get; set; }

            /// <summary>
            /// PlacementStrategies
            /// The placement strategy objects to use for tasks in your service. You can specify a maximum of five
            /// strategy rules per service. For more information, see Task Placement Strategies in the Amazon
            /// Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: List of PlacementStrategy
            /// Update requires: Replacement
            /// </summary>
            public List<PlacementStrategy> PlacementStrategies { get; set; }

            /// <summary>
            /// PlatformVersion
            /// 		
            /// The platform version that your tasks in the service are running on. A platform version 			is
            /// specified only for tasks using the Fargate launch type. If one isn&#39;t 			specified, the LATEST
            /// platform version is used by default. For more 			information, see AWS Fargate platform 				versions
            /// in the Amazon Elastic Container Service Developer Guide.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

            /// <summary>
            /// PropagateTags
            /// Specifies whether to propagate the tags from the task definition or the service to the tasks in the
            /// service. If no value is specified, the tags are not propagated. Tags can only be propagated to the
            /// tasks within the service during service creation. To add tags to a task after service creation, use
            /// the TagResource API action.
            /// Required: No
            /// Type: String
            /// Allowed values: SERVICE | TASK_DEFINITION
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PropagateTags { get; set; }

            /// <summary>
            /// Role
            /// 		
            /// The name or full Amazon Resource Name (ARN) of the IAM role that allows Amazon ECS to make calls to
            /// your 			load balancer on your behalf. This parameter is only permitted if you are using a load
            /// 			balancer with your service and your task definition does not use the awsvpc 			network mode. If
            /// you specify the role parameter, you must also specify a 			load balancer object with the
            /// loadBalancers parameter.
            /// 		
            /// Important If your account has already created the Amazon ECS service-linked role, that role is
            /// 				used by default for your service unless you specify a role here. The service-linked 				role is
            /// required if your task definition uses the awsvpc network mode 				or if the service is configured to
            /// use service discovery, an external deployment 				controller, multiple target groups, or Elastic
            /// Inference accelerators in which case 				you should not specify a role here. For more information,
            /// see Using 					service-linked roles for Amazon ECS in the 					Amazon Elastic Container Service
            /// Developer Guide.
            /// 		
            /// If your specified role has a path other than /, then you must either 			specify the full role ARN
            /// (this is recommended) or prefix the role name with the path. 			For example, if a role with the name
            /// bar has a path of /foo/ 			then you would specify /foo/bar as the role name. For more information,
            /// see 				Friendly names and paths in the IAM User Guide.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// SchedulingStrategy
            /// 		
            /// The scheduling strategy to use for the service. For more information, see Services.
            /// 		
            /// There are two service scheduler strategies available:
            /// 		
            /// 			 			 		 				 REPLICA-The replica scheduling strategy places and 					maintains the desired number
            /// of tasks across your cluster. By default, the 					service scheduler spreads tasks across
            /// Availability Zones. You can use task 					placement strategies and constraints to customize task
            /// placement decisions. This 					scheduler strategy is required if the service is using the
            /// 						CODE_DEPLOY or EXTERNAL deployment controller 					types. 			 				 DAEMON-The daemon
            /// scheduling strategy deploys exactly one 					task on each active container instance that meets all
            /// of the task placement 					constraints that you specify in your cluster. The service scheduler also
            /// 					evaluates the task placement constraints for running tasks and will stop tasks 					that do not
            /// meet the placement constraints. When you&#39;re using this strategy, you 					don&#39;t need to specify a
            /// desired number of tasks, a task placement strategy, or 					use Service Auto Scaling policies. 				
            /// Note Tasks using the Fargate launch type or the 							CODE_DEPLOY or EXTERNAL deployment controller
            /// 						types don&#39;t support the DAEMON scheduling strategy. 			
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: DAEMON | REPLICA
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchedulingStrategy { get; set; }

            /// <summary>
            /// ServiceName
            /// 		
            /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, underscores, and
            /// hyphens are allowed. Service names must be unique within 			a cluster, but you can have similarly
            /// named services in multiple clusters within a 			Region or across multiple Regions.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            /// ServiceRegistries
            /// 		
            /// The details of the service discovery registry to associate with this service. For more
            /// 			information, see Service 				discovery.
            /// 		
            /// Note Each service may be associated with one service registry. Multiple service 				registries per
            /// service isn&#39;t supported.
            /// 	
            /// Required: No
            /// Type: List of ServiceRegistry
            /// Update requires: Replacement
            /// </summary>
            public List<ServiceRegistry> ServiceRegistries { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The metadata that you apply to the service to help you categorize and organize them. 			Each tag
            /// consists of a key and an optional value, both of which you define. When a 			service is deleted, the
            /// tags are deleted as well.
            /// The following basic restrictions apply to tags:
            /// Maximum number of tags per resource - 50 For each resource, each tag key must be unique, and each
            /// tag key can have only one value. Maximum key length - 128 Unicode characters in UTF-8 Maximum value
            /// length - 256 Unicode characters in UTF-8 If your tagging schema is used across multiple services and
            /// resources, remember that other services may have restrictions on allowed characters. Generally
            /// allowed characters are: letters, numbers, and spaces representable in UTF-8, and the following
            /// characters: + - = . _ : / @. Tag keys and values are case-sensitive. Do not use aws:, AWS:, or any
            /// upper or lowercase combination of such as a prefix for either keys or values as it is reserved for
            /// AWS use. You cannot edit or delete tag keys or values with this prefix. Tags with this prefix do not
            /// count against your tags per resource limit.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TaskDefinition
            /// The family and revision (family:revision) or full ARN of the task definition to run in your service.
            /// The revision is required in order for the resource to stabilize.
            /// A task definition must be specified if the service is using either the ECS or CODE_DEPLOY deployment
            /// controllers.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TaskDefinition { get; set; }

        }

        public string Type { get; } = "AWS::ECS::Service";

        public ServiceProperties Properties { get; } = new ServiceProperties();

    }

    public static class ServiceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
