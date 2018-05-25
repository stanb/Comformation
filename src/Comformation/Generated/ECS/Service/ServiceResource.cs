using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-cluster
            /// </summary>
			public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-deploymentconfiguration
            /// </summary>
			public Union<DeploymentConfiguration, IntrinsicFunction> DeploymentConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-desiredcount
            /// </summary>
			public Union<int, IntrinsicFunction> DesiredCount { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-healthcheckgraceperiodseconds
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckGracePeriodSeconds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-launchtype
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-loadbalancers
            /// </summary>
			public Union<List<LoadBalancer>, IntrinsicFunction> LoadBalancers { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-networkconfiguration
            /// </summary>
			public Union<NetworkConfiguration, IntrinsicFunction> NetworkConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementconstraints
            /// </summary>
			public Union<List<PlacementConstraint>, IntrinsicFunction> PlacementConstraints { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementstrategies
            /// </summary>
			public Union<List<PlacementStrategy>, IntrinsicFunction> PlacementStrategies { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-platformversion
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-role
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-servicename
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-serviceregistries
            /// </summary>
			public Union<List<ServiceRegistry>, IntrinsicFunction> ServiceRegistries { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-taskdefinition
            /// </summary>
			public Union<string, IntrinsicFunction> TaskDefinition { get; set; }

        }
    
        public string Type { get; } = "AWS::ECS::Service";
        
        public ServiceProperties Properties { get; } = new ServiceProperties();
    }

	public static class ServiceAttributes
	{
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
