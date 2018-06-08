using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// Amazon Elastic Container Service Service LoadBalancers
    /// LoadBalancers is a property of the AWS::ECS::Service resource that specifies the load balancer to associate
    /// with an Amazon Elastic Container Service (Amazon ECS) service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html
    /// </summary>
    public class LoadBalancer
    {

        /// <summary>
        /// ContainerName
        /// The name of a container to use with the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        /// ContainerPort
        /// The port number on the container to direct load balancer traffic to. Your container instances must
        /// allow ingress traffic on this port.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        /// LoadBalancerName
        /// The name of a Classic Load Balancer to associate with the Amazon ECS service.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

        /// <summary>
        /// TargetGroupArn
        /// An Application load balancer target group Amazon Resource Name (ARN) to associate with the Amazon
        /// ECS service.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

    }
}
