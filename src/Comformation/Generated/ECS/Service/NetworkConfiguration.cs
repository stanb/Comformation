using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// Amazon Elastic Container Service Service NetworkConfiguration
    /// NetworkConfiguration is a property of the AWS::ECS::Service resource that specifies the network configuration
    /// for an Amazon Elastic Container Service (Amazon ECS) task or service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// AwsvpcConfiguration
        /// The VPC subnets and security groups associated with a task.
        /// Required: No
        /// Type: Amazon Elastic Container Service Service AwsVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsvpcConfiguration")]
        public Union<AwsVpcConfiguration, IntrinsicFunction> AwsvpcConfiguration { get; set; }

    }
}
