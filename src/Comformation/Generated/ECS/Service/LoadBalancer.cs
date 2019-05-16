using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service LoadBalancer
    /// The LoadBalancer property specifies details on a load balancer that is used with a service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html
    /// </summary>
    public class LoadBalancer
    {

        /// <summary>
        /// ContainerName
        /// The name of the container (as it appears in a container definition) to associate with the load
        /// balancer.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        /// ContainerPort
        /// The port on the container to associate with the load balancer. This port must correspond to a
        /// containerPort in the service&#39;s task definition. Your container instances must allow ingress traffic
        /// on the hostPort of the port mapping.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        /// LoadBalancerName
        /// The name of the load balancer to associate with the Amazon ECS service.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

        /// <summary>
        /// TargetGroupArn
        /// The full Amazon Resource Name (ARN) of the Elastic Load Balancing target group or groups associated
        /// with a service. For services using the ECS deployment controller, you are limited to one target
        /// group. For services using the CODE_DEPLOY deployment controller, you are required to define two
        /// target groups for the load balancer.
        /// Important If your service&#39;s task definition uses the awsvpc network mode (which is required for the
        /// Fargate launch type), you must choose ip as the target type, not instance, because tasks that use
        /// the awsvpc network mode are associated with an elastic network interface, not an Amazon EC2
        /// instance.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

    }
}
