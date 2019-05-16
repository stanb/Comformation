using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service NetworkConfiguration
    /// The NetworkConfiguration property specifies an object representing the network configuration for a task or
    /// service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// AwsvpcConfiguration
        /// The VPC subnets and security groups associated with a task.
        /// Note All specified subnets and security groups must be from the same VPC.
        /// Required: No
        /// Type: AwsVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsvpcConfiguration")]
        public AwsVpcConfiguration AwsvpcConfiguration { get; set; }

    }
}
