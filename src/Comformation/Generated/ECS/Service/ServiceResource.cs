using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service
    /// The AWS::ECS::Service resource creates an Amazon Elastic Container Service (Amazon ECS) service that runs and
    /// maintains the requested number of tasks and associated load balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// Cluster
            /// The name or Amazon Resource Name (ARN) of the cluster that you want to run your Amazon ECS service
            /// on. If you do not specify a cluster, Amazon ECS uses the default cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            /// DeploymentConfiguration
            /// Configures how many tasks run during a deployment.
            /// Required: No
            /// Type: DeploymentConfiguration
            /// Update requires: No interruption
            /// </summary>
			public DeploymentConfiguration DeploymentConfiguration { get; set; }

            /// <summary>
            /// DesiredCount
            /// The number of simultaneous tasks that you want to run on the cluster. Specify the tasks with the
            /// TaskDefinition property.
            /// Required: Conditional. Required only when creating an Amazon ECS Service.
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> DesiredCount { get; set; }

            /// <summary>
            /// HealthCheckGracePeriodSeconds
            /// The period of time, in seconds, that the Amazon ECS service scheduler ignores unhealthy Elastic Load
            /// Balancing target health checks after a task has first started.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckGracePeriodSeconds { get; set; }

            /// <summary>
            /// LaunchType
            /// The launch type on which to run your service. If one is not specified, EC2 will be used by default.
            /// Valid values include EC2 and FARGATE.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchType { get; set; }

            /// <summary>
            /// LoadBalancers
            /// A list of load balancer objects to associate with the cluster. If you specify the Role property,
            /// LoadBalancers must be specified as well. For information about the number of load balancers that you
            /// can specify per service, see Service Load Balancing in the Amazon Elastic Container Service
            /// Developer Guide.
            /// Required: Conditional
            /// Type: List of LoadBalancers property types
            /// Update requires: Replacement
            /// </summary>
			public List<LoadBalancer> LoadBalancers { get; set; }

            /// <summary>
            /// NetworkConfiguration
            /// The network configuration for the service. This parameter is required for task definitions that use
            /// the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for
            /// other network modes. For more information, see Task Networking in the Amazon Elastic Container
            /// Service Developer Guide.
            /// Required: No
            /// Type: NetworkConfiguration
            /// Update requires: No interruption
            /// </summary>
			public NetworkConfiguration NetworkConfiguration { get; set; }

            /// <summary>
            /// PlacementConstraints
            /// The placement constraints for the tasks in the service.
            /// Required: No
            /// Type: List of PlacementConstraint property types
            /// Update requires: Replacement
            /// </summary>
			public List<PlacementConstraint> PlacementConstraints { get; set; }

            /// <summary>
            /// PlacementStrategies
            /// The placement strategies that determine how tasks for the service are placed.
            /// Required: No
            /// Type: List of PlacementStrategies property types
            /// Update requires: Replacement
            /// </summary>
			public List<PlacementStrategy> PlacementStrategies { get; set; }

            /// <summary>
            /// PlatformVersion
            /// The platform version on which to run your service. If one is not specified, the latest version will
            /// be used by default.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

            /// <summary>
            /// Role
            /// The name or ARN of an AWS Identity and Access Management (IAM) role that allows your Amazon ECS
            /// container agent to make calls to your load balancer.
            /// Note In some cases, you might need to add a dependency on the service role&#39;s policy. For more
            /// information, see IAM role policy in DependsOn Attribute.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// SchedulingStrategy
            /// The scheduling strategy to use for the service.
            /// There are two service scheduler strategies available:
            /// REPLICA: The replica scheduling strategy places and maintains the desired number of tasks across
            /// your cluster. By default, the service scheduler spreads tasks across Availability Zones. You can use
            /// task placement strategies and constraints to customize task placement decisions. DAEMON: The daemon
            /// scheduling strategy deploys exactly one task on each container instance in your cluster. When using
            /// this strategy, do not specify a desired number of tasks or any task placement strategies.
            /// Valid values include REPLICA and DAEMON.
            /// Note Fargate tasks do not support the DAEMON scheduling strategy
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SchedulingStrategy { get; set; }

            /// <summary>
            /// ServiceName
            /// The name of your service. The name is limited to 255 letters (uppercase and lowercase), numbers,
            /// hyphens, and underscores. Service names must be unique within a cluster, but you can have similarly
            /// named services in multiple clusters within a region or across multiple regions.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            /// ServiceRegistries
            /// Details of the service registry.
            /// Required: No
            /// Type: List of ServiceRegistry property types
            /// Update requires: Replacement
            /// </summary>
			public List<ServiceRegistry> ServiceRegistries { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TaskDefinition
            /// The ARN of the task definition (including the revision number) that you want to run on the cluster,
            /// such as arn:aws:ecs:us-east-1:123456789012:task-definition/mytask:3. You can&#39;t use :latest to
            /// specify a revision because it&#39;s ambiguous. For example, if AWS CloudFormation needed to roll back an
            /// update, it wouldn&#39;t know which revision to roll back to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> TaskDefinition { get; set; }

        }

        public string Type { get; } = "AWS::ECS::Service";

        public ServiceProperties Properties { get; } = new ServiceProperties();

    }

	public static class ServiceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
