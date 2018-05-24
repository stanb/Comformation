using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html
    /// </summary>
    public class LoadBalancer
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-containername
        /// </summary>
        [JsonProperty("ContainerName")]
        public Union<string, IntrinsicFunction> ContainerName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-containerport
        /// </summary>
        [JsonProperty("ContainerPort")]
        public Union<int, IntrinsicFunction> ContainerPort { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-loadbalancername
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-targetgrouparn
        /// </summary>
        [JsonProperty("TargetGroupArn")]
        public Union<string, IntrinsicFunction> TargetGroupArn { get; set; }

    }
}
