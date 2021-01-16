using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service LoadBalancer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html
    /// </summary>
    public class LoadBalancer
    {

        /// <summary>
        /// ContainerName
        /// 		
        /// The name of the container (as it appears in a container definition) to associate with 			the load
        /// balancer.
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
        /// The port on the container to associate with the load balancer. This port must 			correspond to a
        /// containerPort in the task definition the tasks in the 			service are using. For tasks that use the
        /// EC2 launch type, the container 			instance they are launched on must allow ingress traffic on the
        /// hostPort of 			the port mapping.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        /// LoadBalancerName
        /// 		
        /// The name of the load balancer to associate with the Amazon ECS service or task set.
        /// 		
        /// A load balancer name is only specified when using a Classic Load Balancer. If you are using an
        /// Application Load Balancer 			or a Network Load Balancer the load balancer name parameter should be
        /// omitted.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

        /// <summary>
        /// TargetGroupArn
        /// 		
        /// The full Amazon Resource Name (ARN) of the Elastic Load Balancing target group or groups associated
        /// with a service or 			task set.
        /// 		
        /// A target group ARN is only specified when using an Application Load Balancer or Network Load
        /// Balancer. If you are using a 			Classic Load Balancer the target group ARN should be omitted.
        /// 		
        /// For services using the ECS deployment controller, you can specify one or 			multiple target groups.
        /// For more information, see Registering Multiple Target Groups with a Service in 			the Amazon Elastic
        /// Container Service Developer Guide.
        /// 		
        /// For services using the CODE_DEPLOY deployment controller, you are 			required to define two target
        /// groups for the load balancer. For more information, see 				Blue/Green Deployment with CodeDeploy in
        /// the 				Amazon Elastic Container Service Developer Guide.
        /// 		
        /// Important If your service&#39;s task definition uses the awsvpc network mode (which 				is required for
        /// the Fargate launch type), you must choose 					ip as the target type, not instance, when creating
        /// 				your target groups because tasks that use the awsvpc network mode are 				associated with an
        /// elastic network interface, not an Amazon EC2 instance.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

    }
}
