using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// Amazon Elastic Container Service Service AwsVpcConfiguration
    /// AwsVpcConfiguration is a property of the AWS::ECS::Service resource that specifies the subnets and security
    /// groups for an Amazon Elastic Container Service (Amazon ECS) task or service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html
    /// </summary>
    public class AwsVpcConfiguration
    {

        /// <summary>
        /// AssignPublicIp
        /// Valid values include ENABLED and DISABLED.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssignPublicIp")]
        public Union<string, IntrinsicFunction> AssignPublicIp { get; set; }

        /// <summary>
        /// SecurityGroups
        /// The security groups associated with the task or service. If you do not specify a security group, the
        /// default security group for the VPC is used.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// Subnets
        /// The subnets associated with the Amazon ECS task or service.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnets")]
        public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

    }
}
